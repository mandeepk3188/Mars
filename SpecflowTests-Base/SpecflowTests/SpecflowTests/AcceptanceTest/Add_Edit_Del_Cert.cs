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
    public class Add_Edit_Del_Cert
    {
        [Given(@"I clicked on the certificate tab under Profile page")]
        public void GivenIClickedOnTheCertificateTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();
        }

        [When(@"I add a new certificate")]
        public void WhenIAddANewCertificate()
        {
            //Click on Certificates button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();

            //Click on Add New button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();

            //Enter Certificate Name
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("Java");

            //Enter certified form
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys("Word");

            //Select Year
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[5]")).Click();

            //Click on Add button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();
        }

        [Then(@"that certificate should be displayed on my listings")]
        public void ThenThatCertificateShouldBeDisplayedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a new certificate");

                Thread.Sleep(1000);
                string ExpectedcertValue = "Java";
                string ActualcertValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedcertValue == ActualcertValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Certificate has been added successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "NewCertificateAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        [Given(@"I clicked on edit certificate tab under profile page")]
        public void GivenIClickedOnEditCertificateTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();

            //Click on Certificates button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
        }

        [When(@"I edit the new certificate")]
        public void WhenIEditTheNewCertificate()
        {
            //Click on Edit button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")).Click();

            //Update Certificate Name
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input")).Clear();
            Thread.Sleep(500);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input")).SendKeys("BI");
            Thread.Sleep(500);

            //Update Certificate Form
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input")).Clear();
            Thread.Sleep(500);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input")).SendKeys("Adobe");
            Thread.Sleep(500);

            //Update Year 
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select/option[3]")).Click();

            //Click on Update button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();
        }

        [Then(@"that certificate should be updated on my listings")]
        public void ThenThatCertificateShouldBeUpdatedOnMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Update the added certificate");

                Thread.Sleep(1000);
                string ExpectedcerValue = "BI";
                string ActualcerValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]")).Text;
                Thread.Sleep(500);
                string ExpectedcerformValue = "Adobe";
                string ActualcerformValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]")).Text;
                Thread.Sleep(500);

                if (ExpectedcerValue == ActualcerValue && ExpectedcerformValue == ActualcerformValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Certificate has been updated successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificateUpdated");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        [Given(@"I clicked on delete certificate tab under profile page")]
        public void GivenIClickedOnDeleteCertificateTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(1500);

            //Click on Profile tab
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/a[2]")).Click();

            //Click on Certificates button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
        }

        [When(@"I delete the added certificate")]
        public void WhenIDeleteTheAddedCertificate()
        {
            //Click on Delete button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")).Click();
        }

        [Then(@"that certificate should be deleted from my listings")]
        public void ThenThatCertificateShouldBeDeletedFromMyListings()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete the added certificate");

                Thread.Sleep(1000);

                string ExpectedcertificateValue = "";
                string ActualcertificateValue = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[1]")).Text;
                Thread.Sleep(500);
                if (ExpectedcertificateValue != ActualcertificateValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Certificate has been deleted successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificateDeleted");
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
