using System;
using TechTalk.SpecFlow;

namespace SpecflowTests
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        [Given(@"I clicked on the skill tab under profile page")]
        public void GivenIClickedOnTheSkillTabUnderProfilePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"that skill should be displayed on my listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyListings()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
