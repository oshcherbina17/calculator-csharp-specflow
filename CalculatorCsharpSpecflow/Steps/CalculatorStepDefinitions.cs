using System;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using CalculatorCsharpSpecflow.Pages;
using TechTalk.SpecFlow;

namespace CalculatorCsharpSpecflow.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly CalculatorPage _calculatorPage;

        public CalculatorSteps(WindowsDriver<WindowsElement> driver)
        {
            _calculatorPage = new CalculatorPage(driver);
        }

        [When("I add (.*) and (.*)")]
        public void WhenIAddNumbers(int firstNum, int secondNum)
        {
            _calculatorPage.Clear();
            _calculatorPage.AddNumbers(firstNum, secondNum);
        }

        [When("I subtract (.*) from (.*)")]
        public void WhenISubtractNumbers(int firstNum, int secondNum)
        {
            _calculatorPage.Clear();
            _calculatorPage.SubtractNumbers(secondNum, firstNum);
        }

        [When("I multiply (.*) and (.*)")]
        public void WhenIMultiplyNumbers(int firstNum, int secondNum)
        {
            _calculatorPage.Clear();
            _calculatorPage.MultiplyNumbers(firstNum, secondNum);
        }

        [When("I divide (.*) by (.*)")]
        public void WhenIDivideNumbers(int firstNum, int secondNum)
        {
            _calculatorPage.Clear();
            _calculatorPage.DivideNumbers(firstNum, secondNum);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            int actualResult = _calculatorPage.GetResult();
            TestContext.Progress.WriteLine($"Expected Result: {expectedResult}, Actual Result: {actualResult}");
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}