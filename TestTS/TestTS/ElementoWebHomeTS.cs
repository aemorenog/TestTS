using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTS
{
    class ElementoWebHomeTS
    {
        public ElementoWebHomeTS()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "rut")]
        public IWebElement txtRutCliente { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement txtContrasenaCliente { get; set; }

        [FindsBy(How = How.Id, Using = "logueo")]
        public IWebElement btnIngresar { get; set; }

        [FindsBy(How = How.Id, Using = "showPopup2")]
        public IWebElement LinkVerEjemplo { get; set; }

        [FindsBy(How = How.ClassName, Using = "close")]
        public IWebElement btnCerrarPopupVerEjemplo { get; set; }

        [FindsBy(How = How.Id, Using = "crear-clave")]
        public IWebElement LinkCrearClave { get; set; }

        [FindsBy(How = How.Id, Using = "crear-clave")]
        public IWebElement LinkRecuperarClave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='top']/body/div[1]/div/div[2]/div/div/div/div[2]/section[1]/div[1]/div[2]/a")]
        public IWebElement btnComoCrearTuClave { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='top']/body/div[1]/div/div[2]/div/div/div/div[2]/section[1]/div[2]/div[2]/a")]
        public IWebElement btnConsultaTusPuntosAcumulados { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='top']/body/div[1]/div/div[2]/div/div/div/div[2]/section[2]/div[1]/div[2]/a")]
        public IWebElement btnUsaPuntosDondeTuQuieras { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='top']/body/div[1]/div/div[2]/div/div/div/div[2]/section[2]/div[2]/div[2]/a")]
        public IWebElement btnUsaPuntosEnBeneficiosTarjetas { get; set; }


        /// <summary>
        /// Método que realiza validación de login de TS
        /// </summary>
        /// <param name="rut"></param>
        /// <param name="password"></param>

        public void Login(string rut, string password)
        {
            System.Threading.Thread.Sleep(1400);

            txtRutCliente.SendKeys(rut);

            System.Threading.Thread.Sleep(1400);

            txtContrasenaCliente.SendKeys(password);

            System.Threading.Thread.Sleep(1400);

            btnIngresar.Click();
        }

        /// <summary>
        ///  Método que ingresa a la opción ¿Como crear tu Clave?
        /// </summary>
        public void IngresaCrearTuclave()
        {
            System.Threading.Thread.Sleep(1400);

            btnComoCrearTuClave.Click();
        }

        /// <summary>
        ///  Método que ingresa a la opción Consulta tus puntos acumulados
        /// </summary>

        public void IngresarConsultaPuntosAcumulados()
        {
            System.Threading.Thread.Sleep(1400);

            btnConsultaTusPuntosAcumulados.Click();
        }

        /// <summary>
        ///  Método que ingresa a la opción Usa tus puntos donde tu quieras
        /// </summary>

        public void IngresaUsaPuntosDondeTuQuieres()
        {
            System.Threading.Thread.Sleep(1400);

            btnUsaPuntosDondeTuQuieras.Click();
        }

        /// <summary>
        ///  Método que ingresa a la opción Usa tus puntos en BeneficiosTarjetas.cl
        /// </summary>

        public void IngresaUsaPuntosEnBeneficiosTarjetas()
        {
            System.Threading.Thread.Sleep(1400);

            btnUsaPuntosEnBeneficiosTarjetas.Click();
        }

        
    }
}
