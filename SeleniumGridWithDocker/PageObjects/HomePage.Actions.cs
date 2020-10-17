using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumGridWithDocker.PageObjects
{
    partial class HomePage
    {
        private IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void GoToAutentificarePage()
        {
            AutentificareButton.Click();
        }
        public void GoToVeziDetaliiPage()
        {
            VeziDetaliiButton.Click();
        }
        public void GoToCosPage()
        {
            CosButton.Click();
        }
        public void GoToAdministrarePage()
        {
            AdministrationButton.Click();
        }
        public void GoToUtilizatoriPage()
        {
            UtilizatoriButton.Click();
        }
        public void GoToACategoryFromAdministrationPanel(string categoryAdmin)
        {
            CategoryAdministrationButton(categoryAdmin).Click();
        }
        public void VerifyPageSuccessfullyOpened(string pageAdmin)
        {
            Assert.IsTrue(AddButtonFromCategory(pageAdmin).Displayed);
        }
        public void VerifyUtilizatoriPageSuccessfullyOpened()
        {
            Assert.IsTrue(RolFieldTable.Displayed);
        }
    }
}
