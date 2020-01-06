using Microsoft.AspNetCore.Mvc;
using UserSignup.ViewModels;

namespace UserSignup.Controllers
{
    public class UserController : Controller 
    {
        //GET: /<controller>/
        public IActionResult Index(string username = "User" )
        {
            //User user = new User("Alysson", "alysson.seevers@gmail.com", "password");
            //User user = new User();
            ViewBag.username = username;
            return View();
        }

        //GET /User/Add
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        //POST /User/Add
        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {

                return Redirect("/User/Index?username=" + addUserViewModel.Username);
            }

            return View(addUserViewModel);
            
        }
    }
}
