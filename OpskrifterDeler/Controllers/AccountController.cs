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

        //private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly IUserStore<IdentityUser> _userStore;
        //private readonly IUserEmailStore<IdentityUser> _emailStore;

        //public AccountController(
        //    IAccountService service,
        //    IAccountService accountService, 
        //    SignInManager<IdentityUser> signInManager, 
        //    UserManager<IdentityUser> userManager, 
        //    IUserStore<IdentityUser> userStore,
        //    IUserEmailStore<IdentityUser> emailStore) : base(service)
        //{
        //    _accountService = accountService;
        //    _signInManager = signInManager;
        //    _userManager = userManager;
        //    _userStore = userStore;
        //    _emailStore = emailStore;
        //}

        //[HttpPost]
        //public async Task<IActionResult> Login(string Email, string Password)
        //{
        //    try
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(Email, Password, false, lockoutOnFailure: false);
        //        if (result.Succeeded)
        //        {
        //            return Ok(result);
        //        }
        //        //if (result.RequiresTwoFactor)
        //        //{
        //        //    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
        //        //}
        //        if (result.IsLockedOut)
        //        {
        //            return Unauthorized("User account locked out.");
        //        }
        //        else
        //        {
        //            return BadRequest("Email or Password is Invalid");
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        return Problem(e.Message);
        //    }
        //}


        //[HttpPost]
        //public async Task<IActionResult> Register(string Email, string Password)
        //{
        //    try
        //    {
        //        var user = Activator.CreateInstance<IdentityUser>();

        //        await _userStore.SetUserNameAsync(user, Email, CancellationToken.None);
        //        await _emailStore.SetEmailAsync(user, Email, CancellationToken.None);
        //        var result = await _userManager.CreateAsync(user, Password);
        //        if (result.Succeeded)
        //        {
        //            var userId = await _userManager.GetUserIdAsync(user);
        //            var Accountreturn = await _accountService.AddAsync(new Account{ AccountId = Guid.Parse(userId) });
        //            return Ok(Accountreturn);
        //        }
        //        return BadRequest(result.Errors);

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
