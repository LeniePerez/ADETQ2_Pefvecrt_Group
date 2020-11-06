using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADETQ2_Perfvecrt_Group.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADTQ2_PerfvecrtGroup.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good AM" : "Good PM";
            return View();
        }

       
       
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
