using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Specifications
{
    [Binding]
    public class TestFeatureSteps
    {
        ScenarioContext _scenarioContext;
        FeatureContext _featureContext;
        private int _total = 0;

        public TestFeatureSteps(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
        }

        [BeforeScenario]
        public void BeforeTest()
        {
            
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _total += p0;
            //_scenarioContext.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //
            //_scenarioContext.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0,_total);
            //_scenarioContext.Pending();
        }
    }
}
