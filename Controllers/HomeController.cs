using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample_Test_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_Test_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IndexpageModel model = new IndexpageModel();


            AdminModel adminModel = new AdminModel();
            adminModel.FirstName = "John";
            adminModel.LastName = "MM";
            adminModel.Email = "johnmm@gmail.com";
            adminModel.Mobile = "99023223222";


            UserModel userModel = new UserModel();
            userModel.FirstName = "Albert";
            userModel.LastName = "James";
            userModel.Email = "albertjames@gmail.com";
            userModel.Mobile = "894433534";


            model.AdminModel = adminModel;
            model.UserModel = userModel;

            return View(model);
        }

        public IActionResult Privacy()
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
