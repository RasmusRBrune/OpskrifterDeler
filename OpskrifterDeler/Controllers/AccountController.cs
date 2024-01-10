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
        private readonly IAccountService _accountService;
        public AccountController(IAccountService service,IAccountService accountService) : base(service)
        {
             _accountService = accountService;
        }


        [HttpGet("GetAccountById/{id}")]
        public async Task<IActionResult> GetAccountByUserId(string id)
        {
            try
            {
                var result = _accountService.GetAccountByUserId(Guid.Parse(id));
                if (result is not null)
                {
                    return Ok(result);
                }
                return BadRequest("The Account does not exist");
            }
            catch (Exception e)
            {

                return Problem(e.Message);
            }
        }
    }
}
