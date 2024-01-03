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

        [HttpPost]
        public async Task<IActionResult> Register(Guid UserId)
        {
            try
            {
                var result = await _accountService.AddAsync(new Account());
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
