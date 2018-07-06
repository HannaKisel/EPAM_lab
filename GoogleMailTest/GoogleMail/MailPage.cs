using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleMail
{
  public class MailPage
  {
    private const string RECIPIENTADRESS="hanna_maroz2@epam.com";
    private readonly By RecipientArea = By.XPath("//div[text()='Получатели']");

    private readonly By WriteButton = By.XPath("//div[text()='НАПИСАТЬ']");
    private IWebDriver Driver;

    public MailPage(IWebDriver webDriver)
    {
      Driver = webDriver;
    }

    public void WriteNewMessage()
    {
      WaitForElement(WriteButton);
      Driver.FindElement(WriteButton).Click();
    }

    public void WaitForElement(By locator)
    {
      new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(locator));
    }
  }
}