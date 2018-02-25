using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;


namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index(){
            return View();
        }
        [HttpPost("/")]
        public ActionResult Form(){
        string groupInput = Request.Form["groupofwords"];
        string specificInput = Request.Form["specificword"];
        ReapeatCounter userInput = new ReapeatCounter(groupInput, specificInput);
        return View("Index", userInput);
        }

    }
}
