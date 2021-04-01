using Microsoft.VisualStudio.TestTools.UnitTesting;
using MotaskraningWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FakeItEasy;

namespace TestMotaskraning
{
    [TestClass]
    public class UnitTestHomeController
    {
        [TestMethod]
        public void TestMethod1()
        {
            ILogger<HomeController> loggr = A.Fake<ILogger<HomeController>>();
            HomeController Contr = new HomeController(loggr);
            var ar = Contr.Index() as ViewResult;
            IActionResult result = Contr.Index();

            string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }
    }
}
