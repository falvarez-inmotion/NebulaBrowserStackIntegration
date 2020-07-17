using Microsoft.VisualStudio.TestTools.UnitTesting;
using NebulaAutomatedTestsProject.pages;
using NebulaAutomatedTestsProject.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NebulaAutomatedTestsProject.stepsDefinition
{
    [Binding]
    public class BusquedaGoogleSteps
    {
        private IWebDriver driver;

        GooglePage googlePage;

        [BeforeScenario]
        public void LaunchBrowser()
        {
            driver = Setup.LaunchBrowser();
        }

        [AfterScenario]
        public void TearDownBrowser()
        {
            Setup.TearDown();
        }

        public void InitPages()
        {
            googlePage = new GooglePage(driver);
        }

        [Given(@"Estoy en la pagina principal de Google")]
        public void GivenAbroElNavegador()
        {
            InitPages();
        }

        [When(@"Ingreso la (.*) en el buscador de Google")]
        public void GivenIngresoLaPalabraBuscadaEnElBuscadorDeGoogle(string PalabraBuscada)
        {
            googlePage.SetTxtBusquedaGoogle(PalabraBuscada);
        }

        [When(@"Presiono boton buscar")]
        public void WhenPresionoBotonBuscar()
        {
            googlePage.ClickBtnBusquedaGoogle();
        }

        [Then(@"Google muestra el resultado de la busqueda")]
        public void ThenGoogleMuestraElResultadoDeLaBusqueda()
        {
            Assert.IsTrue(googlePage.IsDisplayedLinkInMotion());
        }
    }
}