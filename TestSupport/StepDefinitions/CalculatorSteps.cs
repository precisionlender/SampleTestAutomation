using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Boa.TestSupport
{
    [Binding]
    public sealed class CalculatorSteps : Steps
    {
        #region Properties

        private IActor Actor { get; set; }

        #endregion

        #region Constructors

        public CalculatorSteps(IActor actor) => Actor = actor;

        #endregion

        #region Given Steps

        [Given(@"the user navigates to the calculator page")]
        public void GivenTheUserNavigatesToTheCalculatorPage()
        {
            Actor.AttemptsTo(Navigate.ToUrl(CalculatorPage.Url));
        }

        #endregion

        #region When Steps

        [When(@"the user clicks the ""(.*)"" button")]
        public void WhenTheUserClicksTheButton(string name)
        {
            Actor.AttemptsTo(Click.On(CalculatorPage.OperatorButton(name)));
        }

        [When(@"the user clicks the calculator buttons to input ""(\d+)""")]
        public void WhenTheUserClicksTheCalculatorButtonsToInput(string value)
        {
            var numbers = value.ToCharArray();

            foreach (var number in numbers)
            {
                Actor.AttemptsTo(Click.On(CalculatorPage.NumberButton(number.ToString())));
            }
        }

        #endregion

        #region Then Steps

        [Then(@"the display shows ""(.*)""")]
        public void ThenTheDisplayShows(string expected)
        {
            var actual = Actor.AsksFor(ValueAttribute.Of(CalculatorPage.Display));
            actual.Should().Be(expected);
        }

        #endregion
    }
}
 