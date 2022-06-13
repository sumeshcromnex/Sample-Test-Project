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
            model.AdminModel = adminModel;

            model.usersAgeAbove30 = this.getUserAboveAge30();
            model.users = this.getListOfUsers();
            model.user = this.getUserByEmailId("albertjames@gmail.com");

            return View(model);
        }

        public List<UserModel> getUserAboveAge30()
        {
            return this.getListOfUsers().Where(x => x.Age > 30).ToList();
        }

        public UserModel getUserByEmailId(string emailId)
        {
            return this.getListOfUsers().Where(x => x.Email == emailId).FirstOrDefault();
        }


        public List<UserModel> getListOfUsers()
        {
            
            List<UserModel> users = new List<UserModel>();

            UserModel user1 = new UserModel();
            user1.FirstName = "Albert";
            user1.LastName = "James";
            user1.Email = "albertjames@gmail.com";
            user1.Mobile = "894433534";
            user1.Age = 28;

            UserModel user2 = new UserModel();
            user2.FirstName = "Peter";
            user2.LastName = "Thomas";
            user2.Email = "PeterThomas@gmail.com";
            user2.Mobile = "9827255112";
            user2.Age = 45;

            UserModel user3 = new UserModel();
            user3.FirstName = "Martin";
            user3.LastName = "Mathew";
            user3.Email = "martinmathew@gmail.com";
            user3.Mobile = "7881223211";
            user3.Age = 30;

            UserModel user4 = new UserModel();
            user4.FirstName = "Abin";
            user4.LastName = "QQ";
            user4.Email = "abinqq@gmail.com";
            user4.Mobile = "9822733222";
            user4.Age = 21;

            UserModel user5 = new UserModel();
            user5.FirstName = "Abin";
            user5.LastName = "George";
            user5.Email = "abingeorge@gmail.com";
            user5.Mobile = "23453334";
            user5.Age = 33;


            //assign users to the list

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
            users.Add(user5);
            
            
            return users;

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
