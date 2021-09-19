using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDemo.Models;

namespace WebAppDemo.Controllers
{
    public class DoctorController : Controller
    {
        [Route("/FeverCheck")]
        public IActionResult FeverCheck(Fever model)
        {
            if (!ValidateFever.IsNotNull(model.Temprature))
            {
                ViewData["Message"] = "Enter A Temprature";
                return View();
            }
            if (model.Unit == "Fahrenheit")
            {
                if (model.Temprature > 99)
                {
                    ViewData["Message"] = "You Have Fever";
                }
                else if(model.Temprature < 95)
                {
                    ViewData["Message"] = "You Don't Have Fever But You Have Hypothermia";
                }
                else
                {
                    ViewData["Message"] = "You Don't Have Fever";
                }
            }
           if (model.Unit == "Celsius")
           {
                if (model.Temprature > 38)
                {
                    ViewData["Message"] = "You Have Fever";
                }
                else if (model.Temprature < 35)
                {
                    ViewData["Message"] = "You Don't Have Fever But You Have Hypothermia";
                }
                else
                {
                    ViewData["Message"] = "You Don't Have Fever";
                }
           }
            return View();
        }
    }
}
