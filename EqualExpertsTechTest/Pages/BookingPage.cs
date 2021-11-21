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



        IWebElement TxtForeName => Driver.FindElement(ConstantHelpers.FIRST_NAME);
        IWebElement TxtSurName => Driver.FindElement(ConstantHelpers.SUR_NAME);
        IWebElement TxtPrice => Driver.FindElement(ConstantHelpers.PRICE);
        IWebElement DropdownDeposit => Driver.FindElement(ConstantHelpers.DEPOSIT);
        IWebElement TxtCheckIn => Driver.FindElement(ConstantHelpers.CHECK_IN);
        IWebElement TxtCheckOut => Driver.FindElement(ConstantHelpers.CHECK_OUT);
        IWebElement BtnSave => Driver.FindElement(ConstantHelpers.SAVE_BTN);
        IWebElement Deletebutton => Driver.FindElement(ConstantHelpers.DELETE_BTN);

        public void EnterBookingDetails(string foreName, string surName, string price, string deposit, string checkIn, string checkOut)
        {
                CustomControl.EnterText(TxtForeName, foreName);
                CustomControl.EnterText(TxtSurName, surName);
                CustomControl.EnterText(TxtPrice, price);
                CustomControl.SelectByValue(DropdownDeposit, deposit);
                CustomControl.EnterText(TxtCheckIn, checkIn);
                CustomControl.EnterText(TxtCheckOut, checkOut);
    
         }
    


        public void ClickSave()
        {
            CustomControl.Click(BtnSave);
               
           
            
        }


        public bool CheckDeleteBooking()
        {
            bool status;
            status = Deletebutton.Displayed;
            Console.WriteLine(status);
            return status;

        }


        public void clickdeletebutton()
        {

            CustomControl.Click(Deletebutton);
         }
        }

    }


