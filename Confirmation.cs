 public class ApplicationConfirmationPage
    {
        private readonly IWebDriver _driver;
        [FindsBy(How=How.Id,Using ="firstName")]
        private IWebElement _firstName;

        public ApplicationConfirmationPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public string Firstname => _firstName.Text;
    }
}
