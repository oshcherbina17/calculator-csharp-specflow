using System;

using BoDi;

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
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("app", "win32calc.exe");
            var url = new Uri("http://18.196.125.117:4723/wd/hub");

            _driver = new WindowsDriver<WindowsElement>(url, appiumOptions);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _container.RegisterInstanceAs(_driver);
        }

        
    }
}
