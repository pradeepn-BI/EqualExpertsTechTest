For this project to run locally we need to register at https://app.testproject.io/signup

Download and install Agent form this link https://app.testproject.io/#/download
Run the test agent 
We need to get the Developtment token from https://app.testproject.io/#/integrations/sdk 
Update the token in hooks line 26
ie this line _driverHelper.Driver = new TestProject.OpenSDK.Drivers.Web.ChromeDriver(null, "");
