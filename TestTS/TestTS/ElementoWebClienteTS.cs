﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTS
{
    class ElementoWebClienteTS
    {
        public ElementoWebClienteTS()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Canjear Puntos")]
        public IWebElement menuCanjearPuntos { get; set; }

        [FindsBy(How = How.LinkText, Using = "Estados de Inscripción")]
        public IWebElement menuEstadosInscripcion { get; set; }

        [FindsBy(How = How.LinkText, Using = "Resumen de Puntos por Período")]
        public IWebElement menuResumenPuntosPeriodo { get; set; }

        [FindsBy(How = How.LinkText, Using = "Cartola de Canje")]
        public IWebElement menuCartolaCanje { get; set; }

        [FindsBy(How = How.ClassName, Using = "volver_")]
        public IWebElement btnVolverOpcionCanjearPuntos { get; set; }

        public void IngresarCanjearPuntos()
        {
            System.Threading.Thread.Sleep(1400);

            menuCanjearPuntos.Click();

            System.Threading.Thread.Sleep(1400);

            btnVolverOpcionCanjearPuntos.Click();

            System.Threading.Thread.Sleep(2000);
        }

        public void IngresarEstadosInscripcion()
        {
            System.Threading.Thread.Sleep(1400);

            menuEstadosInscripcion.Click();

            System.Threading.Thread.Sleep(2000);
        }

        public void IngresarResumenPuntosPeriodo()
        {
            System.Threading.Thread.Sleep(1400);

            menuEstadosInscripcion.Click();

            System.Threading.Thread.Sleep(2000);
        }

        public void IngresarCartolaCanje()
        {
            System.Threading.Thread.Sleep(1400);

            menuCartolaCanje.Click();

            System.Threading.Thread.Sleep(1400);
        }

    }
}