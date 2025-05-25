using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Lab4.Models;


namespace Lab4.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
            // thêm một số người dùng mẫu
            new User() {id="1",username="aaa",password="1",phone="111",email="111"},
            new User() {id="2",username="bbb",password="2",phone="222",email="222"},
            new User() {id="3",username="ccc",password="3",phone="333",email="333"},
            new User() {id="4",username="ddd",password="4",phone="444",email="444"},


        };

        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                users.Add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            User user = users.Find(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                User existingUser = users.Find(u => u.id == user.id);
                if (existingUser != null)
                {
                    existingUser.username = user.username;
                    existingUser.password = user.password;
                    existingUser.email = user.email;
                    existingUser.phone = user.phone;
                }
                return RedirectToAction("Index");
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            User user = users.Find(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string id)
        {
            User user = users.Find(u => u.id == id);
            if (user != null)
            {
                users.Remove(user);
            }
            return RedirectToAction("Index");

        }
    }
}
