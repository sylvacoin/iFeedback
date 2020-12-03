using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iFeedback.BL;
using iFeedback.DAL;
using iFeedback.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace iFeedback.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger<DashboardController> _logger;

        //Dependency Injection done here. Injects the IFeedbackRepository Interface here
        //Check startup.cs line 58 to find out how .Net identifies the right class to call.
        public DashboardController(
            IFeedbackRepository feedbackRepository, 
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            ILogger<DashboardController> logger)
        {
            _feedbackRepository = feedbackRepository;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [Authorize]
        public async Task<ViewResult> Index()
        {
            //Calls the User Claims to get the detail of the currently logged User.
            var user = await _userManager.GetUserAsync(User);// will give the user's userName
            var userName = user.FirstName + " " + user.LastName;

            //Instantiates the dashboard view model with dashboard stats.
            DashboardViewModel dashboardView = new DashboardViewModel();
            dashboardView.AverageRating = _feedbackRepository.GetAverageRating();
            dashboardView.TotalCustomers = _feedbackRepository.GetTotalCustomers();
            dashboardView.TotalFeedback = _feedbackRepository.GetAll().Count();
            dashboardView.Username = userName;
            return View(dashboardView);
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int customerId)
        {
            Feedback feedback = _feedbackRepository.GetFeedbackByCustomer(customerId);
            ViewData["page-title"] = $"{feedback.CustomerName} Customer Feedback";

            //Using Custom BL 
            //Utilities custom class contains custom reuseable methods. Promoting DRY principle and Encapsulation.
            Utilities _util = new Utilities();
            ViewData["imgHash"] = _util.md5(feedback.CustomerEmail);

            return View(feedback);
        }

       

        // GET: HomeController/List
        public ViewResult List()
        {
            IEnumerable<Feedback> feedbacks = _feedbackRepository.GetAll().ToList();
            ViewData["page-title"] = "Customer Feedbacks";
            return View(feedbacks);
        }


        [Route("api/get-chart-data")]
        public JsonResult GetChartData()
        {
            var result = _feedbackRepository.GetGroupedRating();
            return Json(result);
        }


        public async Task<IActionResult> Logout()
        {
            var returnUrl = "/";

            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
           
            return Redirect(returnUrl);
            
        }
    }
}
