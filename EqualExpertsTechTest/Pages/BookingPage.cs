using EqualExpertsTechTest.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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



        IWebElement txtForeName => Driver.FindElement(ConstantHelpers.FIRST_NAME);
        IWebElement txtSurName => Driver.FindElement(ConstantHelpers.SUR_NAME);
        IWebElement txtPrice => Driver.FindElement(ConstantHelpers.PRICE);
        IWebElement dropdownDeposit => Driver.FindElement(ConstantHelpers.DEPOSIT);
        IWebElement txtCheckIn => Driver.FindElement(ConstantHelpers.CHECK_IN);
        IWebElement txtCheckOut => Driver.FindElement(ConstantHelpers.CHECK_OUT);
        IWebElement btnSave => Driver.FindElement(ConstantHelpers.SAVE_BTN);
        IWebElement deletebutton => Driver.FindElement(ConstantHelpers.DELETE_BTN);

        public void EnterBookingDetails(string foreName, string surName, string price, string deposit, string checkIn, string checkOut)
        {
            try
            {
                txtForeName.SendKeys(foreName);
                txtSurName.SendKeys(surName);
                txtPrice.SendKeys(price);
                SelectElement se = new SelectElement(dropdownDeposit);
                se.SelectByText(deposit);
                txtCheckIn.SendKeys(checkIn);
                txtCheckOut.SendKeys(checkOut);

            }
            catch (Exception e)
            {

                throw e;
            }
                
         }
    


        public void ClickSave()
        {
            try
            {
                btnSave.Click();
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }


        public bool CheckDeleteBooking()
        {
            bool status;
            try
            {
                status = deletebutton.Displayed;

            }
            catch (Exception e)
            {

                throw e;
            }

            return status;

        }


        public void clickdeletebutton()
        {
            
                deletebutton.Click();
         }
        }

    }


