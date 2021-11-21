Feature: DeleteBooking
	Verfiy the user can delete a booking

Scenario: verify user can delete and existing booking
	Given I navigate to the booking application
	When there is a booking exists
	And I click on the delete button 
	Then the booking should be delted