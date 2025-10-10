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

            //Implicit wait we can declare globally, si ponemos un implicit wait de 5 segundos se aplicara en todo el programa
            //vamos usar 5 segundos para esperar los elementos que aparezcan. driver.Manage().Timeouts en todos los metodos que
            //uses el driver se aplicar el tiempo Implicit
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //Explicit wait lo usas cuando un elemento espera mas del tiempo de lo normal y no puedes usar un implicit wait, por que
            //hay elementos que no duran mucho tiempo y otros si por que si usas implicit todos tienen que esperar ese mismo tiempo y es
            //mucho y consume mucho tiempo a la hora del test.


            driver.Manage().Window.Maximize();         
            driver.Url = "http://www.rahulshettyacademy.com/loginpagePractise/";     
        }


        [Test]
        public void LocatorsIdentification()
        {
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Name("password")).SendKeys("123456");

            //css selector .text-info span:nth-child(1) input se pone con espacions y se van por locator coloando desde el padre al hijo
            //para accesarlo, nth-child es para colocar la posicion del elemnto si hay varios igual a diferencia del xpah que es con[].

            //Checkbox del Aggre
            driver.FindElement(By.CssSelector(".text-info span:nth-child(1) input")).Click();

            IWebElement droppdown = driver.FindElement(By.CssSelector("select.form-control"));
            SelectElement drop = new SelectElement(droppdown);
            drop.SelectByText("Teacher");



            //xpath
            //driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click();
            //driver.FindElement(By.XPath("//div[@class='form-group'][3]/div/label[2]/span[2]"));

            //css selector & xpath
            //tagname [attribute='value']
            //driver.FindElement(By.CssSelector("input[value='Sign In']")).Click();
            driver.FindElement(By.XPath("//input[@id='signInBtn']")).Click();

            //agarando el mesnaje de error que arroja
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                TextToBePresentInElementValue(driver.FindElement(By.Id("signInBtn")), "Sign In"));

            String errorMsg = driver.FindElement(By.ClassName("alert-danger")).Text;
            TestContext.Progress.WriteLine(errorMsg);

            IWebElement link = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));

            //Va agarrar el atributo que se encuentra en el link en esta caso el href y lo validar si es lo que se espera
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
