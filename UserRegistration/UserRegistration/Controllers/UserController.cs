using Busniess.Services;
using DataAccess.Context;
using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistration.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;
        public UserController(IUserService user)
        {
            userService = user;
        }
        public IActionResult Index()
        {
            return View("Register");
        }
        public IActionResult InsertUser(User  user )
        {
            if (ModelState.IsValid == true)
            {
                userService.Insert(user);
                return RedirectToAction("LoginPage");
            }
            else
            {
                return View("Register");

            }
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult Login(User user)
        {
            var usr = userService.IsValid(user);
            if(usr == true)
            {
                return View("Welcome");
            }
            else
            {
                ViewData["false"] = "user name or password is wrong";
                return View("LoginPage");
            }

        }
    }
}
