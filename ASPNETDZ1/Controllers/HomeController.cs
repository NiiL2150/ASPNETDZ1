using ASPNETDZ1.Models;
using ASPNETDZ1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETDZ1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToDoList _list;

        public HomeController(ILogger<HomeController> logger, IToDoList list)
        {
            _logger = logger;
            _list = list;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ToDoPage()
        {
            return View(_list);
        }

        [HttpGet]
        public IActionResult ToDoAdd()
        {
            return RedirectToAction("ToDoPage");
        }

        [HttpPost]
        public IActionResult ToDoAdd(string text)
        {
            _list.Add(text);
            return RedirectToAction("ToDoPage");
        }

        [HttpGet]
        public IActionResult ToDoDelete(int id)
        {
            _list.RemoveAt(id);
            return RedirectToAction("ToDoPage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
