Feature: CustomerCanViewProductDetail
	In order to know more about a product
	As a customer
	I want to be able to view the detail of the product

@mytag
Scenario: customer can view product price
	Given I navigate to Amazon home page
	And I search for wrist watch
	And I click on one of the search reuslt displayed
	Then the product price is displayed
