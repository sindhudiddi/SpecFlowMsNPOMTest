using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecMSNUnit.Pages
{
    class FlipkartLoginPage : Utility
    {
        public FlipkartLoginPage(IWebDriver driver) : base(driver)
        {

        }
        public By CloseBtn = By.XPath("//button[text()='✕']");
        public By Username_XPATH = By.XPath("//input[@type='text']");
        public By ContinueBtn_XPATH = By.XPath("//button[@type='submit']");
        public By Password_XPATH = By.XPath("//input[@type='password']");
        public By LoginBtn_XPATH = By.XPath("//button[@class='_2KpZ6l _20xBvF _3AWRsL']");
        public void ClickOnCloseBtn()
        {
            Click(CloseBtn);
        }
        public void EnterUsername()
        {
            EnterText(Username_XPATH, "7893419568");
        }
        public void ClickOnContinueBtn()
        {
            Click(ContinueBtn_XPATH);
            WaitForTheElement(Password_XPATH);
        }
        public void EnterPassword()
        {
            EnterText(Password_XPATH, "7893419568");
        }
        public void ClickOnLoginBtn()
        {
            Click(LoginBtn_XPATH);
        }

    }
}
