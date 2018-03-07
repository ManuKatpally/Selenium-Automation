 try
            {
                // Populating the data from Excel
                ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewProperty");

                //click owner menu
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

                //click properties option
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));

                Thread.Sleep(1000);

                //searching record to edit
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(43, "Locator"), ExcelLib.ReadData(43, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));

                Thread.Sleep(500);

                //Click search button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(44, "Locator"), ExcelLib.ReadData(44, "Value"));
                Thread.Sleep(1000);




                //Select the required record to Edit
                try
                {
                    IList getrow = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(70, "Value")));
                    int listcount = getrow.Count;
                    bool foundrec = true;

                    for (int i = 1; i <= listcount && foundrec == true; i++)
                    {
                        if (ExcelLib.ReadData(RowCountBase, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div[" + i + "]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")).Text)
                        {

                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Searched record found");
                            Thread.Sleep(1000);
                            //Click on Edit button from list

                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div[1]/div/div/div[3]/div/div[2]")).Click();
                            Thread.Sleep(2000);

                        }
                        else
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Data Not matched");
                            Thread.Sleep(2000);
                        }


                    }
                }
                catch (Exception e)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, e.Message + "There is an issue on Edit,Please check");
                    Thread.Sleep(2000);
                }


                //Edit Property Name
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(71, "Locator"), ExcelLib.ReadData(71, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(71, "Locator"), ExcelLib.ReadData(71, "Value"), ExcelLib.ReadData(RowCountBase, "EditName"));
                Thread.Sleep(1000);
                //Edit Description
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(72, "Locator"), ExcelLib.ReadData(72, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(72, "Locator"), ExcelLib.ReadData(72, "Value"), ExcelLib.ReadData(RowCountBase, "EditDesc"));
                Thread.Sleep(1000);
                //Edit Property Type
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(73, "Locator"), ExcelLib.ReadData(73, "Value"), ExcelLib.ReadData(RowCountBase, "EditPropertyType"));
                Thread.Sleep(1000);

                //Choose Property Type from Dropdown list
                IList<IWebElement> proptypelist = Driver.driver.FindElements(By.XPath("//*[@id='property-details']/div[1]/div[2]/div/div/div/ul/li"));

                int listcounts = proptypelist.Count();

                for (int i = 0; i < listcounts; i++)
                {
                    if (proptypelist[i].Text == "Vacation Property")
                    {
                        proptypelist[i].Click();
                    }
                }

                //Search Address
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(74, "Locator"), ExcelLib.ReadData(74, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(74, "Locator"), ExcelLib.ReadData(74, "Value"), ExcelLib.ReadData(RowCountBase, "EditAddress"));
                Thread.Sleep(1000);
                //Year Built
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(75, "Locator"), ExcelLib.ReadData(75, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(75, "Locator"), ExcelLib.ReadData(75, "Value"), ExcelLib.ReadData(RowCountBase, "EditYear"));
                Thread.Sleep(1000);
                //Rent Amount
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(76, "Locator"), ExcelLib.ReadData(76, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(76, "Locator"), ExcelLib.ReadData(76, "Value"), ExcelLib.ReadData(RowCountBase, "EditRentAmount"));
                Thread.Sleep(1000);
                //Rent Type
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(77, "Locator"), ExcelLib.ReadData(77, "Value"), ExcelLib.ReadData(RowCountBase, "EditRentType"));
                Thread.Sleep(1000);
                IList<IWebElement> Renttypes = Driver.driver.FindElements(By.XPath("//*[@id='property-details']/div[3]/div[3]/div/select/option"));

                int RentTypeCount = Renttypes.Count();

                for (int i = 0; i < RentTypeCount; i++)
                {
                    if (Renttypes[i].Text == "Weekly")
                    {
                        Thread.Sleep(2000);
                        Renttypes[i].Click();
                    }
                }
                //Land Area
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(78, "Locator"), ExcelLib.ReadData(78, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(78, "Locator"), ExcelLib.ReadData(78, "Value"), ExcelLib.ReadData(RowCountBase, "EditLandArea"));
                Thread.Sleep(1000);
                //Floor Area
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(79, "Locator"), ExcelLib.ReadData(79, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(79, "Locator"), ExcelLib.ReadData(79, "Value"), ExcelLib.ReadData(RowCountBase, "EditFloorArea"));
                Thread.Sleep(1000);
                //Bedrooms
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(80, "Locator"), ExcelLib.ReadData(80, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(80, "Locator"), ExcelLib.ReadData(80, "Value"), ExcelLib.ReadData(RowCountBase, "EditBedroom"));
                Thread.Sleep(1000);
                //Bathrooms
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(81, "Locator"), ExcelLib.ReadData(81, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(81, "Locator"), ExcelLib.ReadData(81, "Value"), ExcelLib.ReadData(RowCountBase, "EditBathroom"));
                Thread.Sleep(1000);
                //Carparks
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(82, "Locator"), ExcelLib.ReadData(82, "Value"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(82, "Locator"), ExcelLib.ReadData(82, "Value"), ExcelLib.ReadData(RowCountBase, "EditCarparks"));
                Thread.Sleep(1000);
                //Save
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.Tab).Perform();
                Thread.Sleep(2000);
                IWebElement Save = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(83, "Value")));
                if (Save.Enabled)
                {
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(83, "Locator"), ExcelLib.ReadData(83, "Value"));
                    Thread.Sleep(1000);
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Record Edited Successfully");
                    Thread.Sleep(1000);

                    //verify edited record and navigate through pages to find the record
                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(43, "Locator"), ExcelLib.ReadData(43, "Value"), ExcelLib.ReadData(RowCountBase, "EditName"));
                    Thread.Sleep(2000);
                    //SearchButton.Click();
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(44, "Locator"), ExcelLib.ReadData(44, "Value"));
                    Thread.Sleep(2000);
                    //If property search returns no results popup occurs and test failed
                    if (Driver.ElementVisible(Driver.driver, ExcelLib.ReadData(64, "Locator"), ExcelLib.ReadData(64, "Value")) == true)
                    {
                        Base.test.Log(LogStatus.Fail, "Search for Property found no results, Edit property test failed");
                    }

                    try
                    {
                        //get row count using Ilist 

                        IList proplistt = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(63, "Value")));
                        int listcountS = proplistt.Count;
                        for (int i = 1; i <= listcountS; i++)
                        {
                            if (ExcelLib.ReadData(2, "EditName") == Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(84, "Locator"), ExcelLib.ReadData(84, "Value"))) 
                            {
                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Found Edited Property");
                                Thread.Sleep(2000);
                                //Log Info
                                Base.test.Log(LogStatus.Pass, "Edited Property found and verified");
                                Thread.Sleep(2000);
                                break;

                            }
                            else
                            {
                                Base.test.Log(LogStatus.Fail, "Property not found, Edit property test failed");
                            }
                        }


                    }
                    catch (Exception e)
                    {
                        Base.test.Log(LogStatus.Info, e.Message + "There is an issue,Please check");
                    }
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
        }
