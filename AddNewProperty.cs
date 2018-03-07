 class NewProperty
    {
        internal NewProperty()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        public static int RowCountBase = Int32.Parse(KeysResource.RowNum);
        // Add new property
        public void AddnewProperty()
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewProperty");

                // Owner link
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(500);

                //properties option
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(1000);

                //AddNewProperty
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
                Thread.Sleep(1000);

                //Read data from excel sheet to fill the Property deatils

                //Property Name
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
                Thread.Sleep(1000);

                //Description
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "Desc"));
                Thread.Sleep(1000);

                //PropertyType
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"), ExcelLib.ReadData(RowCountBase, "PropertyType"));
                Thread.Sleep(1000);

                //Choose Property Type from Dropdown list
                IList<IWebElement> proptypelist = Driver.driver.FindElements(By.XPath("//*[@id='property-details']/div[1]/div[2]/div/div/div/ul/li"));

                int listcount = proptypelist.Count();

                for (int i = 0; i < listcount; i++)
                {
                    if (proptypelist[i].Text == "Student Housing")
                    {
                        proptypelist[i].Click();
                    }
                }
                //Search Address
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(RowCountBase, "Address"));
                Thread.Sleep(2000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.ArrowDown).Perform();
                Thread.Sleep(2000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.Return).Perform();
                Thread.Sleep(2000);

                //scroll down
                IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.driver;
                IWebElement element1 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(25, "Value")));
                (jse).ExecuteScript("arguments[0].scrollIntoView(true);", element1);

                Thread.Sleep(1000);
                //Select rent type from the drop down
                IList<IWebElement> Renttypes = Driver.driver.FindElements(By.XPath("//*[@id='property-details']/div[3]/div[3]/div/select/option"));

                int RentTypeCount = Renttypes.Count();

                for (int i = 0; i < RentTypeCount; i++)
                {
                    if (Renttypes[i].Text == "Monthly")
                    {
                        Thread.Sleep(2000);
                        Renttypes[i].Click();
                    }
                }
                //Year Built
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"), ExcelLib.ReadData(RowCountBase, "Year"));
                Thread.Sleep(1000);

                //target rent
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"), ExcelLib.ReadData(RowCountBase, "TargetRent"));
                Thread.Sleep(1000);

                //Bedrooms
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"), ExcelLib.ReadData(RowCountBase, "Bedroom"));
                Thread.Sleep(2000);

                //Bathrooms
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"), ExcelLib.ReadData(RowCountBase, "Bathroom"));
                Thread.Sleep(2000);

                //FloorArea
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value"), ExcelLib.ReadData(RowCountBase, "FloorArea"));
                Thread.Sleep(2000);

                //Land Area
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value"), ExcelLib.ReadData(RowCountBase, "LandArea"));
                Thread.Sleep(2000);

                //Car parks
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(31, "Locator"), ExcelLib.ReadData(31, "Value"), ExcelLib.ReadData(RowCountBase, "Carparks"));
                Thread.Sleep(2000);

                //scroll down
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)Driver.driver;
                IWebElement element2 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(34, "Value")));
                (js1).ExecuteScript("arguments[0].scrollIntoView(true);", element2);

                //Next button not enabled dynamically - include action tab key
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.Tab).Perform();
                Thread.Sleep(2000);

                //click on next 
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));
                Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Info, e.Message + "There is an issue,Please check");
            }
            try
            {

                //Add financial data

                //purchase price

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(37, "Locator"), ExcelLib.ReadData(37, "Value"), ExcelLib.ReadData(37, "Value2"));
                Thread.Sleep(2000);

                //Mortgage
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(38, "Locator"), ExcelLib.ReadData(38, "Value"), ExcelLib.ReadData(38, "Value2"));
                Thread.Sleep(2000);

                //Home Value
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(39, "Locator"), ExcelLib.ReadData(39, "Value"), ExcelLib.ReadData(39, "Value2"));
                Thread.Sleep(2000);

                //Select home value type from the dropdown
                IList<IWebElement> homevaluetypes = Driver.driver.FindElements(By.XPath("//*[@id='financeSection']/div[2]/div[2]/div/select/option"));

                int HomevalueTypeCount = homevaluetypes.Count();

                for (int i = 0; i < HomevalueTypeCount; i++)
                {
                    if (homevaluetypes[i].Text == "Estimated")
                    {
                        Thread.Sleep(2000);
                        homevaluetypes[i].Click();
                    }
                }
                Thread.Sleep(2000);
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                Thread.Sleep(2000);
                IWebElement element = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(56, "Value")));

                (js).ExecuteScript("arguments[0].scrollIntoView(true);", element);
                Thread.Sleep(2000);
                //Click on next
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(56, "Locator"), ExcelLib.ReadData(56, "Value"));
                Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Info, e.Message + "There is an issue,Please check");
            }
            try
            {

                //Add tenant details
                //Enter tenant email
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(50, "Locator"), ExcelLib.ReadData(50, "Value"), ExcelLib.ReadData(50, "Value2"));
                Thread.Sleep(2000);


                //Main tenant
                IList<IWebElement> maintenant = Driver.driver.FindElements(By.XPath("//*[@id='tenant-area']/div[1]/div[2]/div/select/option"));

                int mainCount = maintenant.Count();

                for (int i = 0; i < mainCount; i++)
                {
                    if (maintenant[i].Text == "No")
                    {
                        Thread.Sleep(2000);
                        maintenant[i].Click();
                    }
                }

                //First Name
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(65, "Locator"), ExcelLib.ReadData(65, "Value"), ExcelLib.ReadData(65, "Value2"));

                //Last Name
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(66, "Locator"), ExcelLib.ReadData(66, "Value"), ExcelLib.ReadData(66, "Value2"));

                //Start Date
                Thread.Sleep(2000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(51, "Locator"), ExcelLib.ReadData(51, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(51, "Locator"), ExcelLib.ReadData(51, "Value"), ExcelLib.ReadData(51, "Value2"));

                //End Date
                Thread.Sleep(3000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(52, "Locator"), ExcelLib.ReadData(52, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(52, "Locator"), ExcelLib.ReadData(52, "Value"), ExcelLib.ReadData(52, "Value2"));

                //Payment Frequency
                IList<IWebElement> payfreqlist = Driver.driver.FindElements(By.XPath("//*[@id='tenantSection']/div[4]/div[2]/div/select/option"));

                int payfreqCount = payfreqlist.Count();

                for (int i = 0; i < payfreqCount; i++)
                {
                    if (payfreqlist[i].Text == "Monthly")
                    {
                        Thread.Sleep(2000);
                        payfreqlist[i].Click();
                    }
                }
                //Enter rent amount
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(58, "Locator"), ExcelLib.ReadData(58, "Value"), ExcelLib.ReadData(58, "Value2"));
                Thread.Sleep(2000);

                //payment start date
                Thread.Sleep(3000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(67, "Locator"), ExcelLib.ReadData(67, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(67, "Locator"), ExcelLib.ReadData(67, "Value"), ExcelLib.ReadData(67, "Value2"));

                //payment due date
                Thread.Sleep(1000);
                IList<IWebElement> payduelist = Driver.driver.FindElements(By.XPath("//*[@id='tenantSection']/div[5]/div[2]/div/select/option"));

                int paydueCount = payduelist.Count();

                for (int i = 0; i < paydueCount; i++)
                {
                    if (payduelist[i].Text == "1")
                    {
                        payduelist[i].Click();
                    }
                }

                Thread.Sleep(2000);
                IWebElement save = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(54, "Value")));

                if (save.Enabled)
                {
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(54, "Locator"), ExcelLib.ReadData(54, "Value"));
                    Thread.Sleep(1000);
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Mandatory fields entered, Clicked on save button to add a new property");
                    Thread.Sleep(1000);

                    //Check if unregistered tenant alert on screen, if so accept
                    if (Driver.isDialogPresent(Driver.driver))
                    {
                        Driver.driver.SwitchTo().Alert().Accept();
                    }

                    Thread.Sleep(1000);

                    Base.test.Log(LogStatus.Info, "Record added sucessfully");
                    Thread.Sleep(3000);

                    //verify added record and navigate through pages to find the record
                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(43, "Locator"), ExcelLib.ReadData(43, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
                    Thread.Sleep(2000);
                    //SearchButton.Click();
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(44, "Locator"), ExcelLib.ReadData(44, "Value"));
                    Thread.Sleep(2000);

                    //If property search returns no results popup occurs and test failed
                    if (Driver.ElementVisible(Driver.driver, ExcelLib.ReadData(64, "Locator"), ExcelLib.ReadData(64, "Value")) == true)
                    {
                        Base.test.Log(LogStatus.Fail, "Search for Property found no results, add property test failed");
                    }

                /*
                        //get row count using Ilist 

                        IList proplistt = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(63, "Value")));
                        int listcountS = proplistt.Count;
                        for (int i = 1; i <= listcountS; i++)
                        {
                            if (ExcelLib.ReadData(2, "Name") == Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(61, "Locator"), ExcelLib.ReadData(61, "Value") + i + ExcelLib.ReadData(61, "Value2")))
                            {*/
                                IWebElement Name = Driver.driver.FindElement(By.XPath("//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]"));
                                string confirmName = Name.Text;
                                Assert.AreEqual("Spencors villa", confirmName);
                                IWebElement Address = Driver.driver.FindElement(By.XPath("//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[2]/span[1]"));
                                string confirmAddress = Address.Text;
                                Assert.AreEqual("411 Gloucester Street,", confirmAddress);
                                IWebElement Address1 = Driver.driver.FindElement(By.XPath("//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[2]/span[2]"));
                                string confirmAddress1 = Address1.Text;
                                Assert.AreEqual("Linwood, Christchurch", confirmAddress1);
                                IWebElement PurchasePrice = Driver.driver.FindElement(By.XPath("//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[2]/div[1]/span"));
                                string confirmPrice = PurchasePrice.Text;
                                Assert.AreEqual("1,200,000.00", confirmPrice);
                                IWebElement Homevalue = Driver.driver.FindElement(By.XPath("//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[2]/div[2]/span"));
                                string confirmHomevalue = Homevalue.Text;
                                Assert.AreEqual("1,500,000.00", confirmHomevalue);

                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Found Added Property");
                                Thread.Sleep(2000);
                                //Log Info
                                Base.test.Log(LogStatus.Pass, "Added Property found and verified");
                                Thread.Sleep(2000);
                   /* break;

                            
                           } else
                            {
                                Base.test.Log(LogStatus.Fail, "Property not found, add property test failed");
                            }
                        }*/


                    }
                   
                 else
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Submit button is disabled. Please check your data");
                }
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Error, e.Message + "Error : ");
            }

         
