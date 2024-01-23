@background @payment
Feature: E03_Background

In order to place an order
as a existing user
I want to pay through all payment modes

Background: Background for diffrent payment scenarios
	Given the user is logged into the Ecom app
	And the user adds items to the cart
	And the user checksout the basket

# CCard, Dcard, Paypal
@ccard @sprint2 @simran
Scenario: Pay with Ccard
	When the user pays the amount by Credit card
	Then the order is successful
	
@sanity @wip @sprint2
Scenario: Pay with Dcard
	When the user pays the amount by Debit card
	Then the order is successful

@regression  @ignore
Scenario: Pay with Paypal
	When the user pays the amount by Paypal
	Then the order is successful