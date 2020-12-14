using OpenQA.Selenium;
using SpecMSNUnit.Utilities;

namespace SpecMSNUnit.SnapDealPages
{
    class SnapDealLoginPage : Utility
    {
    public SnapDealLoginPage(IWebDriver driver) : base(driver)
        {

        }
        public By UserName_ID = By.Id("username");
        public By ContinueBtn = By.Id("login-continue");
        public By Password_ID = By.Id("w_password");
        public By Submit_ID = By.Id("login-done");
        public void EnterUserName()
        {
            EnterText(UserName_ID,"7893419568");
        }
        public void ClickOnContinueBtn()
        {
            Click(ContinueBtn);
            WaitForTheElement(Password_ID);
        }
        public void EnterPassword()
        {
            EnterText(Password_ID,"1234567890");
        }
        public void ClickOnSubmitBtn()
        {
            Click(Submit_ID);
        }
    }
}
