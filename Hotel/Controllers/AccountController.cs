using Hotel.DBContext;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Hotel.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            HttpContext.Session.Clear();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("Username", "Username already exists. Please choose a different username.");
                    return View(user);
                }
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(user);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var authenticatedUser = _context.Users
                .FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            if (ModelState.IsValid)
            {
                var authUser = _context.Users.FirstOrDefault(u => u.Username == u.Username && u.Password == user.Password);
                if (authUser != null)
                {
                    string userJson = JsonConvert.SerializeObject(authenticatedUser);
                    
                    if (authUser.Level == 1)
                    {
                        HttpContext.Session.SetString("pm_si", userJson);
                        return RedirectToAction("Index", "Home");
                    }
                    else if (authUser.Level == 2)
                    {
                        HttpContext.Session.SetString("pm_si",userJson);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Password", "User is Not Authorized");
                        return View(user);
                    }
                }
                else
                {
                    ModelState.AddModelError("Password", "Username or Password Is Incorrect");
                    return View(user);
                }
            }
            return View(user);
        }
    }
}
