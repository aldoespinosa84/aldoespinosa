using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverManager.DriverConfigs.Impl;


namespace SeleniumLearning
{
    public class Locators() {
        //Xpat, css, id, classname, name, tagename

        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();         
            driver.Url = "http://www.rahulshettyacademy.com/loginpagePractise/";     
        }


        [Test]
        public void LocatorsIdentification()
        {
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Name("password")).SendKeys("123456");
           

            //css selector & xpath
            //tagname [attribute='value']
            //driver.FindElement(By.CssSelector("input[value='Sign In']")).Click();

            //tagnmae[@attribute='value']
            driver.FindElement(By.XPath("//input[@id='signInBtn']")).Click();
            
            //agarando el mesnaje de error que arroja
            Thread.Sleep(3000);
            String errorMsg = driver.FindElement(By.ClassName("alert-danger")).Text;
            TestContext.Progress.WriteLine(errorMsg);

            IWebElement link = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));
            //Va agarrar el atributo que se encuentra en el link en esta caso el href
            //y lo validar si es lo que se espera
            String hreflink = link.GetAttribute("href");
            String expectedUrl = "https://rahulshettyacademy.com/documents-request";
            //Assert es una función o clase que se usa en pruebas unitarias (unit tests) para verificar que un valor, condición o resultado sea el esperado.
            Assert.AreEqual(expectedUrl, hreflink);

        }

        [TearDown]
        public void CloseBrowser()
        {
            // Libera los recursos del driver
            if (driver != null)
            {
                driver.Quit();   // Cierra el navegador
                driver.Dispose(); // Libera recursos internos
            }
        }
    }

}
