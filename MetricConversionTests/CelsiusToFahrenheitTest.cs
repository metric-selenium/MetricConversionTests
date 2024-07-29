namespace MetricConversionTests;

using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

public class CelsiusToFahrenheitTest : IDisposable
{
    IWebDriver driver;
    WebDriverWait wait;


    public CelsiusToFahrenheitTest()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());

        ChromeOptions  options = new ChromeOptions();
        options.AddArguments("--headless");
        
        driver = new ChromeDriver(options);
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    [Theory]
    [InlineData("100", "212")]
    public void TestCelsiusToFahrenheitConversion(string c, string f)
    {
        // Navigate to the target webpage
        driver.Navigate().GoToUrl("https://www.metric-conversions.org/temperature/celsius-to-fahrenheit.htm#google_vignette");

        // Locate the Celsius input field
        IWebElement celsiusInputField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='arg']")));

        // Input a value into the Celsius field
        celsiusInputField.Clear();
        celsiusInputField.SendKeys(c);

        // Locate the Fahrenheit result field (it may update automatically)
        IWebElement fahrenheitResultField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='answerDisplay']")));

        // Verify the Fahrenheit result
        string result = fahrenheitResultField.Text;
        Assert.Contains(f, result);
    }

    public void Dispose()
    {
        driver.Quit();
    }
}
