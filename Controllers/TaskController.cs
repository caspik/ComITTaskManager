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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
