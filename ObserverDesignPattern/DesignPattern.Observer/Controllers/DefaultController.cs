using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DesignPattern.Observer.DAL;
using DesignPattern.Observer.Models;
using System.Threading.Tasks;
using DesignPattern.Observer.ObserverPattern;
using System;

namespace DesignPattern.Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.Username
            };

            var result = await _userManager.CreateAsync(appUser, model.Paasword);
            if (result.Succeeded)
            {
                _observerObject.NotificyObserver(appUser);
            }
            return View();
        }
    }
}
