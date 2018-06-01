# CB Automated API Test

This is a simple automation technical test for prospective QA candidates. It is not intended to take more than a few hours to complete.

Your submission will be reviewed not only in terms of your final result, but also in terms of your approach.

# Overview

There are several simple API endpoints described on the website below, which simulate how to interact with 1 or more decks of playing cards.

The task: Create an automated test, based on the scenario described below.

Website: http://deckofcardsapi.com/ 

# Acceptance Criteria
1. Create a new branch for your test using the Github website. Ensure you pull that branch to your local machine before you start working on the test.
2. Write a simple automated test framework in the language / IDE of your choice to test the scenario below
3. Clear reporting of the test results
4. This README.md expanded to include your design decisions, how to install and then how to run your tests
5. Include information about your choice of tools that have been used
6. Once completed create a Pull Requrest and assign the users Greeff and mikeplace

# Scenario:

Scenario: Remaining cards correctly updated after drawing
- *Assuming the new deck starts with 52 cards:*
- Draw cards from the deck 5 times
- Draw between 1 and 5 cards from the deck each time.
- Verify that 52-[total cards drawn] remain in the deck at the end of the test
