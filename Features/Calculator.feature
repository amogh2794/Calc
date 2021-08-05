Feature: Calculator UI Automation

Background: Launching and resetting calculator
	Given Calculator is launched
	#And calculator is reset

	
Scenario: Verify HEX DEC OCT and BIN values
	Given I click on menu
	And I select Programmer mode
	And I click first no 
	Then I verify the values displayed
	#Then Close Application


Scenario: Test 2 Add two numbers in Scientific mode

	Given I click on menu 
	And I Select Scientific
	And I click first no
	And I click plus button
	And I click second no
	And I click equal button
	Then Close Application

Scenario: Navigate to Date mode and verify Day and week results
	Given I click on menu
	And I select Date mode
	And I select from date
	Then Date Difference is displayed
	Then Close Application

Scenario: Navigate to Standard mode perform addition clear and retrieve from history
	Given I click on menu
	And I select Standard mode
	And I click first no
	And I click plus button
	And I click second no
	And I click equal button
	Then Validate displayed result
	And I click on Cancel
	Then I click on History
	#Then I select First Item
	#Then Validate displayed result
	Then I Click on Memory
	And I click on Cancel
	#Then I Click on Memory Retrieve
	#Then Close Application