# CB Automated API Test

This is a simple automation technical test for prospective QA canidates. It should not take more than 2 hours to complete.

# Overview

There are several simple API endpoints described on the website below, which simulate how to interact with 1 or more decks of playing cards.

The task: Create 3 automated tests, based on the scenarios described below.

Website: http://deckofcardsapi.com/ 

# Acceptance Criteria
1. Create a new branch for your test using the Github website. Ensure you pull that branch to your local machine before you start working on the test.
2. Write a simple automated test framework which tests the 3 scenarios described below
3. Clear reporting of the test results
4. This README.md expanded to include your design decisions, how to install and then how to run your tests
5. Include information about your choice of tools that have been used
6. Once completed create a Pull Requrest and assign the users Greeff and mikeplace

# Scenarios:

Scenario 1: Shuffling a new deck works
- Open a new deck, and shuffle it
- Verify that the exact same cards are in the deck
- And that the cards are in a different order

Scenario 2: Remaining cards value correctly updated after drawing
- Draw cards from the deck 5 times
- Draw between 1 and 5 cards from the deck each time.
- Shuffle the cards between each draw.
- Assert that the number of cards remaining in the deck is 52 minus the total number of cards drawn.

Scenario 3: Correct number of duplicates found
- Shuffle 10 new decks of cards
- Draw 26 cards 10 times
- Verify that 10 duplicates of each card were found
