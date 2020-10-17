using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumGridWithDocker.PageObjects
{
    partial class LoginPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driverWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void LoginIntoApplication(string emailUser, string passwordUser)
        {
            EmailFieldTextBox.SendKeys(emailUser);
            PasswordFieldTextBox.SendKeys(passwordUser);
            Thread.Sleep(2000);
            AutentificareButtonLoginPage.Click();
        }
        public void VerifyErrorMessageAuthentification(string expectedMessage)
        {
            //string expectedMessage = "Cont inexitent! Incercati din nou sau creati un cont aici.";
            Assert.IsTrue(ErrorMessageAuthentification.Text.Contains(expectedMessage));
        }
        //public void VerifyErrorMessageAddInCart()
        //{
        //    string expectedMessage = "Pentru a efectua aceasta actiune, va rugam sa va autentificati";
        //    Assert.IsTrue(ErrorMessageAddInCart.Text.Contains(expectedMessage));
        //}
    }
}
