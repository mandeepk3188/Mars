Feature: SpecFlowFeature4
	In order to update my profile 
	As a skill trader
	I want to add the certificate that I achieve

@mytag
Scenario: Check if user could able to add a certificate 
	Given I clicked on the certificate tab under Profile page
	When I add a new certificate
	Then that certificate should be displayed on my listings

Scenario: Check if user could able to edit the certificate
	Given I clicked on edit certificate tab under profile page
	When I edit the new certificate
	Then that certificate should be updated on my listings

Scenario: Check if user could able to delete created certificate
	Given I clicked on delete certificate tab under profile page
	When I delete the added certificate 
	Then that certificate should be deleted from my listings