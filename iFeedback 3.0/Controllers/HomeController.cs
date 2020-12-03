using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using iFeedback.Models;
using iFeedback.DAL;

namespace iFeedback.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFeedbackRepository _feedbackRepository;

        public HomeController(ILogger<HomeController> logger, IFeedbackRepository ifeedbackRepository)
        {
            _logger = logger;
            _feedbackRepository = ifeedbackRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("CustomerName,CustomerEmail, CustomerPhone,Rating,Comment, Ip, Country, City, Region")] Feedback feedbackData)
        {

            if (ModelState.IsValid)
            {
                _feedbackRepository.Add(feedbackData);
                _feedbackRepository.Commit();

                TempData["message"] = "Feedback was created successfully";
            }

            return RedirectToAction("index");
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
