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
        public void LoginBT()
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
        public void ValidarBtnComoCrearClave()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,450);", "");

            paginaBT.IngresaCrearTuclave();

            System.Threading.Thread.Sleep(1700);

            PropiedadColeccionDriver.driver.Navigate().Back();
        }

        [Test]
        public void ValidarBtnConsultaPuntosAcumulados()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,450);", "");

            paginaBT.IngresarConsultaPuntosAcumulados();

            System.Threading.Thread.Sleep(1700);

            PropiedadColeccionDriver.driver.Navigate().Back();
        }

        [Test]
        public void ValidarBtnUsaPuntosDondeTuQuieres()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,650);", "");

            paginaBT.IngresaUsaPuntosDondeTuQuieres();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);

        }

        [Test]
        public void ValidarBtnUsaPuntosEnBeneficiosTarjetas()
        {
            ElementoWebHomeTS paginaBT = new ElementoWebHomeTS();

            IJavaScriptExecutor js = PropiedadColeccionDriver.driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,650);", "");

            paginaBT.IngresaUsaPuntosEnBeneficiosTarjetas();

            System.Threading.Thread.Sleep(4000);

            PropiedadColeccionDriver.driver.Navigate().GoToUrl(urlPrueba);

        }
    }
}
