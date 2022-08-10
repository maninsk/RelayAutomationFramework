Feature: ValidatePayouts
	
@mytag
Scenario: Validate authorized user able to get the list of payouts
	Given the valid endpoind and user details
	When the call to get Api
	Then the statustcode should be 201
	And the payout details should be correct

Scenario Outline: Validate payouts details
	Given the valid endpoind and user details
	When the call to get Api
	Then the statustcode should be 201
	And the payout details should be correct on <id> and <bank> and <bank_account> and <currency>

	Examples:
	|id |bank_account|currency|
	|123|Test        |EUR     |

Scenario Outline: Validate unsuccessful status codes
	Given the endpoints with unauthorized access
	When the call to get Api
	Then the <statustcode> should be returned
	
	Examples:
	|status_code|
	|403|
	