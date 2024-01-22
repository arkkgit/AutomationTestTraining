Feature: E01_First Log In feature

In order to Login
As a existing user
I want to check the login functionality


@tag1
Scenario: Successful Login
	Given the user is on homepage
	When the user login in with valid credentials
	Then the login is sucessful

@tag1
Scenario: UnSuccessful Login
	Given the user is on homepage
	When the user login in with invalid credentials
	Then the login is unsucessful

