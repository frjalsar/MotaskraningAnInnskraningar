using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMotaskraning
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\Forrit\\chromedriver_win32");
        }

        [Test]
        public void test()
        {
            driver.Url = "https://localhost:5001";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}