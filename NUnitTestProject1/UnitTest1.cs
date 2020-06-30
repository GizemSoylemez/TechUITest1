using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Order(1)]
        public void Test1()
        {
            //Loginin baþarý bir þekilde oluþturulmasý.
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.trendyol.com/");
            driver.Manage().Window.Maximize();


            IWebElement PopUp = driver.FindElement(By.XPath("//*[@id='popupContainer']/div/div[2]/a/span[1]/img"));
            PopUp.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='accountBtn']"));
            LoginButton.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement emailTextBox = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextBox.SendKeys("");
            IWebElement passwordTextBox = driver.FindElement(By.XPath("//*[@id='password']"));
            IWebElement signUpButton = driver.FindElement(By.XPath("//*[@id='loginSubmit']"));

            emailTextBox.SendKeys("ggizemsoylemez20@outlook.com");
            passwordTextBox.SendKeys("123456gs");
            signUpButton.Click();
        }

        [Test]
        [Order(2)]
        public void Test2()
        {
            //Emaili boþ býrakýldýðýnda hata mesajýnýn gösterilmesi.
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.trendyol.com/");
            driver.Manage().Window.Maximize();


            IWebElement PopUp = driver.FindElement(By.XPath("//*[@id='popupContainer']/div/div[2]/a/span[1]/img"));
            PopUp.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='accountBtn']"));
            LoginButton.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement emailTextBox = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextBox.SendKeys("");
            IWebElement passwordTextBox = driver.FindElement(By.XPath("//*[@id='password']"));
            IWebElement signUpButton = driver.FindElement(By.XPath("//*[@id='loginSubmit']"));

            emailTextBox.SendKeys("");
            passwordTextBox.SendKeys("123456gs");
            signUpButton.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement errorMessage = driver.FindElement(By.XPath("//*[@id='errorBox']"));
            string text = errorMessage.Text;
            Assert.IsTrue(errorMessage.Text.Contains("Lütfen email adresinizi giriniz."));
        }

        [Test]
        [Order(3)]
        public void Test3()
        {
            //Password boþ býrakýldýðýnda hata mesajýnýn gösterilmesi.
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.trendyol.com/");
            driver.Manage().Window.Maximize();


            IWebElement PopUp = driver.FindElement(By.XPath("//*[@id='popupContainer']/div/div[2]/a/span[1]/img"));
            PopUp.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='accountBtn']"));
            LoginButton.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement emailTextBox = driver.FindElement(By.XPath("//*[@id='email']"));
            emailTextBox.SendKeys("");
            IWebElement passwordTextBox = driver.FindElement(By.XPath("//*[@id='password']"));
            IWebElement signUpButton = driver.FindElement(By.XPath("//*[@id='loginSubmit']"));

            emailTextBox.SendKeys("gizemsoylemez20@outlook.com");
            passwordTextBox.SendKeys("");
            signUpButton.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement errorMessage = driver.FindElement(By.XPath("//*[@id='errorBox']"));
            string text = errorMessage.Text;
            Assert.IsTrue(errorMessage.Text.Contains("Lütfen þifre giriniz."));

        }
    }
}