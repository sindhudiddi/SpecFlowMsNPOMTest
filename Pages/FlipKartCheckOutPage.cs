using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecMSNUnit.Pages
{
    class FlipKartCheckOutPage : Utility
    {
        public FlipKartCheckOutPage(IWebDriver driver): base(driver)
        {

        }
        public By PlaceOrderBtn_Xpath = By.XPath("//span[text()='Place Order']");
        public void ClickOnPlaceOrderBtn()
        {
            Click(PlaceOrderBtn_Xpath);
        }

    }
}
