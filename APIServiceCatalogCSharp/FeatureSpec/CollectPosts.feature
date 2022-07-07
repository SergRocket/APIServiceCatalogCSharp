Feature: CollectPosts
	Simple calculator for adding two numbers

Scenario: Verify resourceList values
	Given Perform POST operation for given endpoint 
	When The resourceList is existed and we add params to url
	Then The values in resourceList is valid