using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Boa.TestSupport
{
    [Binding]
    public sealed class Hooks : Steps
    {
        #region Instance Variables

        private IActor Actor;

        #endregion

        #region BeforeScenario Hooks

        [BeforeScenario(Order = 1)]
        public void StartScreenplay()
        {
            Actor = new Actor();
            ScenarioContext.ScenarioContainer.RegisterInstanceAs(Actor);
            Actor.Can(BrowseTheWeb.With(new ChromeDriver(@"C:\WebDriver\bin")));
        }

        #endregion

        #region AfterScenario Hooks

        [AfterScenario(Order = 10000)]
        public void QuitTheWebDriver()
        {
            Actor.AttemptsTo(QuitWebDriver.ForBrowser());
        }

        #endregion
    }
}
