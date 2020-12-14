using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecMSNUnit.Pages
{
   public class SearchResultPage : Utility
    {
      
            public SearchResultPage(IWebDriver driver) : base(driver)
            {

            }
            public By Book_XPATH = By.XPath("(//span[text()='A Promised Land'][2])");
            public By WishLitsBtn_ID = By.Id("wishListMainButton-announce");
            public By AddToCart_ID = By.Id("buybox-see-all-buying-choices-announce");
            public By AddToCartBtn_XPATH = By.XPath("((//input[@name='submit.addToCart'])[1])");
            public void ClickOnBook()
            {
                Click(Book_XPATH);
                WaitForTheElement(WishLitsBtn_ID);
            }
            public void ClickingOnAddToCartBtn()
            {
            Click(AddToCart_ID);
            WaitForTheElement(AddToCartBtn_XPATH);
            } 
            public void ClickingOnAddToCartBtn2()
            {
             Click(AddToCartBtn_XPATH);
            }

        }
    }
