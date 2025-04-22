using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LAB2.Controllers
{
    public class TodoController : Controller
    {
        private static List<string> tasks = new List<string>
        {
            "Ôn tập HTML",
            "Ôn tập CSS",
            "Ôn tập Bootstrap"
        };

        public IActionResult Index()
        {
            ViewBag.Tasks = tasks;
            return View();
        }

    
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string newTask)
        {
            if (!string.IsNullOrEmpty(newTask))
            {
                tasks.Add(newTask);
            }
            return RedirectToAction("Index");
        }

  
        public IActionResult Edit(int id)
        {
            if (id >= 0 && id < tasks.Count)
            {
                ViewBag.TaskId = id;
                ViewBag.TaskName = tasks[id];
                return View();
            }
            return NotFound();
        }

      
        [HttpPost]
        public IActionResult Edit(int id, string updatedTask)
        {
            if (id >= 0 && id < tasks.Count && !string.IsNullOrEmpty(updatedTask))
            {
                tasks[id] = updatedTask;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            if (id >= 0 && id < tasks.Count)
            {
                tasks.RemoveAt(id);
            }
            return RedirectToAction("Index");
        }
 
       
    }
}
