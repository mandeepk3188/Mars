Feature: SpecFlowFeature3
	In order to In order to update my profile
	As a skill trader
	I want to add the education that I know

@mytag
Scenario: Check if user could able to add new education
	Given I clicked on the education tab under profile page
	When I add a new education
	Then that education should be displayed on my listings

Scenario: Check if user could able to edit new education
	Given I clicked on edit education tab under profile page
	When I edit the new education
	Then that education should be updated on my listings

Scenario: Check if user could able to delete created education
	Given I clicked on delete education tab under profile page
	When I delete the added education 
	Then that education should be deleted from my listings
