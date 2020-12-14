using OpenQA.Selenium;
using SpecMSNUnit.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecMSNUnit.Pages
{
    public class LoginPage : Utility
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        public By UserName_ID = By.Id("ap_email");
        public By ContinueBtn_ID = By.Id("continue");
        public By Password_ID = By.Id("ap_password");
        public By SignInBtn_ID = By.Id("signInSubmit");
        public String UserName = "7893419568";
        public String Password = "Siddhu@1016";
        public void EnterUsername()
        {
            EnterText(UserName_ID, UserName);
           
          
        }
        public void ClickOnContiueBtn()
        {
            Click(ContinueBtn_ID);
            WaitForTheElement(Password_ID);
        }
        public void EnterPassword()
        {
            EnterText(Password_ID, Password);
        }
        public void ClickOnSignInbtn()
        {
            Click(SignInBtn_ID);
            TakeScreenShot();
        }
    }
}
