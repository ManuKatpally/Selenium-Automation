public class LoanApptest
    {
       [Fact]

        public void Application()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost:40077/");

                IWebElement ApplyButton = driver.FindElement(By.Id("startApplication"));

                ApplyButton.Click();

                Assert.Equal("Start Loan Application - Loan Application", driver.Title);
            }
    
        }
        [Fact]

        public void SubmitButton()

        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();

                driver.Navigate().GoToUrl("http://localhost:40077/Home/StartLoanApplication");

                IWebElement firstname = driver.FindElement(By.Id("FirstName"));

                firstname.SendKeys("manu");

                driver.FindElement(By.Id("LastName")).SendKeys("katpally");

                driver.FindElement(By.Id("Loan")).Click();

                driver.FindElement(By.Name("TermsAcceptance")).Click();

                driver.FindElement(By.CssSelector(".btn.btn-primary")).Click();
            
                IWebElement confirmationnamespan = driver.FindElement(By.Id("firstName"));

                string confirmationname = confirmationnamespan.Text;

                Assert.Equal("manu", confirmationname);
            }

        }
    }   
}
