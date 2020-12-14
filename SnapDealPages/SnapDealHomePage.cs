using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;


namespace SpecMSNUnit.SnapDealPages
{
   public  class SnapDealHomePage : Utility
    {
       public SnapDealHomePage(IWebDriver driver) : base(driver)
        {

        }
        public String URL = "https://www.snapdeal.com";
        public void NavigateToSnapdeal()
        {
            NavigateToURL(URL);
        }

    }
}
