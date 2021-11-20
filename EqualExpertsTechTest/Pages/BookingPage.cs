using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EqualExpertsTechTest.Pages
{
    public class BookingPage
    {

        private IWebDriver Driver;


        public BookingPage(IWebDriver driver)
        {
            Driver = driver;
        }


        IWebElement txtForeName => Driver.FindElement(By.Id("firstname"));
        IWebElement txtSurName => Driver.FindElement(By.Id("lastname"));
        IWebElement txtPrice => Driver.FindElement(By.Id("totalprice"));
        IWebElement dropdownDeposit => Driver.FindElement(By.Id("depositpaid"));
        IWebElement txtCheckIn => Driver.FindElement(By.Id("checkin"));
        IWebElement txtCheckOut => Driver.FindElement(By.Id("checkout"));
        IWebElement btnSave => Driver.FindElement(By.XPath("//input[@value='Save']"));

        public void EnterBookingDetails(string foreName, string surName, string price, string deposit, string checkIn, string checkOut)
        {
            txtForeName.SendKeys(foreName);
            txtSurName.SendKeys(surName);
            txtPrice.SendKeys(price);
            dropdownDeposit.SendKeys(deposit);
            txtCheckIn.SendKeys(checkIn);
            txtCheckOut.SendKeys(checkOut);
        }


        public void ClickSave()
        {
            btnSave.Click();
        }
    }
}

