Feature: DeckOfCards

Scenario Outline: Remaining cards correctly updated after drawing
	Given I create a new deck of cards
	When I draw 5 cards
	And I draw <amount> cards
	Then the deck should have <remaining> cards in the deck

Examples: 
	| amount | remaining | 
	| 1      |    46     | 
	| 2      |    45     | 
	| 3      |    44     | 
	| 4      |    43     | 
	| 5      |    42     |