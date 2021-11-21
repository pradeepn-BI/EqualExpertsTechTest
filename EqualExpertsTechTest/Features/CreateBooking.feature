Feature: CreateBooking
Verify the user can create CreateBooking
Scenario Outline: Verfify the user can create hotel booking
Given I navigate to the booking application
When I Enter "<forename>" and "<surname>" and "<price>" and "<deposit>" and "<checkin>" and "<checkout>"
Examples:
| forename | surname | price | deposit | checkin    | checkout   |
| Test     | Test    | 3332  | false   | 2021-12-04 | 2021-12-31 |
| Test1    | Test2   | 3342  | true    | 2021-12-04 | 2021-12-31 |
