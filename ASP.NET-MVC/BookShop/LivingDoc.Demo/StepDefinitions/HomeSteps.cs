﻿using LivingDoc.Demo.Drivers;
using TechTalk.SpecFlow;

namespace LivingDoc.Demo.StepDefinitions
{
    [Binding]
    public class HomeSteps
    {
        private readonly IHomeDriver _homeDriver;

        public HomeSteps(IHomeDriver driver)
        {
            _homeDriver = driver;
        }

        [When(@"I enter the shop")]
        public void WhenIEnterTheShop()
        {
            _homeDriver.Navigate();
        }

        [Then(@"the home screen should show the book '(.*)'")]
        public void ThenTheHomeScreenShouldShowTheBook(string expectedTitle)
        {
            // Make it fail for demo purpose
            throw new System.NotImplementedException();

            //_homeDriver.ShowsBook(expectedTitle);
        }

        [Then(@"the home screen should not be empty")]
        public void ThenTheHomeScreenShouldNotBeEmpty()
        {
            //not used step
        }

        [Then(@"the home screen should show the books (.*)")]
        public void ThenTheHomeScreenShouldShowTheBooks(string expectedTitleList)
        {
            _homeDriver.ShowsBooks(expectedTitleList);
        }

        [Then(@"the home screen should show the following books")]
        public void ThenTheHomeScreenShouldShowTheFollowingBooks(Table expectedBooks)
        {
            _homeDriver.ShowsBooks(expectedBooks);
        }

        [Given("")]
        public void GivenHomeScreenContainsABookWithTitle(string expectedTitle)
        {
            //not used step
        }

        [Given("")]
        public void GivenHomeScreenIsEmpty()
        {
            //not used step
        }

    }
}