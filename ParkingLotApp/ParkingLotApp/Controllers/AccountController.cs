using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ParkingLotApp.Controllers;
using ParkingLotApp.Domain.Model;
using ParkingLotApp.Models;

namespace ParkingLotApp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser>signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            RedirectUserWhenAlreadyLoggedIn();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            //register the user
            if (ModelState.IsValid)
            {
                var newUser = new AppUser
                {
                    UserName = vm.Email,
                    NormalizedUserName = vm.Email.ToUpper(),
                    Email = vm.Email,
                    NormalizedEmail = vm.Email.ToUpper()
                };

                 var result = await _userManager.CreateAsync(newUser, vm.Password);

                if (result.Succeeded)
                {
                    // new user got created
                    //we can login the user
                    await _signInManager.SignInAsync(newUser, false);
                    //send user to the right page (redirect)
                    return RedirectToAction("Index","Home"); //home/index

                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            // sending back the error to the view (register form)
            return View(vm);
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(vm.Email, vm.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Email or Password incorrect");
                }
                return View(vm);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        private IActionResult RedirectUserWhenAlreadyLoggedIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return null;
        }
    }
}