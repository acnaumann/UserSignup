using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UserSignup.Models;
using System.Collections.Generic;

namespace UserSignup.Controllers
{
    public class UserController : Controller 
    {


        //GET: /<controller>/
        public IActionResult Index(string username = "User")
        {
            //User user = new User("Alysson", "alysson.seevers@gmail.com", "password");
            //User user = new User();
            ViewBag.username = username;
            return View();
        }


        //GET /User/Add
        public IActionResult Add()
        {
            return View();
        }


        //POST /User/Add
        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            //user.Password == verify  --  this will not work because you are actually
            //comparing the "reference" of the strings so when a new string is created
            //it would not have the same reference as the original/comparison.
            if (user != null && user.Password.Equals(verify))
            {
                return Redirect("Index?username=" + user.Username);
            }

            if (user != null)
            {
                ViewBag.username = user.Username;
                ViewBag.email = user.Email;
            }
            ViewBag.error = "Please enter valid username/password";
            return View();
        }
    }
}
