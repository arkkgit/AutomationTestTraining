Feature: E04_DataDriven

A short summary of the feature

@defect234 @sprint2 @regression
#scenario Outine/Template
Scenario Template: Data driven test demo
	Given the user has <initialItems> in the basket
	When the user adds <noOfItems> in the basket
	Then the total items in the basket are <totalNoOfItems>
	
Examples:
	| initialItems | noOfItems | totalNoOfItems |
	| 10           | 5         | 15             |
	| 20           | 30        | 50             |
	| 1            | 2         | 100            |

