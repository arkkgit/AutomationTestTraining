Feature: E05_ShareStateDemo

A short summary of the feature

Scenario Template: Share state test demo 
	Given the user has <initialItems> in the cart
	When the user adds <noOfItems> in the cart
	Then the total items in the cart are <totalNoOfItems>
	
	
Examples:
	| initialItems | noOfItems | totalNoOfItems |
	| 10           | 5         | 15             |
	| 20           | 30        | 50             |
	| 1            | 2         | 100            |

