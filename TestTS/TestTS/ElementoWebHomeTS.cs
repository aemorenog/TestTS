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

        public void Login(string rut, string password)
        {
            System.Threading.Thread.Sleep(1400);

            txtRutCliente.SendKeys(rut);

            System.Threading.Thread.Sleep(1400);

            txtContrasenaCliente.SendKeys(password);

            System.Threading.Thread.Sleep(1400);

            btnIngresar.Click();
        }
    }
}
