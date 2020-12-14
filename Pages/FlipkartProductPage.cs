using OpenQA.Selenium;
using SpecMSNUnit.Utilities;


namespace SpecMSNUnit.Pages
{
    class FlipkartProductPage : Utility
    {
        public FlipkartProductPage(IWebDriver driver) : base(driver)
        {

        }
        public By AddToCartBtn_XPATH = By.XPath("//button[text()='ADD TO CART']");

        public void ClickOnAddToCartBtn()
        {
            Click(AddToCartBtn_XPATH);

        }

    }
}
