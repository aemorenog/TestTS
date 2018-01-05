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

namespace TestTS
{
    class MainTest
    {
        static void Main(string[] args)
        {
        }

        [OneTimeSetUp]
        public void initialize()
        {
            //Usameos nuestra variable global webdriver y le asignamos que sea de tipo Chrome ()
            PropiedadColeccionDriver.driver = new FirefoxDriver();

            //Maximizamos la pantalla que se abrira del navegador
            PropiedadColeccionDriver.driver.Manage().Window.Maximize();

            string urlPrueba = "https://todosumacertificacion.ingesmart.cl/";

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

            paginaBTX.IngresarEstadosInscripcion();

            paginaBTX.IngresarResumenPuntosPeriodo();

            paginaBTX.IngresarCartolaCanje();

        }
    }
}
