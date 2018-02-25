using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTest
    {

      [TestMethod]
      public void Index_Return_True()
      {
           HomeController controller = new HomeController();
           IActionResult actionResult = controller.Index();
           ViewResult indexView = controller.Index() as ViewResult;

           var result = indexView.ViewData.Model;

           Assert.IsInstanceOfType(result, typeof(ViewResult));
       }
    }
}
