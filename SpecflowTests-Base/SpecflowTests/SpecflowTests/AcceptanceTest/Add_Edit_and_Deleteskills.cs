using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        [Given(@"I clicked on edit skill tab under profile page")]
        public void GivenIClickedOnEditSkillTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();

            //Click on Skills tab
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }

        [When(@"I edit the new skill")]
        public void WhenIEditTheNewSkill()
        {
            //Click on Edit button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

            //Update skill
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();
            Thread.Sleep(500);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys("Software Test");

            //Finding skill level
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")).Click();

            //Update skill level
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[3]")).Click();

            //Click on Update button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        }

        [Then(@"that skill should be updated on my listings")]
        public void ThenThatSkillShouldBeUpdatedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update the added skill");

                Thread.Sleep(1000);
                string ExpectedSkillValue = "Software Test";
                string ActualSkillValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedSkillValue == ActualSkillValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill has been updated successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillUpdated");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        [Given(@"I clicked on delete skill tab under profile page")]
        public void GivenIClickedOnDeleteSkillTabUnderProfilePage()
        { 
            //Wait
            Thread.Sleep(1500);

            //Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();

            //Click on Skills tab
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }

        [When(@"I delete the added skill")]
        public void WhenIDeleteTheAddedSkill()
        {
            //Click on Delete button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();
        }

        [Then(@"that skill should be deleted from my listings")]
        public void ThenThatSkillShouldBeDeletedFromMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete the added skill");

                Thread.Sleep(1000);
                
                string ExpectedSkillValue = "";
                string ActualSkillValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedSkillValue != ActualSkillValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill has been deleted successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillDeleted");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}

