using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecMSNUnit.SnapDealPages
{
    class SnapDealProductsPage : Utility
    {
        public SnapDealProductsPage(IWebDriver driver) : base(driver)
        {

        }
        public By SearchBox_ID = By.Id("inputValEnter");
        public By SearchBtn_XPATH = By.XPath("//button[@class='searchformButton col-xs-4 rippleGrey']");
        public By Book_Css = By.CssSelector("[data-js-pos='0']>div>a");
        public void SearchItem()
        {
            EnterText(SearchBox_ID, "books");
        }
        public void ClickOnSearchBtn()
        {
            Click(SearchBtn_XPATH);
            WaitForTheElement(Book_Css);
        }

    }
}
