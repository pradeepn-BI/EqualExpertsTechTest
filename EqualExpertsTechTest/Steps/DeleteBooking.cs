using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EqualExpertsTechTest.Steps
{
   public class DeleteBooking
    {

        private IWebDriver Driver;


        public DeleteBooking(IWebDriver driver)
        {
            Driver = driver;
        }


        IWebElement deletebutton => Driver.FindElement(By.XPath("//input[@value = 'Delete']"));


        public bool checkDeleteBooking() {
          bool status = false;
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
            bool status = checkDeleteBooking();
            if (status == true)
            {
                deletebutton.Click();
            }
        }
    
    
    }


}
