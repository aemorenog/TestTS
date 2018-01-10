using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestTS
{
    class MainTest
    {
        string urlPrueba = "https://todosumacertificacion.ingesmart.cl/";

        static void Main(string[] args)
        {
        }

        [OneTimeSetUp]
        public void initialize()
        {
            //Usameos nuestra variable global webdriver y le asignamos que sea de tipo Chrome ()
            PropiedadColeccionDriver.driver = new ChromeDriver();

            //Maximizamos la pantalla que se abrira del navegador
            PropiedadColeccionDriver.driver.Manage().Window.Maximize();

            //string urlPrueba = "https://todosumacertificacion.ingesmart.cl/";

            //Indicamos a nuestro driver a que página ir (página inicial o primera carga)
            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);
        }

        [Test]
        public void TS001_LoginTS()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            ElementoWebClienteTS paginaBTX = new ElementoWebClienteTS();

            string rut = "100784289";

            string clave = "c123456";

            paginaBT.Login(rut, clave);

            paginaBTX.IngresarCanjearPuntos();

            paginaBTX.validarValoresComboPeso();

            //Debug.WriteLine("HOLA");

            //paginaBTX.IngresarEstadosInscripcion();

            //paginaBTX.IngresarResumenPuntosPeriodo();

            //paginaBTX.IngresarCartolaCanje();

        }

        [Test]
        public void TS001FAL_LoginTS()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            ElementoWebClienteTS paginaBTX = new ElementoWebClienteTS();

            string rut = "100784289";

            string clave = "";

            paginaBT.Login(rut, clave);

            System.Threading.Thread.Sleep(6000);

        }

        [Test]
        public void TS002_ValidarBtnComoCrearClave()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,450);", "");

            paginaBT.IngresaCrearTuclave();

            System.Threading.Thread.Sleep(1700);

            PropiedadColeccionDriver.driver.Navigate().Back();
        }

        [Test]
        public void TS003_ValidarBtnConsultaPuntosAcumulados()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,450);", "");

            paginaBT.IngresarConsultaPuntosAcumulados();

            System.Threading.Thread.Sleep(1700);

            PropiedadColeccionDriver.driver.Navigate().Back();
        }

        [Test]
        public void TS004_ValidarBtnUsaPuntosDondeTuQuieres()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,650);", "");

            paginaBT.IngresaUsaPuntosDondeTuQuieres();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);

        }

        [Test]
        public void TS005_ValidarBtnUsaPuntosEnBeneficiosTarjetas()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,650);", "");

            paginaBT.IngresaUsaPuntosEnBeneficiosTarjetas();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void TS006_ValidarIcoHomeTS()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            paginaBT.IngresarIcoHomeTS();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void TS007_ValidarLinkQueEsTodoSuma()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            paginaBT.IngresarLinkQueEsTodoSuma();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void TS008_ValidarLinkComoAcumularPuntos()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            paginaBT.IngresarLinkComoAcumularPuntos();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);

            PropiedadColeccionDriver.driver.Quit();
        }

        [Test]
        public void TS009_ValidarLinkComoCanjear()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            paginaBT.IngresarLinkComoCanjear();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);

            PropiedadColeccionDriver.driver.Quit();

        }

        [Test]
        public void TS010_ValidarLinkPreguntasFrecuentes()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            paginaBT.IngresarLinkPreguntasFrecuentes();

            System.Threading.Thread.Sleep(6000);

            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);

            PropiedadColeccionDriver.driver.Quit();
        }
    }
}
