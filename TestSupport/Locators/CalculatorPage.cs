using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using System.Globalization;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace Boa.TestSupport
{
    public static class CalculatorPage
    {
        #region Constants

        #endregion

        public const string Url = "https://www.theonlinecalculator.com/";

        #region Locators

        public static IWebLocator Display => L(
            "Calculator Display Input",
            By.Id("display"));

        public static IWebLocator NumberButton(string number) => L(
            $"Calculator Number Button {number}",
            By.CssSelector($"input.button.number[value='{number}']"));

        public static IWebLocator OperatorButton(string name) => L(
            $"Calculator Operator Button {CultureInfo.InvariantCulture.TextInfo.ToTitleCase(name)}",
            By.CssSelector($"input.button.operator[name='{name}']"));

        #endregion
    }
}
