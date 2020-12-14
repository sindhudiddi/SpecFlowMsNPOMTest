using OpenQA.Selenium;
using SpecMSNUnit.Utilities;


namespace SpecMSNUnit.Pages
{
    class FlipkartResultsPage : Utility
    {

        public FlipkartResultsPage(IWebDriver driver) : base(driver)
        {

        }

        public By Book_XPATH = By.XPath("//a[text()='PORTRAITS OF POWER: Half a Century of Being at Ringside']");
        public By PinCode_XPATH = By.XPath("//*[@id='pincodeInputId']");

        public void ClickOnBook()
        {
            SlideToNextWindow(Book_XPATH);
            WaitForTheElement(PinCode_XPATH);
        }
    }
}
