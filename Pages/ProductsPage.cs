using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;

namespace SpecMSNUnit.Pages
{
    class ProductsPage : Utility
    {
        public ProductsPage(IWebDriver driver) : base(driver)
        {

        }
        public By SearchBox_ID = By.Id("twotabsearchtextbox");
        public By SearchBtn_XPATH = By.XPath("//input[@type='submit' and @value]");
        public By Book_XPATH = By.XPath("(//span[text()='A Promised Land'][2])");
        public String Searchbook = "books";
        public String AssertValue = "Amazon.com: Books";
        public void ItemSearching()
        {
            EnterText(SearchBox_ID, Searchbook);

        }
        public void ClickOnSearchBtn()
        {
            Click(SearchBtn_XPATH);
            WaitForTheElement(Book_XPATH);
            Asserting(AssertValue);
        }

    }
}
