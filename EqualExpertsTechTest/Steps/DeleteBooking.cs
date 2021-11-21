﻿using EqualExpertsTechTest.Helpers;
using EqualExpertsTechTest.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace EqualExpertsTechTest.Steps
{
    [Binding]
    public class DeleteBooking
    {
        private DriverHelper _driverHelper;


        BookingPage bookingPage;



        public DeleteBooking(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            bookingPage = new BookingPage(_driverHelper.Driver);
        }



        [When(@"there is a booking exists")]
        public void WhenThereIsABookingExists()
        {
            try
            {
                if (bookingPage.CheckDeleteBooking() == true)
                {
                    bookingPage.clickdeletebutton();
                }
                else
                {
                    bookingPage.EnterBookingDetails("Kevin", "John", "1234", "true", "2021-12-01", "2021-12-04");
                    bookingPage.ClickSave();
                    bookingPage.clickdeletebutton();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            
            
        }

 

        [When(@"I click on the delete button")]
        public void WhenIClickOnTheDeleteButton()
        {
            bookingPage.clickdeletebutton();
        }

        [Then(@"the booking should be delted")]
        public void ThenTheBookingShouldBeDelted()
        {
            
        }

    }
}