using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecMSNUnit.Pages;
using System;
using System.Reflection;
using TechTalk.SpecFlow;

namespace SpecMSNUnit.StepDefinitions
{
    [Binding]
    class StepDefinition
    {
        IWebDriver driver = null;
       [Given(@"Opening the Chrome browser")]
        public void GivenOpeningTheChromeBrowser()
        {
             driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"I enter the Url")]
        public void WhenIEnterTheUrl()
        {
            AmazonHomePage amazonHomePage = new AmazonHomePage(driver);
            amazonHomePage.NavigateToUrl();
           
            // amazonHomePage.ClickOnSignInBtn();
        }
        [When(@"I Login to the amazon site")]
        public void WhenILoginToTheAmazonSite()
        {

            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername();
            loginPage.ClickOnContiueBtn();
            loginPage.EnterPassword();
            loginPage.ClickOnSignInbtn();

        }

        [When(@"I Searhc books in the searchbox")]
        public void WhenISearhcBooksInTheSearchbox()
        {
            ProductsPage productsPage = new ProductsPage(driver);
            productsPage.ItemSearching();
            productsPage.ClickOnSearchBtn();
            SearchResultPage searchResultPage = new SearchResultPage(driver);
            searchResultPage.ClickOnBook();
            searchResultPage.ClickingOnAddToCartBtn();
            searchResultPage.ClickingOnAddToCartBtn2();
            AmazonHomePage amazonHomePage = new AmazonHomePage(driver);
            amazonHomePage.ClickOnProceedToCheckOutBtn();
        }
       
      

        [Then(@"I Quite the broswer")]
        public void ThenIQuiteTheBroswer()
        {
            driver.Quit();
        }


    }
}
