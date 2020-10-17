using OpenQA.Selenium;

namespace SeleniumGridWithDocker.PageObjects
{
    partial class HomePage
    {
        private IWebElement AutentificareButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        public IWebElement DeconectareButton => _driver.FindElement(By.XPath("//a[text()='Deconectare']"));
        private IWebElement VeziDetaliiButton => _driver.FindElement(By.CssSelector(".btn-primary"));
        private IWebElement CosButton => _driver.FindElement(By.XPath("//a[text()='Coș']"));
        public IWebElement OrderNowButtton => _driver.FindElement(By.XPath("//a[text()='Comandă Acum']"));
        private IWebElement AdministrationButton => _driver.FindElement(By.XPath("//a[text()='Administrare']"));
        private IWebElement UtilizatoriButton => _driver.FindElement(By.XPath("//a[text()='Utilizatori']"));
        private IWebElement CategoryAdministrationButton(string category) => _driver.FindElement(By.XPath($"//a[text()='{category}']"));
        private IWebElement AddButtonFromCategory(string category) => _driver.FindElement(By.XPath($"//a[text()='{category}']"));
        private IWebElement RolFieldTable => _driver.FindElement(By.XPath("//th[text()='Rol']"));
    }
}
