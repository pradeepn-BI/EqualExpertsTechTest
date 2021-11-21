using EqualExpertsTechTest.Helpers;
using OpenQA.Selenium.Chrome;
using TestProject.OpenSDK.Drivers.Web;
using System;
using TechTalk.SpecFlow;

namespace EqualExpertsTechTest.Hooks
{

    [Binding]
    public sealed class Hooks
    {
        private DriverHelper _driverHelper;
        public Hooks(DriverHelper driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public void BeforeScenario()
        {

            OpenQA.Selenium.Chrome.ChromeOptions options = new OpenQA.Selenium.Chrome.ChromeOptions();
            options.AddArgument("--headless");

            Console.WriteLine("Setup");

           
            _driverHelper.Driver = new TestProject.OpenSDK.Drivers.Web.ChromeDriver(null, "detsgm2wTgEljhsKepmOwMM8n6KHktSIli2LzFg_eQA1");

        }


        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}



