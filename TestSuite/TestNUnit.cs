using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecMSNUnit.SnapDealPages;

namespace SpecMSNUnit.TestSuite
{
    [TestFixture]
    class TestNUnit
    {
        IWebDriver driver = null;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void NavigateToUrl()
        {
            SnapDealHomePage snapDealhomePages = new SnapDealHomePage(driver);
            snapDealhomePages.NavigateToSnapdeal();
            SnapDealProductsPage snapDealProductsPage = new SnapDealProductsPage(driver);
            snapDealProductsPage.SearchItem();
            snapDealProductsPage.ClickOnSearchBtn();
            ResultsPage resultsPage = new ResultsPage(driver);
            resultsPage.ClickOnProduct();
            ProductDetailPage productDetailPage = new ProductDetailPage(driver);
            productDetailPage.ClickOnAddToCartBtn();
            SnapDealCheckOutPage snapDealCheckOutPage = new SnapDealCheckOutPage(driver);
            snapDealCheckOutPage.ClickOnProceedToCheckOutBtn();
            SnapDealLoginPage snapDealLoginPage = new SnapDealLoginPage(driver);
            snapDealLoginPage.EnterUserName();
            snapDealLoginPage.ClickOnContinueBtn();
            snapDealLoginPage.EnterPassword();
            snapDealLoginPage.ClickOnSubmitBtn();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
