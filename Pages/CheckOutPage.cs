using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
namespace SpecMSNUnit.Pages
{
    public class CheckOutPage : Utility

    {
        public CheckOutPage(IWebDriver driver) : base(driver)
        {

        }
        public By CheckOutBtn_ID = By.Id("checkout-button");
        public void ClickOnCheckOutBtn()
        {
            Click(CheckOutBtn_ID);
        }
        
    }
}

