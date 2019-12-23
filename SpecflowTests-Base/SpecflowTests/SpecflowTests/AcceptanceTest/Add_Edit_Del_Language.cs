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
    public class SpecFlowFeature1Steps : Utils.Start
    {
        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();
        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            //Click on Language button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();

            //Click on Add New button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Enter language
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("English");

            //Select language level dropdown
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]")).Click();

            //Click on Add button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a new language");

                Thread.Sleep(1000);
                string ExpectedlangValue = "English";
                string ActuallangValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                string ExpectedlevelValue = "Basic";
                string ActuallevelValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
                Thread.Sleep(500);

                if (ExpectedlangValue == ActuallangValue && ExpectedlevelValue == ActuallevelValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Language has been added successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "NewLanguageAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }

        }
        [Given(@"I clicked on edit language tab under profile page")]
        public void GivenIClickedOnEditLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();

            //Click on Language tab
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
        }

        [When(@"I edit the new language")]
        public void WhenIEditTheNewLanguage()
        {
            //Click on Edit button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

            //Update Language
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).Clear();
            Thread.Sleep(500);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")).SendKeys("Spanish");
            Thread.Sleep(500);

            //Update Level
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]")).Click();
            Thread.Sleep(500);
            
            //Click on Update button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        }

        [Then(@"that language should be updated on my listings")]
        public void ThenThatLanguageShouldBeUpdatedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update the added language");

                Thread.Sleep(1000);
                string ExpectedlanValue = "Spanish";
                string ActuallanValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);

                if (ExpectedlanValue == ActuallanValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Language has been updated successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageUpdated");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        [Given(@"I clicked on delete language tab under profile page")]
        public void GivenIClickedOnDeleteLanguageTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();

            //Click on Language tab
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
        }

        [When(@"I delete the added language")]
        public void WhenIDeleteTheAddedLanguage()
        {
            //Click on Delete button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();
        }

        [Then(@"that language should be deleted from my listings")]
        public void ThenThatLanguageShouldBeDeletedFromMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete the added language");

                Thread.Sleep(1000);

                string ExpectedlanguageValue = "";
                string ActuallanguageValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedlanguageValue != ActuallanguageValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Language has been deleted successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDeleted");
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
