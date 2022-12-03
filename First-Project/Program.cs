
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome broweser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify usernamne textbox and enter valid username 
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// identify password textbox and enter valid password
IWebElement UserpasswordTextbox = driver.FindElement(By.Id("Password"));
UserpasswordTextbox.SendKeys("123123");

// click login button//
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
// check if user has logged in successfully
IwebElement helloHari = (IwebElement)driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "hello Hari!")
{
    Console.WriteLine("Loggedin Successfully, test passed.");
}
else
{
    Console.WriteLine("Loggedin Unsuccessfully");
}

