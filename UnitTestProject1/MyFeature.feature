Feature: CustomAutomation
	
@Category1
Scenario Outline: Add two numbers
	Given Enter <Number1> and <Number2>
	When Click on Add button	
	Then Verfiy that result is <Result>

	Examples: 
	| Number1 | Number2 | Result |
	| 6       | 2       | 8      |

@Category1
Scenario Outline: Subtract two numbers
	Given Enter <Number1> and <Number2>
	When Click on Subtract button	
	Then Verfiy that result is <Result>

	Examples: 
	| Number1 | Number2 | Result |
	| 6       | 2       | 4      |


	@Category2
Scenario Outline: Multipy two numbers
	Given Enter <Number1> and <Number2>
	When Click on Multiply button	
	Then Verfiy that result is <Result>

	Examples: 
	| Number1 | Number2 | Result  |
	| 6       | 2       | 12      |
