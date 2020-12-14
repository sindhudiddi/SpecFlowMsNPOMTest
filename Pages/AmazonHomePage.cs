using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;


namespace SpecMSNUnit.Pages
{
    class AmazonHomePage : Utility
    {
        public AmazonHomePage(IWebDriver driver) : base(driver)
        {

        }
        public String URL = "https://www.amazon.com";
        public By SigInBtn_XPATH = By.XPath("//span[text()='Hello, Sign in']");
        public By CheckOutConfirmBtn = By.Id("hlb-ptc-btn-native");


        public void NavigateToUrl()
        {
            NavigateToURL(URL);
            WaitForTheElement(SigInBtn_XPATH);
        }
        public void ClickOnSignInBtn()
        {
            Click(SigInBtn_XPATH);
        }
        public void ClickOnProceedToCheckOutBtn()
        {
            Click(CheckOutConfirmBtn);
        }
       
    }
}
