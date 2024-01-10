using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using to_do_list.Business.Abstract;
using to_do_list.Entities;

namespace to_do_list.Controllers
{
    
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LogUser()
        {
 
            return View();
        }
        [HttpPost]
        public IActionResult LogUser(string txtId, string txtPassword)
        {
            
            var logUser = _userService.checkUser(Convert.ToInt32(txtId), txtPassword);
            if (!logUser.Equals(null))
            {
                
                TempData["UserName"] = logUser.Name;
                TempData["UserPassword"] = logUser.Password;
                TempData["UserId"] = logUser.Id;
                TempData.Keep("UserId");
                return RedirectToAction("Main", "List", logUser);
            }
            return View();
        }
  

        public IActionResult UserSign()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult UserSign(string txtName,string txtPassword)
        {
            var user = new User();
            user.Name = txtName;
            user.Password = txtPassword;
            _userService.createUser(user);
            if (!_userService.Equals(null))
            {
                return RedirectToAction("Main", "List", user);
            }
            return View();
        }

    }
}
