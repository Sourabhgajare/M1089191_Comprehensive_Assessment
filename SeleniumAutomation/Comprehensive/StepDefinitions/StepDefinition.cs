using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Comprehensive.Methods;
using System.Threading;

namespace Comprehensive.StepDefinitions
{
    [Binding]
   public class StepDefinition
    {
        Method obj = new Method();
        [Given(@"Open the browser and enter the URL")]
        public void GivenOpenTheBrowserAndEnterTheURL()
        {
            obj.OpenUrl();
            obj.WebpageScreenshot("Home Page");
            
        }

        [When(@"we click on the Register option")]
        public void WhenWeClickOnTheRegisterOption()
        {
            obj.ClickRegisterOption();
            obj.WebpageScreenshot("Registration Page");
        }

        [When(@"click on the sign up now option")]
        public void WhenClickOnTheSignUpNowOption()
        {
            obj.ClickSignUp();

            obj.WebpageScreenshot( "SignUp Page");
        }
       

        [When(@"Put product name as  in Search box")]
        public void WhenPutProductNameAsInSearchBox()
        {
            obj.EnterProductName();
            obj.WebpageScreenshot("Search Box");
        }

        [Then(@"click on search button")]
        public void ThenClickOnSearchButton()
        {
            obj.ClickSearch();
            Thread.Sleep(5000);
            obj.WebpageScreenshot("Search Button Option");
        }
        [Then(@"we click on the Location option")]
        public void ThenWeClickOnTheLocationOption()
        {
            obj.ClickLocation();
            obj.WebpageScreenshot("Location Option");
        }

        [Then(@"select the Us-English Location from the option")]
        public void ThenSelectTheUs_EnglishLocationFromTheOption()
        {
            obj.SelectLocation();
            obj.WebpageScreenshot("Location Dropdown");
        }
        [When(@"we click on the cupons and rewards")]
        public void WhenWeClickOnTheCuponsAndRewards()
        {
            obj.CuponReward();
            obj.WebpageScreenshot("Cupon and Rewards");
        }

        [When(@"click on Save now option")]
        public void WhenClickOnSaveNowOption()
        {
            obj.SaveCupon();
            obj.WebpageScreenshot("Save new Option");
        }
        [Then(@"Click on Whats a new option")]
        public void ThenClickOnWhatsANewOption()
        {
            obj.WhatsNew();
            obj.WebpageScreenshot("Whats New");
        }

        [Then(@"Click on Learn More option")]
        public void ThenClickOnLearnMoreOption()
        {
            obj.ClickOnLearnMore();
            obj.WebpageScreenshot("Learn More");
        }

        [Then(@"Click on Click here for Ingrediants and more")]
        public void ThenClickOnClickHereForIngrediantsAndMore()
        {
            obj.Ingrediants();
            obj.WebpageScreenshot("Ingrediant and more");
        }
        [Then(@"Click on Live Chat")]
        public void ThenClickOnLiveChat()
        {
            obj.LiveChat();
            obj.WebpageScreenshot("Live Chat");
        }

        [Then(@"Click on Chat Now")]
       
        [Then(@"Click on Contact Us option")]
        public void ThenClickOnContactUsOption()
        {
            obj.ContactUs();
            obj.WebpageScreenshot("Contact Us");

        }

     }






        



    }

