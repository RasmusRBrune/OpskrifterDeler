using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseEntityController<Account,Guid>
    {

        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(IAccountService service, IPushNotificationService notificationService, SignInManager<IdentityUser> signInManager) : base(service, notificationService)
        {
            _signInManager = signInManager;
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login(string Email,string Password)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(Email,Password,false, lockoutOnFailure: false);
                if (result is null)
                {
                    return BadRequest("error need to be a valid email or password need to have 8 long, 1 number and one uppercase");
                }
                return Ok(result);
            }
            catch (Exception e)
            {

                return Problem(e.Message);
            }
        }
    }
}
