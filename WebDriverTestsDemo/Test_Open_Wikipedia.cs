
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


// Create new chrome browser instance
var driver = new ChromeDriver();

// Navigate to Wikipedia
driver.Url = "https://wikipedia.org";

// Locate search Field by ID
var searchField = driver.FindElement(By.Id("searchInput"));

// click on element
searchField.Click();

// Find QA and press Enter keyboard button
searchField.SendKeys("Quality Assuarance" + Keys.Enter);

System.Console.WriteLine("Title after search: " + driver.Title);
// Close browser
driver.Quit();
