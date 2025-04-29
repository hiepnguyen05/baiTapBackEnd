using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
         {
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
         };
        public IActionResult Index()
        {
            return View(users);
        }

    }
}
