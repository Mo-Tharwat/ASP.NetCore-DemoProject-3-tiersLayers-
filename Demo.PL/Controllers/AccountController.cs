using Demo.DAL.Models;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;

		public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
			_userManager = userManager;
			_signInManager = signInManager;
		}

        //[HttpGet] //This verb is default.
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if(ModelState.IsValid) //Server Side Validation
            {
                //Manual Mapping
                var user = new ApplicationUser()
                {
                    FName       = viewModel.FName,
                    LName       = viewModel.LName,
                    UserName    = viewModel.Email.Split('@')[0],
                    Email       = viewModel.Email,
                    IsAgree     = viewModel.IsAgree
                };

                var result = await _userManager.CreateAsync(user, viewModel.Password);

                if (result.Succeeded)
                    return RedirectToAction(nameof(Login));

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);

            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Login() 
        { 
            return View(); 
        }

    }
}
