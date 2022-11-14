using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web_Labs.Models;
using System;
using System.Threading;

namespace Web_Labs.Controllers
{
    public class HomeController : Controller
    {
        private IDataModels repository;

        public HomeController(IDataModels repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<RedirectToActionResult> Index(int position, string content)
        {
            await repository.AddOrEdit(new AccordoinModel
            {
                Content = content,
                Position = position
            });
            return RedirectToAction("Index");
        }
        public IActionResult ShowAccordion()
        {
            return View(repository.Models.OrderBy(m => m.Position));
        }
    }
}
