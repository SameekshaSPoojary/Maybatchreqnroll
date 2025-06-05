Feature: SeleniumFeature

A short summary of the feature

Feature: SeleniumRegistration
 
A short summary of the feature
 
Background: 
	Given User is on the registration page
Scenario: Verify student registration with valid details
	And User enters firstname "John"
	And User enters email "john.doe@example.com"
	 And User selects gender "Male"
	 And User enters mobile number "9876543210"
	 And User selects date of birth "15-03-2000"
	And User enters subjects "Mathematics, Physics"
	 And User selects hobbies "Reading, Music"
    And User selects picture "C:\Users\hitka\Downloads\sampleFile.jpeg"
	 And User enters current address "123 Main Street, Mangalore"
	 And User selects state "NCR"
	And User selects city "Lucknow"
	 And User clicks on submit button in the registration form
	 Then Registration is successful