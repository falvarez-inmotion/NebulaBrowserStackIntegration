using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace NebulaAutomatedTestsProject.utils
{
    class Setup
    {
        private static IWebDriver Driver;
        public static IWebDriver LaunchBrowser()
        {
            return DriverFactory();
        }

        public static void TearDown()
        {
            SetupTearDown();
        }
        private static IWebDriver SetupBrowser()
        {
            Driver = new ChromeDriver(@"C:\Users\Felipe Alvarez\source\repos\NebulaAutomatedTestsProject\resources\drivers");
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
            return Driver;
        }

        private static void SetupTearDown()
        {
            Driver.Quit();
        }

        [Obsolete]
        private static IWebDriver DriverFactory()
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("os_version", "10");
            capability.SetCapability("resolution", "1920x1080");
            capability.SetCapability("browser", "chrome");
            capability.SetCapability("browser_version", "84.0 beta");
            capability.SetCapability("os", "Windows");
            capability.SetCapability("browserstack.user", "falvarez1");
            capability.SetCapability("browserstack.key", "vRePmNsyRJKXcznVzCsD");
            Driver = new RemoteWebDriver(new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability);
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
            return Driver;
        }

    }
}