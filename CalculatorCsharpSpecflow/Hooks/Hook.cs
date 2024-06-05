using System;

using BoDi;

using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium.Windows;


namespace CalculatorCsharpSpecflow.Hooks
{
    [Binding]
    public class Hooks
    {
        private WindowsDriver<WindowsElement> _driver;

        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.CloseApp();
            _driver.Quit();
        }

        [BeforeScenario(Order = 1)]
        public void InitializeDriver()
       // public void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
            var appiumOptions = new AppiumOptions();
            
            appiumOptions.AddAdditionalCapability("app", "win32calc.exe");
            var url = new Uri("http://18.196.125.117:4723/wd/hub");
           // string urlString = $"http://18.196.125.117:4723/wd/hub";
           // Uri url = new Uri(urlString);

            
            _driver = new WindowsDriver<WindowsElement>(url, appiumOptions);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _container.RegisterInstanceAs(_driver);
           // _container.RegisterInstanceAs<WindowsDriver<WindowsElement>>(_driver);

        }

        
    }
}
