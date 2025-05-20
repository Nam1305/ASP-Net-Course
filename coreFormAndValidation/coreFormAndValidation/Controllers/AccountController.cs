using coreFormAndValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreFormAndValidation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;    
            ViewBag.Password = password;
            return View();
        }

        public IActionResult StronglyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginSuccess(LoginViewModel login)
        {
            ViewBag.Username = login.Username;
            ViewBag.Password = login.Password;
            return View();
        }

        public IActionResult UserDetail()
        {
            var user = new LoginViewModel()
            {
                Username = "Pham Hoang Nam",
                Password = "12345"
            };
            return View(user);
        }

        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
                new LoginViewModel(){Username = "Pham Hoang 1",Password = "12345"},
                new LoginViewModel(){Username = "Pham Hoang 2",Password = "12345"},
                new LoginViewModel(){Username = "Pham Hoang 3",Password = "12345"},
                new LoginViewModel(){Username = "Pham Hoang 4",Password = "12345"},

            };
            return View(users);
        }
    }
}
