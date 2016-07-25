using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewApp.Models;

namespace NewApp.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult DataDisplay(string searching)
        {
            var data = DataBase.UsersData();

            if (!string.IsNullOrEmpty(searching))
            {
                data = data.FindAll(
                d => d.FirstName.Contains(searching) ||
                     d.LastName.Contains(searching) ||
                     d.UserStatus.Contains(searching) ||
                     d.Email.Contains(searching));
            }
            return View(data);
        }

        //Create a search function to return data requested b the user of

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public int Echo(int str)
        {
            return str;
        }
    }
}
