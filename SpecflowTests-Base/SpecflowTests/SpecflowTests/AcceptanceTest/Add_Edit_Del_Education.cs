using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests
{
    [Binding]
    public class Add_Edit_Del_Education
    {
        [Given(@"I clicked on the skill tab under profile page")]
        public void GivenIClickedOnTheSkillTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();
        }

        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            //Click on Skills button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();

            //Click on Add New button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            //Enter Skill
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("QA Test");

            //Finding Skill Level dropdown
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")).Click();

            //Select skill level
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]")).Click();

            //Click on Add button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
        }

        [Then(@"that skill should be displayed on my listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a new skill");

                Thread.Sleep(1000);
                string ExpectedSkillValue = "QA Test";
                string ActualSkillValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedSkillValue == ActualSkillValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill has been added successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "NewSkillAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        [Given(@"I clicked on the education tab under profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();
        }

        [When(@"I add a new education")]
        public void WhenIAddANewEducation()
        {
            //Click on Education button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            //Click on Add New button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();

            //Enter College Name
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).SendKeys("Ara Institute");

            //Select Country of College dropdown
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]")).Click();

            //Select Title of Education
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]")).Click();

            //Enter Degree Name
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys("IT");

            //Select Year of Graduation
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[5]")).Click();
            
            //Click on Add button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();
        }

        [Then(@"that education should be displayed on my listings")]
        public void ThenThatEducationShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a new education");

                Thread.Sleep(1000);
                string ExpectedCountryValue = "New Zealand";
                string ActualCountryValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                string ExpectedUniValue = "Ara Institute";
                string ActualUniValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
                Thread.Sleep(500);
                string ExpectedDegValue = "IT";
                string ActualDegValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]")).Text;
                Thread.Sleep(500);
                string ExpectedYearValue = "2016";
                string ActualYearValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]")).Text;
                Thread.Sleep(500);
                if (ExpectedCountryValue == ActualCountryValue && ExpectedDegValue == ActualDegValue && ExpectedDegValue == ActualDegValue && ExpectedYearValue == ActualYearValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Education has been added successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "NewEducationAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        [Given(@"I clicked on edit education tab under profile page")]
        public void GivenIClickedOnEditEducationTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();

            //Click on Education tab
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
        }

        [When(@"I edit the new education")]
        public void WhenIEditTheNewEducation()
        {
            //Click on Edit button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i")).Click();

            //Update Title
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select/option[8]")).Click();
            Thread.Sleep(500);

            //Update Degree
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input")).Clear();
            Thread.Sleep(500);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input")).SendKeys("CSE");
            Thread.Sleep(500);

            //Update Year of Graduation
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select/option[3]")).Click();

            //Click on Update button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")).Click();
        }

        [Then(@"that education should be updated on my listings")]
        public void ThenThatEducationShouldBeUpdatedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update the added education");

                Thread.Sleep(1000);
                string ExpectedTitleValue = "M.Tech";
                string ActualTitleValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]")).Text;
                Thread.Sleep(500);
                string ExpectedGradYearValue = "2018";
                string ActualGradYearValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]")).Text;
                Thread.Sleep(500);

                if (ExpectedTitleValue == ActualTitleValue && ExpectedGradYearValue == ActualGradYearValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Education has been updated successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationUpdated");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        [Given(@"I clicked on delete education tab under profile page")]
        public void GivenIClickedOnDeleteEducationTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();

            //Click on Education tab
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
        }

        [When(@"I delete the added education")]
        public void WhenIDeleteTheAddedEducation()
        {
            //Click on Delete button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i")).Click();
        }

        [Then(@"that education should be deleted from my listings")]
        public void ThenThatEducationShouldBeDeletedFromMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete the added education");

                Thread.Sleep(1000);

                string ExpectedUniversityValue = "";
                string ActualUniversityValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[2]")).Text;
                Thread.Sleep(500);
                if (ExpectedUniversityValue != ActualUniversityValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Education has been deleted successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationDeleted");
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
