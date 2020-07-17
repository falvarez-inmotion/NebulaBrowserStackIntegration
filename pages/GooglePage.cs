using OpenQA.Selenium;
using System;

namespace NebulaAutomatedTestsProject.pages
{
    public class GooglePage
    {
        private IWebDriver Driver { get; }

        //Constructor
        public GooglePage(IWebDriver driver) => Driver = driver;

        //Property Expressions
        private IWebElement TxtBusquedaGoogle => Driver.FindElement(By.Name("q"));
        private IWebElement BtnBusquedaGoogle => Driver.FindElement(By.Name("btnK"));
        private IWebElement LnkInMotionSite => Driver.FindElement(By.CssSelector("h3.LC20lb"));

        //Behaviors
        public void SetTxtBusquedaGoogle(String patronBusqueda) => TxtBusquedaGoogle.SendKeys(patronBusqueda);
        public void ClickBtnBusquedaGoogle() => BtnBusquedaGoogle.Click();
        public void SetSendKeyEscape() => TxtBusquedaGoogle.SendKeys(Keys.Escape);
        public Boolean IsDisplayedLinkInMotion() => LnkInMotionSite.Displayed;

    }
}
