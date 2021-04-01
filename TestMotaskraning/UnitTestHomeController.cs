using Microsoft.VisualStudio.TestTools.UnitTesting;
using MotaskraningWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FakeItEasy;
using MotaskraningWeb.Models;

namespace TestMotaskraning
{
    [TestClass]
    public class UnitTestHomeController
    {
        HomeController Contr;
        [TestInitialize()]
        public void Startup()
        {
            ILogger<HomeController> loggr = A.Fake<ILogger<HomeController>>();
            Contr = new HomeController(loggr);
        }

        [TestMethod]
        public void TestGetIndex()
        {
            var ar = Contr.Index() as ViewResult;
            IActionResult result = Contr.Index();

            string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }

        [TestMethod]
        public void testpostindex_empmodel_empty()
        {
            MotaskraningModel empmodel = new MotaskraningModel();

            var ar = Contr.Index() as ViewResult;
            IActionResult result = Contr.Index(empmodel);

            string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }

        [TestMethod]
        public void testpostindex_empmodel_not_empty()
        {
            MotaskraningModel empmodel = new MotaskraningModel();
            empmodel.skraning = new Skraning();
            empmodel.skraning.DagsFra = System.DateTime.Now;
            empmodel.skraning.DagsTil = System.DateTime.Now;
            empmodel.skraning.motshaldari = "";
            empmodel.skraning.stadsetning = "";
            empmodel.skraning.domari = "";

            var ar = Contr.Index() as ViewResult;
            IActionResult result = Contr.Index(empmodel);

            string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }
    }
}
