using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecMSNUnit.SnapDealPages
{
    class SnapDealCheckOutPage : Utility
    {
        public SnapDealCheckOutPage(IWebDriver driver) : base(driver)
        {

        }
        public By ProceedBtn_XPATH = By.XPath("//a[text()='Proceed To Checkout']");
        public By UserName_ID = By.Id("username");
        public void ClickOnProceedToCheckOutBtn()
        {
            Click(ProceedBtn_XPATH);
            WaitForTheElement(UserName_ID);
        }
    }
}
