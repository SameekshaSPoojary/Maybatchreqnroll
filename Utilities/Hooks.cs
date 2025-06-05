using OpenQA.Selenium;

using OpenQA.Selenium.Edge;

using OpenQA.Selenium.Firefox;

using Reqnroll.Events;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using WebDriverManager.DriverConfigs.Impl;

namespace ReqnrollProject.Utilities

{

    [Binding]

    internal class Hooks

    {

        private readonly DriverContext _context;   //scenario contentext is

        public Hooks(DriverContext context)

        {

            _context = context;

        }

        [BeforeScenario]

        public void Setup()

        {

            Console.WriteLine("Running before every scenario");

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //IWebDriver driver = new FirefoxDriver();

            //_scenarioContext["WebDriver"] = driver;

            _context.Driver = new EdgeDriver();

            _context.Driver.Manage().Window.Maximize();

        }

        [AfterScenario]

        public void TearDown()

        {

            _context.Driver.Quit();

        }

        [BeforeTestRun]

        public static void BeforeTestRun()

        {

            Console.WriteLine("Running before test run");

        }

        [AfterTestRun]

        public static void AfterTestRun()

        {

            Console.WriteLine("Running after test run");

        }

        [BeforeStep]

        public static void BeforeStep()

        {

            Console.WriteLine("Running before step");

        }

        [AfterStep]

        public static void AfterStep()

        {

            Console.WriteLine("Runing after step");

        }

        [BeforeScenario]

        public void BeforeScenario()

        {

            Console.WriteLine("Running before scenario");

        }

        [AfterScenario]

        public void AfterScenario()

        {

            Console.WriteLine("Running after scenario");

        }

    }

}
