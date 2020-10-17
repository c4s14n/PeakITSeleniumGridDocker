using System.Threading;
using NUnit.Framework;
using SeleniumGridWithDocker.PageObjects;

namespace SeleniumGridWithDocker
{
    [TestFixture]
    [Parallelizable]
    public class Tests:Hooks
    {
        [Test]
        public void LoginIntoApplicationWithValidEmailAndPassword()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.GoToAutentificarePage();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.LoginIntoApplication("admin.test3@gmail.com", "password123");
            Assert.IsTrue(myHomePage.DeconectareButton.Displayed);
        }
        [Test]
        public void LoginIntoApplicationWithInvalidEmailAndPassword()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.GoToAutentificarePage();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.LoginIntoApplication("abcedfs@gmail.com", "dasdcsdfds");
            myLoginPage.VerifyErrorMessageAuthentification("Cont inexitent! Incercati din nou sau creati un cont aici.");
        }
        [Test]
        public void AddToCardFunctionalityWithoutAuthentification()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.GoToVeziDetaliiPage();
            ProductPage myProductPage = new ProductPage(Driver);
            myProductPage.AddToCartAProduct();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.VerifyErrorMessageAuthentification("Pentru a efectua aceasta actiune, va rugam sa va autentificati");
        }
        [Test]
        public void VerifyShoppingCartDisabledWithoutProducts()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.GoToAutentificarePage();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.LoginIntoApplication("admin.test3@gmail.com", "password123");
            myHomePage.GoToCosPage();
            Assert.IsFalse(myHomePage.OrderNowButtton.Enabled);
        }
        [Test]
        public void EditTheRightsOfAUser()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.GoToAutentificarePage();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.LoginIntoApplication("admin.test3@gmail.com", "password123");
            myHomePage.GoToAdministrarePage();
            myHomePage.GoToUtilizatoriPage();
            UserPage myUsersPage = new UserPage(Driver);
            myUsersPage.GoToEditAUserPage();
            myUsersPage.SelectARoleForTheUser("user");
        }
        [Test]
        public void ChangeACategoryFromAdministrationPanel()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.GoToAutentificarePage();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.LoginIntoApplication("admin.test5@gmail.com", "password123");
            myHomePage.GoToAdministrarePage();
            myHomePage.GoToACategoryFromAdministrationPanel("Produse");
            myHomePage.VerifyPageSuccessfullyOpened("Adaugă produs nou");
            myHomePage.GoToACategoryFromAdministrationPanel("Utilizatori");
            myHomePage.VerifyUtilizatoriPageSuccessfullyOpened();
            myHomePage.GoToACategoryFromAdministrationPanel("Subcategorii");
            myHomePage.VerifyPageSuccessfullyOpened("Adaugă subcategorie nouă");
        }

    }
}
