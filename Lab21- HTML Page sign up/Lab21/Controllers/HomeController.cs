using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21.Models;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.Greeting = "Welcome to the Ocean of Dreams";
            return View();
        }
        [HttpGet]
        public ViewResult RideTheWave()
        {
            ViewBag.Greeting = "Welcome to the Ocean of Dreams";
            return View();
        }

     
        [HttpPost]
        public ViewResult RideTheWave(RegistrationForm registrationForm)
        {
            //TODO: email response to party organizer
     
                return View("Thanks", registrationForm);
            
           
            
        }
        
    }
}