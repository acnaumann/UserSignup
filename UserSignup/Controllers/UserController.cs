using Microsoft.AspNetCore.Mvc;
using UserSignup.ViewModels;

namespace UserSignup.Controllers
{
    public class UserController : Controller 
    {


        //GET: /<controller>/
        public IActionResult Index(string username )
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
            //user.Password == verify  --  this will not work because you are actually
            //comparing the "reference" of the strings so when a new string is created
            //it would not have the same reference as the original/comparison.

            return View(addUserViewModel);
            
        }
    }
}
