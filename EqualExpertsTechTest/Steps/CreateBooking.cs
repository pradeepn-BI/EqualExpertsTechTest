using TechTalk.SpecFlow;
using EqualExpertsTechTest.Helpers;
using EqualExpertsTechTest.Pages;
using EqualExpertsTechTest.Steps;


namespace EqualExpertsTest.Tests.Steps
{

    [Binding]
    public class CreateBooking
    {
        private DriverHelper _driverHelper;

        
        BookingPage bookingPage;
        


        public CreateBooking(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            bookingPage = new BookingPage(_driverHelper.Driver);
        }

        


        [Given(@"I navigate to the booking application")]
        public void GivenINavigateToTheBookingApplication()
        {
            _driverHelper.Driver.Navigate().GoToUrl(ConstantHelpers.URL);
           
        }
        [When(@"I Enter ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void WhenIEnterAndAndAndAndAnd(string foreName, string surName, string price, string deposit, string checkIn, string checkOut)
        {
            bookingPage.EnterBookingDetails(foreName, surName, price, deposit, checkIn, checkOut);
            bookingPage.ClickSave();
        }


    }
}
