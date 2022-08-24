Feature: BingSearch

Basic bing search tests that should validate that site is up and running and user has possibility to search something

@SMOKE
Scenario: Search normal word in bing.com
	Given User is on bing.com webpage
	When User searches for "piwo jasne"
	Then First three results contains "piwo jasne"

@TC_5645
Scenario: Search not normal word in bing.com
	Given User is on bing.com webpage
	When User searches for "piwo ciemne"
	Then First three results contains "piwo ciemne"