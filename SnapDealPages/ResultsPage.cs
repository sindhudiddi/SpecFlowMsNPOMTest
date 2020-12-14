using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecMSNUnit.SnapDealPages
{
    class ResultsPage : Utility
    {
        public ResultsPage(IWebDriver driver) : base(driver)
        {

        }
        public By Book_Css = By.CssSelector("[data-js-pos='0']>div>a");
        public By AddToCartBtn_XPATH = By.XPath("//span[text()='add to cart']");


        public void ClickOnProduct()
        {
            SlideToNextWindow(Book_Css);
            WaitForTheElement(AddToCartBtn_XPATH);
        }
    }
}
