using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TestMitra2.Models;
using TestMitra2.Models.Domain;
using TestMitra2.Models.ViewModels;
using TestMitra2.Data;
using Azure.Identity;

namespace TestMitra2.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly BlogDbContext _blogDbContext;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, BlogDbContext blogDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _blogDbContext = blogDbContext;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistryViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Email = model.Email,
                    UserName = model.Name,
                    Password = model.Password
                };


                //_blogDbContext.Users.Add(user);
                //_blogDbContext.SaveChanges();
                //await _blogDbContext.SaveChangesAsync();

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    ViewBag.SuccessMessage = "Регистрация прошла успешно!";
                    await _signInManager.SignInAsync(user, false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }

            }

            return View(model);
        }
    }
}




