using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDomaci1
{
    public class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            

        }
        [SetUp]

        public void Inicijalizacija()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            driver.Manage().Window.Maximize();

        }
        [Test]

        public void Test1 ()
        {
            IWebElement name = driver.FindElement(By.Id("firstName"));
            name.SendKeys("Kosta");

            IWebElement lastname = driver.FindElement(By.Id("lastName"));
            lastname.SendKeys("Blagojevic");

            IWebElement mail = driver.FindElement(By.Id("userEmail"));
            mail.SendKeys("mejladresa@code.com");

            IWebElement gender = driver.FindElement(By.ClassName("custom-control-label"));
            gender.Click();

            IWebElement phone = driver.FindElement(By.Id("userNumber"));
            phone.SendKeys("0657497263");

            IWebElement address = driver.FindElement(By.Id("currentAddress"));
            address.SendKeys("Nemam adresu br 5");

        }
        [TearDown]

        public void Close()
        {
            driver.Close();

        }
    }
}
