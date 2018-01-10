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

        [FindsBy(How = How.ClassName, Using = "ico-home")]
        public IWebElement IcoHomeTS { get; set; }

        [FindsBy(How = How.LinkText, Using = "¿Qué es TodoSuma?")]
        public IWebElement LinkQueEsTodoSuma { get; set; }

        [FindsBy(How = How.LinkText, Using = "¿Cómo acumular puntos?")]
        public IWebElement LinkComoAcumularPuntos { get; set; }

        [FindsBy(How = How.LinkText, Using = "¿Cómo canjear?")]
        public IWebElement LinkComoCanjear { get; set; }

        /// <summary>
        /// Preguntas Frecuentes
        /// </summary>
        
        [FindsBy(How = How.LinkText, Using = "Preguntas Frecuentes")]
        public IWebElement LinkPreguntasFrecuentes { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Cómo crear mi clave?:")]
        public IWebElement Pregunta1 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Si olvidé mi clave de acceso a todosuma.cl, ¿cómo puedo recuperarla?:")]
        public IWebElement Pregunta2 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Necesito inscribirme para participar del programa y acumular puntos")]
        public IWebElement Pregunta3 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "En el canje de puntos ¿Cuál es la equivalencia entre puntos y pesos?")]
        public IWebElement Pregunta4 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Cuántos puntos acumulan mis compras con tarjeta de crédito?:")]
        public IWebElement Pregunta5 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Qué valor de dólar se usa para convertir la compra internacional en pesos chilenos?:")]
        public IWebElement Pregunta6 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "En el canje de puntos ¿cuál es la equivalencia entre puntos y pesos? :")]
        public IWebElement Pregunta7 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Cuáles compras acumulan puntos? :")]
        public IWebElement Pregunta8 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Cuáles compras no acumulan puntos?: ")]
        public IWebElement Pregunta9 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "En caso de tener varias Tarjetas de Crédito, ¿todas acumulan puntos?: ")]
        public IWebElement Pregunta10 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Cuál de mis tarjetas me permiten inscribir  y realizar un canje?: ")]
        public IWebElement Pregunta11 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Acumulan puntos las Tarjetas de Crédito Adicionales?: ")]
        public IWebElement Pregunta12 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Por qué no se abona en mi cuenta el canje solicitado cuando la compra posterior es inferior al monto de puntos inscritos?: ")]
        public IWebElement Pregunta13 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Qué pasa con mis puntos cuando mi Tarjeta de Crédito está bloqueada?: ")]
        public IWebElement Pregunta14 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Qué pasa con mis puntos cuando mi Tarjeta de Crédito es cerrada?: ")]
        public IWebElement Pregunta15 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Qué pasa con mis puntos cuando pierdo o me roban mi Tarjeta de Crédito?: ")]
        public IWebElement Pregunta16 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Cuál es la vigencia de los puntos?: ")]
        public IWebElement Pregunta17 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Cuáles son los canales de atención disponibles para atender mis consultas relacionadas con TodoSuma?: ")]
        public IWebElement Pregunta18 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Cuáles son los comercios que pertenecen a cada rubro?:")]
        public IWebElement Pregunta19 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Qué pasa con mis puntos si tengo una deuda de mi tarjeta de crédito superior a los 75 días?")]
        public IWebElement Pregunta20 { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "¿Qué pasa con mis puntos si tengo una deuda de mi tarjeta de crédito superior a los 75 días?")]
        public IWebElement Pregunta21 { get; set; }

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

        /// <summary>
        /// Método que ingresa al ícono Home de TS
        /// </summary>
        
        public void IngresarIcoHomeTS()
        {
            System.Threading.Thread.Sleep(1400);

            IcoHomeTS.Click();
        }

        /// <summary>
        /// Método que ingresa al Link ¿Que es Todo Suma?
        /// </summary>
        public void IngresarLinkQueEsTodoSuma()
        {
            System.Threading.Thread.Sleep(1400);

            LinkQueEsTodoSuma.Click();
        }

        /// <summary>
        /// Método que ingresa al Link ¿Como Acumular Puntos?
        /// </summary>
        public void IngresarLinkComoAcumularPuntos()
        {
            System.Threading.Thread.Sleep(1400);

            LinkComoAcumularPuntos.Click();
        }

        /// <summary>
        /// Método que ingresa al Link ¿Como Canjear?
        /// </summary>

        public void IngresarLinkComoCanjear()
        {
            System.Threading.Thread.Sleep(1400);

            LinkComoCanjear.Click();
        }

        public void IngresarLinkPreguntasFrecuentes()
        {
            System.Threading.Thread.Sleep(1400);

            LinkPreguntasFrecuentes.Click();

            Pregunta1.Click();

            System.Threading.Thread.Sleep(1400);

            Pregunta2.Click();

            System.Threading.Thread.Sleep(1400);

            Pregunta3.Click();

            System.Threading.Thread.Sleep(1400);

            Pregunta4.Click();
        }

    }
}
