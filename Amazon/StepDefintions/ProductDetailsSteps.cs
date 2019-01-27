using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Amazon.StepDefintions
{
    [Binding]
    public sealed class ProductDetailsSteps
    {
        IWebDriver driver;

        [Given(@"I navigate to Amazon home page")]
        public void GivenINavigateToAmazonHomePage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }

        [Given(@"I search for wrist watch")]
        public void GivenISearchForWristWatch()
        {
            
        }

        [Given(@"I click on one of the search reuslt displayed")]
        public void GivenIClickOnOneOfTheSearchReusltDisplayed()
        {
            
        }

        [Then(@"the product price is displayed")]
        public void ThenTheProductPriceIsDisplayed()
        {
            
        }

    }
}
