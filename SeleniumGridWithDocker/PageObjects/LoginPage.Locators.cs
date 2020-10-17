using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SeleniumGridWithDocker.PageObjects
{
    partial class LoginPage
    {
        private IWebElement EmailFieldTextBox => _driver.FindElement(By.CssSelector("input[type=email]"));
        private IWebElement PasswordFieldTextBox => _driver.FindElement(By.CssSelector("input[type=password]"));
        //private IWebElement AutentificareButtonLoginPage => _driver.FindElement(By.CssSelector("button[type=submit]"));
        private IWebElement AutentificareButtonLoginPage => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button[type=submit]")));
        private IWebElement ErrorMessageAuthentification => _driver.FindElement(By.CssSelector(".alert-danger"));
        private IWebElement ErrorMessageAddInCart => _driver.FindElement(By.CssSelector(".alert-danger"));

    }
}
