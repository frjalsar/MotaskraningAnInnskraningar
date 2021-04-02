using Microsoft.VisualStudio.TestTools.UnitTesting;
using MotaskraningWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FakeItEasy;
using MotaskraningWeb.Models;
using System.Collections.Generic;

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

        // Todo: check that there are values in the objects that should have them
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

        // Todo: Fix
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException),
        "There is null in the place of skraning in the empmodel object.")]
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

        // Todo: Fix
        [TestMethod]
        public void testpostindex_empmodel_not_empty()
        {
            MotaskraningModel empmodel = new MotaskraningModel();
            empmodel.skraning = new Skraning();

            var ar = Contr.Index() as ViewResult;
            IActionResult result = Contr.Index(empmodel);

            string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }

        // Todo: Fix
        [TestMethod]
        public void testpostindex_skraning_not_empty()
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

        // Todo: Fix
        [TestMethod]
        public void testpostindex_Greinar_not_empty()
        {
            MotaskraningModel empmodel = new MotaskraningModel();
            empmodel.skraning = new Skraning();
            empmodel.skraning.DagsFra = System.DateTime.Now;
            empmodel.skraning.DagsTil = System.DateTime.Now;
            empmodel.skraning.motshaldari = "";
            empmodel.skraning.stadsetning = "";
            empmodel.skraning.domari = "";
            List<Grein> OneEvent = new List<Grein>();
            Grein TheEvent = new Grein();
            OneEvent.Add(TheEvent);
            empmodel.Greinar = OneEvent;

            var ar = Contr.Index() as ViewResult;
            IActionResult result = Contr.Index(empmodel);

            string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }

        // Todo: Fix
        [TestMethod]
        public void testAddChild()
        {
            var ar = Contr.AddChild() as PartialViewResult;
            // IActionResult result = Contr.AddChild();

            // string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }

        // Todo: Fix
        [TestMethod]
        public void testAddChild2()
        {
            var ar = Contr.AddChild2() as PartialViewResult;
            // IActionResult result = Contr.AddChild();

            // string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }

        // Todo: Fix
        [TestMethod]
        public void testAddChild3()
        {
            var ar = Contr.AddChild3() as PartialViewResult;
            // IActionResult result = Contr.AddChild();

            // string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }

        // Todo: Fix
        [TestMethod]
        public void testAddChild4()
        {
            var ar = Contr.AddChild4() as PartialViewResult;
            // IActionResult result = Contr.AddChild();

            // string res = result.ToString(); //Index().ViewData.Model;

            var keys = ar.ViewData.Keys;
            var values = ar.ViewData.Values;

            Assert.IsNotNull(keys);
            Assert.IsNotNull(values);
        }

        // Todo: check there is at least one judge and he has a name, that is not "" or null
        [TestMethod]
        public void testNaIDomara()
        {
            var ar = Contr.NaIDomara() as List<Domari>;
            Assert.IsNotNull(ar);
        }

        // Todo: fix
        [TestMethod]
        public void testNaIStadsetningar()
        {
            var ar = Contr.NaIStadsetningar() as List<TextValueHolder>;
            Assert.IsNotNull(ar);
        }

        // Todo: Fix
        [TestMethod]
        public void testNaIMotshaldara()
        {
            var ar = Contr.NaIMotshaldara() as List<string>;
            Assert.IsNotNull(ar);
        }

        // Todo: Fix
        [TestMethod]
        public void testNaIGreinar()
        {
            var ar = Contr.NaIGreinar() as List<List<TextValueHolder>>;
            Assert.IsNotNull(ar);
        }
    }
}
