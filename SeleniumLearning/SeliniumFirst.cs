using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
   public class SeleniumFirst
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            //Incializa el driver de chrome browser, las interfaces empiezan con la letra I para comunicar con el
            //chromedriver necesitamos el chromedriver.exe para hacer las acciones directo en el browser
            //WebDriverManager es un gestor de versiones de controladores y nos va ayudar a bajar la version
            //que tenemos actualmente en nuestro chrome sin estar bajando el webdriver cada vez que exista
            //una nueva version para el.
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            //Firefox and edge
            //driver = new FirefoxDriver();
            //driver = new EdgeDriver();

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1()
        {
            driver.Url = "http://www.rahulshettyacademy.com/loginpagePractise/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);

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
