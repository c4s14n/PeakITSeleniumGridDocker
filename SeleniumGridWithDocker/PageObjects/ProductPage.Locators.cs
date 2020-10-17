using OpenQA.Selenium;

namespace SeleniumGridWithDocker.PageObjects
{
    partial class ProductPage
    {
        private IWebElement AdaugaInCosButton => _driver.FindElement(By.CssSelector(".btn-primary"));
    }
}
