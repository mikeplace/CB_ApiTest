using ClearBank.ApiTest.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace ClearBank.ApiTest
{
    [Binding]
    public class DeckOfCardsSteps
    {
        private RestClient restClient;
        private RestRequest restRequest;
        private String deckId;
        private String remaining;
     

        [Given(@"I create a new deck of cards")]
        public void GivenICreateANewDeckOfCards()
        {
            restClient = new RestClient("https://deckofcardsapi.com/api/");
            restRequest = new RestRequest("deck/new/", Method.GET);

            var response = restClient.Execute(restRequest);
            var jsonResponse = JsonConvert.DeserializeObject<DeckOfCardsModel>(response.Content);
            deckId = jsonResponse.deck_id;
        }

        [When(@"I draw (.*) cards")]
        public void WhenIDrawCards(string cards)
        {
            restRequest = new RestRequest("deck/" + deckId + "/draw/?count=" + cards, Method.GET);
            var response = restClient.Execute(restRequest);
            var jsonResponse = JsonConvert.DeserializeObject<DeckOfCardsModel>(response.Content);
            remaining = jsonResponse.remaining;
        }
        
       

        [Then(@"the deck should have (.*) cards in the deck")]
        public void ThenTheDeckShouldHaveCardsInTheDeck(string expectedRemaining)
        {
            Assert.AreEqual(expectedRemaining, remaining);
        }

    }
}
