Feature: CreateBooking
Verify the user can create CreateBooking
Scenario Outline: Verfify the user can create hotel booking
Given I navigate to the booking application
When I Enter "<forename>" and "<surname>" and "<price>" and "<deposit>" and "<checkin>" and "<checkout>"
Examples:
| ForeName | SurName | Price | Deposit | Checkin    | Checkout   |
| Test     | Test    | 3332  | yes     | 2021-12-04 | 2021-12-31 |
