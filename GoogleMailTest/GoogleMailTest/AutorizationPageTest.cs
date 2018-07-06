using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using GoogleMail;

namespace GoogleMailTest
{
  [TestClass]
  public class AutorizationPageTest
  {
    const string URL = "https://accounts.google.com";
    public IWebDriver Driver { get; private set; }

    [TestInitialize]
    public void TestInit()
    {
      Driver = new ChromeDriver();
      Driver.Manage().Window.Maximize();
      Driver.Navigate().GoToUrl(URL);
    }

    [TestMethod]
    public void TestAbilityToAutomize()//divided into several tests, because it does too much action

    {
      AutorizationPage autorizationPage = new AutorizationPage(Driver);
      autorizationPage.LogIn().GoToMailPage().WriteNewMessage();
    }

   /* [TestCleanup]
    public void CleanUp()
    {
      Driver.Close();
    }*/
  }
}