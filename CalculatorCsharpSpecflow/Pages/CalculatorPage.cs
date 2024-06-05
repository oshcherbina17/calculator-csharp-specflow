using System;
using OpenQA.Selenium.Appium.Windows;

namespace CalculatorCsharpSpecflow.Pages
{
    public class CalculatorPage
    {
       private readonly WindowsDriver<WindowsElement> _driver;
        private const string ButtonLocatorPrefix = "13";
        private const string PlusButtonName = "Add";
        private const string EqualsButtonName = "Equals";
        public CalculatorPage(WindowsDriver<WindowsElement> driver) {
            _driver = driver;
        }

        private void ClickDigit(char digit) {
            _driver.FindElementByAccessibilityId(ButtonLocatorPrefix + digit).Click();
        }

        public void InputNumber(int number) {
            foreach (var digit in number.ToString())
            {
                ClickDigit(digit);
            }
        }

        public void ClickPlus() {
            _driver.FindElementByName(PlusButtonName).Click();
        }

        public void ClickEquals() {
            _driver.FindElementByName(EqualsButtonName).Click();
        }

        public void AddNumbers(int firstNum, int secondNum) {
            InputNumber(firstNum);
            ClickPlus();
            InputNumber(secondNum);
            ClickEquals();
        }

        public int GetResult()
        {
            var resultElement = _driver.FindElementByName("Result");
            return int.Parse(resultElement.Text);
        }

        public void Clear()
        {
            _driver.FindElementByName("Clear").Click();
        }
    }
}