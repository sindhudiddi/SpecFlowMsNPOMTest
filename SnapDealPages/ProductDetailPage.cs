using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecMSNUnit.SnapDealPages
{
    class ProductDetailPage : Utility
    {
        public ProductDetailPage(IWebDriver driver) : base(driver)
        {
            
        }
        public By AddToCartBtn_XPATH = By.XPath("//span[text()='add to cart']");
        public By ViewCartBtn_Class = By.XPath("//div[text()='View Cart']");
        public void ClickOnAddToCartBtn()
        {
            Click(AddToCartBtn_XPATH);
            WaitForTheElement(ViewCartBtn_Class);
        }
    }

}
