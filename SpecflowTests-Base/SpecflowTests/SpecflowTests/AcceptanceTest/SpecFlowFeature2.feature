Feature: SpecFlowFeature2
	In order to update my profile
	As a skill trader
	I want to add the skills that I know

@mytag
Scenario: Check if user could able to add a skill
	Given I clicked on the skill tab under profile page
	When I add a new skill
	Then that skill should be displayed on my listings

Scenario: Check if user could able to edit skill
	Given I clicked on edit skill tab under profile page
	When I edit the new skill
	Then that skill should be updated on my listings

Scenario: Check if user could able to delete skill
	Given I clicked on delete skill tab under profile page
	When I delete the added skill
	Then that skill should be deleted from my listings
