using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace EqualExpertsTechTest.Helpers
{
    public class CustomControl : DriverHelper
    {
       //this method is to enter values in to the text fields
        public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);
        // to click buttons and dropdowns
        public static void Click(IWebElement webElement) => webElement.Click();

        public static void SelectByValue(IWebElement webElement, string value)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(value);
        }

        public static void SelectByText(IWebElement webElement, string text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);
        }

     

    }






    }

