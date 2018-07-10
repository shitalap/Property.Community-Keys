Feature: PO List A Rental
	In order to List A Rental
	As a Property Owner
	

@mytag
Scenario: SpecFlow_POListARental
	Given I have Navigated to List A Rental
	And I have entered valid mandatory fields and press Save
	Then the property is listed 

	@mytag
Scenario: SpecFlow_POInspection
	Given I have Navigated to Add Inspection Request Page 
	And I have entered valid mandatory fields and clicked on Save
	Then the property is displayed for Inspection
