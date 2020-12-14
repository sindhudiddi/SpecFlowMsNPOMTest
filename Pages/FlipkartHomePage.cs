using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecMSNUnit.Pages
{
    class FlipkartHomePage : Utility
    {
        

        public FlipkartHomePage(IWebDriver webdriver) : base(webdriver)
        {
        }
        public String URL = "https://www.flipkart.com";
        public By TextBox_Name = By.Name("q");
        public By SearchBtn_ClassName = By.ClassName("L0Z3Pu");
        public By Book_XPATH = By.XPath("//a[text()='PORTRAITS OF POWER: Half a Century of Being at Ringside']");
        public void NavigateToFlipkartSite()
        {
            NavigateToURL(URL);
        }
      
        public void ProductSearch()
        {
            EnterText(TextBox_Name, "books");
        }
        public void ClcikOnsearchBn()
        {
            Click(SearchBtn_ClassName);
            WaitForTheElement(Book_XPATH);

        }
       
    }
}
