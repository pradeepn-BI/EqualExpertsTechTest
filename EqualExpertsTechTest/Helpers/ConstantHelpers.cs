using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EqualExpertsTechTest.Helpers
{
    internal static class ConstantHelpers
    {
        public static By FIRST_NAME = By.Id("firstname");
        public static By SUR_NAME = By.Id("lastname");
        public static By PRICE = By.Id("totalprice");
        public static By DEPOSIT = By.Id("depositpaid");
        public static By CHECK_IN = By.Id("checkin");
        public static By CHECK_OUT = By.Id("checkout");
        public static By SAVE_BTN = By.XPath("//input[@value = ' Save ']");
    }
}
