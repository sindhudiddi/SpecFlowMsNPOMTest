using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using SpecMSNUnit.Pages;

namespace SpecMSNUnit.TestSuite
{
    [TestClass]
   public class MSTest
    {
        IWebDriver driver = null;
        [TestInitialize]
        public void SetUp()
        {
             driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [TestMethod]
        public void NavigateToUrl()
        {
            FlipkartHomePage flipkartHomePage = new FlipkartHomePage(driver);
            flipkartHomePage.NavigateToFlipkartSite();
            FlipkartLoginPage flipkartLoginPage = new FlipkartLoginPage(driver);
            flipkartLoginPage.ClickOnCloseBtn();
            flipkartHomePage.ProductSearch();
            flipkartHomePage.ClcikOnsearchBn();
            FlipkartResultsPage flipkartResultsPage = new FlipkartResultsPage(driver);
            flipkartResultsPage.ClickOnBook();
            FlipkartProductPage flipkartProductPage = new FlipkartProductPage(driver);
            flipkartProductPage.ClickOnAddToCartBtn();
            FlipKartCheckOutPage flipKartCheckOutPage = new FlipKartCheckOutPage(driver);
            flipKartCheckOutPage.ClickOnPlaceOrderBtn();
            flipkartLoginPage.EnterUsername();
            flipkartLoginPage.ClickOnContinueBtn();
            flipkartLoginPage.EnterPassword();
            flipkartLoginPage.ClickOnLoginBtn();

        }
       
        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
        
    }
}
