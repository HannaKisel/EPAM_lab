using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleMail
{
  public class AutorizationPage
  {
    private string LOGINKEY = "amoroz408";
    private string PASSWORDKEY = "behappyAnn99";

    private readonly By LoginArea = By.XPath("//input[@name='identifier']");
    private readonly By NextButton = By.XPath("//div[contains(@id,'Next')]");
    private readonly By PasswordArea = By.XPath("//input[@type='password']");

    private IWebDriver Driver;

    public AutorizationPage(IWebDriver webDriver)
    {
      Driver = webDriver;
    }

    public SettingsPage LogIn()
    {
      WaitForElement(LoginArea);
      IWebElement login = Driver.FindElement(LoginArea);
      login.SendKeys(LOGINKEY);
      Driver.FindElement(NextButton).Click();
      WaitForElement(PasswordArea);
      Driver.FindElement(PasswordArea).SendKeys(PASSWORDKEY);
      Driver.FindElement(NextButton).Click();
      return new SettingsPage(Driver);
    }

    public void WaitForElement(By locator)
    {
      new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));
    }
  }
}