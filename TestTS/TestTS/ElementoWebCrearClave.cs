using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTS
{
    class ElementoWebCrearClave
    {
        public ElementoWebCrearClave()
        {
            PageFactory.InitElements(PropiedadColeccionDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "rut2")]
        public IWebElement txtRutClienteCrearClave { get; set; }

        [FindsBy(How = How.Id, Using = "n_serie")]
        public IWebElement txtNumeroSerie { get; set; }

    }
}
