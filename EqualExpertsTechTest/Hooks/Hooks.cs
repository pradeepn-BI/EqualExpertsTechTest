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

            //Using TestProject OpenSDK replacing the existing WebDriverManager
            //Note: Here the Token is taken from the .runsettings file
            _driverHelper.Driver = new TestProject.OpenSDK.Drivers.Web.ChromeDriver(null, "OiNfBhXqQoHJTXte9qAGjyJVSUs6PZ8etBbkpUt2Q3o1");

        }


        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}



