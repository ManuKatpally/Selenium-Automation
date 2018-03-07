  ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewProperty");

                // Owner link
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(500);

                //properties option
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(500);

                //searching record to delete
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(43, "Locator"), ExcelLib.ReadData(43, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));

                Thread.Sleep(500);

                //Click search button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(44, "Locator"), ExcelLib.ReadData(44, "Value"));
                Thread.Sleep(1000);
                //Select the required record to delete
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
                            //Click on delete button from list

                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div[1]/div/div/div[1]/i")).Click();
                            Thread.Sleep(2000);
                            //clicking on confirmation 
                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(85, "Locator"), ExcelLib.ReadData(85, "Value"));
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
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, e.Message + "There is an issue on delete,Please check");
                    Thread.Sleep(2000);
                }
            }

        }
    }
    
