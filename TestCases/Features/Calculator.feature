Feature: Calculator
	As a user,
	I want to input values and utilize operators,
	So that I can perform calculations accurately.


# Background Steps are executed as the initial steps 
# for every Scenario in a Feature file
Background:
	Given the user navigates to the calculator page


# 'And' represents the last Gherkin keyword used ('Given', 'When', 'Then')
# A Scenario will utilize the steps in the order above
# and not in any other order (Given, When, Then, When, Then)
Scenario: Add two numbers
	When the user clicks the calculator buttons to input "29"
	And the user clicks the "add" button
	And the user clicks the calculator buttons to input "17"
	And the user clicks the "calculate" button
	Then the display shows "46"


# Re-use is the goal in Gherkin steps
# This is an example of a Scenario Outline with an Example table
# to create multiple permutations of a single Scenario
# Feel free to follow this pattern in your tests
Scenario Outline: Subtract two numbers
	When the user clicks the calculator buttons to input "<first>"
	And the user clicks the "subtract" button
	And the user clicks the calculator buttons to input "<second>"
	And the user clicks the "calculate" button
	Then the display shows "<result>"

	Examples:
		| first | second | result |
		| 15    | 6      | 9      |
		| 24    | 0      | 24     |
		| 10    | 45     | -35    |
