Feature: CreateBooking
Verify the user can create CreateBooking
Scenario Outline: Verfify the user can create hotel booking
Given I navigate to the booking application
When I Enter "<forename>" and "<surname>" and "<price>" and "<deposit>" and "<checkin>" and "<checkout>"
Examples:
| forename | surname | price | deposit | checkin    | checkout   |
| Daniel   | Trim    | 200	 | false   | 2021-12-04 | 2021-12-08 |
| Keith    | John    | 500   | true    | 2021-12-15 | 2021-12-18 |
