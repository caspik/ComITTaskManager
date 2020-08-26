using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskManager.Models;

using TaskManager.DAL;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        IStoreTasks _taskStorage;
        IStoreTasks _tasksStorage;

        public TaskController(IStoreTasks myTaskStorage)
        {
            _tasksStorage = myTaskStorage;
        }

        public IActionResult Index()
        {
            var tasks = _tasksStorage.GetAllItems();
            return View(tasks);
        }

        public IActionResult Details(Guid id) {
            var item = _taskStorage.GetById(id);
            return View(item);
        }

        public IActionResult Create() {
            return View("Upsert");
        }

        [HttpPost]
        public IActionResult Create(TaskList newTask) {
            newTask.Id = Guid.NewGuid();
            //newItem.Batches = new List<Batch>();
            newTask.IsDeleted = false;
            //newItem.UserId = UserId();
            _taskStorage.CreateTaskList(newTask);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
