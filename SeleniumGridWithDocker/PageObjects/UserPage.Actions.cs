using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumGridWithDocker.PageObjects
{
    partial class UserPage
    {
        private IWebDriver _driver;
        public UserPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void GoToEditAUserPage()
        {
            EditButton.Click();
        }
        public void SelectARoleForTheUser(string roleUser)
        {
            SelectElement role = new SelectElement(RoleDropdown);
            role.SelectByText(roleUser);
        }
    }
}
