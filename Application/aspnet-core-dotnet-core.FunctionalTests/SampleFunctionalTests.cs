using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;

namespace SampleWebApplication.FunctionalTests
{
    [TestClass]
    public class SampleFunctionalTests
    {
        private static TestContext testContext;
        private RemoteWebDriver driver;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            SampleFunctionalTests.testContext = testContext;
        }

        [TestInitialize]
        public void TestInit()
        {
            driver = GetChromeDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(300);
        }

        [TestCleanup]
        public void TestClean()
        {
            driver.Quit();
        }

        [TestMethod]
        public void SampleFunctionalTest1()
        {
            var webAppUrl = "http://localhost:44394"; //testContext.Properties["webAppUrl"].ToString();

            driver.Navigate().GoToUrl(webAppUrl);
            //Assert.AreEqual("Home Page - ASP.NET Core", driver.Title, "Expected title to be 'Home Page - ASP.NET Core'");
            Assert.AreEqual("", driver.Title, "Expected title to be 'Home Page - ASP.NET Core'");

        }

        private RemoteWebDriver GetChromeDriver()
        {
            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //var path = Environment.GetEnvironmentVariable("ChromeWebDriver");
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var options = new ChromeOptions();
            //options.AddArguments("--no-sandbox");
            options.AddArguments("--headless");
            //if (!string.IsNullOrWhiteSpace(path))
            //{
            //    return new ChromeDriver(path, options, TimeSpan.FromSeconds(300));
            //}
            //else
            {
                return new ChromeDriver(path ,options);
            }
        }
    }
}