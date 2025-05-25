using Lab5.Areas.Administrator.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace LAB5.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class UserController : Controller
    {
        private static List<User> _users;

        public UserController()
        {
            if (_users == null)
            {
                _users = new List<User>()
                {
                    new User() { id = 1, name = "Herman Beck", progress = 25, amount = 77.99, deadline = DateTime.Now, image = "face1.jpg" },
                    new User() { id = 2, name = "Messsy Adam", progress = 75, amount = 222.99, deadline = DateTime.Now, image = "face2.jpg" },
                    new User() { id = 3, name = "John Richards", progress = 80, amount = 123.99, deadline = DateTime.Now, image = "face3.jpg" },
                    new User() { id = 4, name = "Peter Meggik", progress = 95, amount = 432.99, deadline = DateTime.Now, image = "face4.jpg" },
                    new User() { id = 5, name = "Edward", progress = 100, amount = 111.99, deadline = DateTime.Now, image = "face5.jpg" },
                    new User() { id = 6, name = "John Doe", progress = 30, amount = 22.22, deadline = DateTime.Now, image = "face6.jpg" },
                    new User() { id = 7, name = "Henry Tom", progress = 45, amount = 47.99, deadline = DateTime.Now, image = "face7.jpg" },
                };
            }
        }

        public IActionResult Index()
        {
            return View(_users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                user.id = _users.Any() ? _users.Max(u => u.id) + 1 : 1;
                _users.Add(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public IActionResult Edit(int id)
        {
            var user = _users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, User user)
        {
            if (id != user.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingUser = _users.FirstOrDefault(u => u.id == id);
                if (existingUser == null)
                {
                    return NotFound();
                }

                existingUser.name = user.name;
                existingUser.progress = user.progress;
                existingUser.amount = user.amount;
                existingUser.deadline = user.deadline;
                existingUser.image = user.image;

                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public IActionResult Delete(int id)
        {
            var user = _users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = _users.FirstOrDefault(u => u.id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}