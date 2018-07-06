using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleMail
{
  public class SettingsPage
  {
    private readonly By GoogleAppsButton = By.XPath("//div[@id='gbwa']");
    private readonly By MailButton = By.XPath("//span[text()='Почта']");

    private IWebDriver Driver;

    public SettingsPage(IWebDriver webDriver)
    {
      Driver = webDriver;
    }

    public MailPage GoToMailPage()
    {
      WaitForElement(GoogleAppsButton);
      Driver.FindElement(GoogleAppsButton).Click();
      WaitForElement(MailButton);
      Driver.FindElement(MailButton).Click();
      return new MailPage(Driver);
    }

    public void WaitForElement(By locator)
    {
      new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));
    }
  }
}