Feature: SpecFlowFeature1
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given I clicked on the Language tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings

Scenario: Check if user could able to edit the language
	Given I clicked on edit language tab under profile page
	When I edit the new language
	Then that language should be updated on my listings

Scenario: Check if user could able to delete created language
	Given I clicked on delete language tab under profile page
	When I delete the added language 
	Then that language should be deleted from my listings
	