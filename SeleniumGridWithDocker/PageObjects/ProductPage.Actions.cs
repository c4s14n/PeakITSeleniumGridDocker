using OpenQA.Selenium;

namespace SeleniumGridWithDocker.PageObjects
{
    partial class ProductPage
    {
        private IWebDriver _driver;
        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void AddToCartAProduct()
        {
            AdaugaInCosButton.Click();
        }
    }
}
