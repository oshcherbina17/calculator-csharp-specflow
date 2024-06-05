using System;
using OpenQA.Selenium.Appium.Windows;

namespace CalculatorCsharpSpecflow.Pages
{
    public class CalculatorPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;
        private const string ButtonLocatorPrefix = "13";
        private const string PlusButtonName = "Add";
        private const string MinusButtonName = "Subtract";
        private const string MultiplyButtonName = "Multiply";
        private const string DivideButtonName = "Divide";
        private const string EqualsButtonName = "Equals";
        private const string NegativeSignButtonName = "Negate";


        public CalculatorPage(WindowsDriver<WindowsElement> driver)
        {
            _driver = driver;
        }

        private void ClickDigit(char digit)
        {
            _driver.FindElementByAccessibilityId(ButtonLocatorPrefix + digit).Click();
        }

        public void InputNumber(int number)
        {
            string numberString = number.ToString();
            bool isNegative = numberString.StartsWith("-");

            if (isNegative)
            {
                numberString = numberString.Substring(1);
            }

            if (numberString.Length > 0)
            {
                ClickDigit(numberString[0]);
            }

            if (isNegative)
            {
                _driver.FindElementByName(NegativeSignButtonName).Click();
            }

            for (int i = 1; i < numberString.Length; i++)
            {
                ClickDigit(numberString[i]);
            }
        }

        public void ClickPlus()
        {
            _driver.FindElementByName(PlusButtonName).Click();
        }

        public void ClickMinus()
        {
            _driver.FindElementByName(MinusButtonName).Click();
        }

        public void ClickMultiply()
        {
            _driver.FindElementByName(MultiplyButtonName).Click();
        }

        public void ClickDivide()
        {
            _driver.FindElementByName(DivideButtonName).Click();
        }

        public void ClickEquals()
        {
            _driver.FindElementByName(EqualsButtonName).Click();
        }

        public void AddNumbers(int firstNum, int secondNum)
        {
            InputNumber(firstNum);
            ClickPlus();
            InputNumber(secondNum);
            ClickEquals();
        }

        public void SubtractNumbers(int firstNum, int secondNum)
        {
            InputNumber(firstNum);
            ClickMinus();
            InputNumber(secondNum);
            ClickEquals();
        }

        public void MultiplyNumbers(int firstNum, int secondNum)
        {
            InputNumber(firstNum);
            ClickMultiply();
            InputNumber(secondNum);
            ClickEquals();
        }

        public void DivideNumbers(int firstNum, int secondNum)
        {
            InputNumber(firstNum);
            ClickDivide();
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