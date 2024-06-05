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

        [When("Add (.*) and (.*)")]
        public void WhenAddNumbers(int firstNum,int secondNum) {
            _calculatorPage.Clear();
            _calculatorPage.AddNumbers(firstNum,secondNum);
        }
        

        [Then("the result should (.*)")]
        public void ThenTheResultShould(int expectedResult) {
            Assert.AreEqual(_calculatorPage.GetResult(), expectedResult);
        } 
    }
}