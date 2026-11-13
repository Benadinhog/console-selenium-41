using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace ConsoleSelenium.Tests
{
    [TestClass]
    [DoNotParallelize]
    public class WebFormularioDesafioTest
    {
        private IWebDriver driver = null!;
        private WebDriverWait wait = null!;

        [TestInitialize]
        public void Configurar()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            wait = new WebDriverWait(
                driver,
                TimeSpan.FromSeconds(10)
            );
        }

        [TestCleanup]
        public void Finalizar()
        {
            driver.Quit();
            driver.Dispose();
        }

        // EXERCICIO 1 - CADASTRO COMPLETO
        [TestMethod]
        public void Exercicio1_CadastroCompleto()
        {
            driver.Navigate().GoToUrl(
                "https://www.selenium.dev/selenium/web/web-form.html"
            );

            driver.FindElement(By.Name("my-text"))
                .SendKeys("Bernardo Luiz Monteverde Gonçalves");

            driver.FindElement(By.Name("my-password"))
                .SendKeys("Senha@123456");

            driver.FindElement(By.Name("my-textarea"))
                .SendKeys(
                    "Tenho conhecimentos em testes automatizados utilizando C#, Selenium e MSTest."
                );

            IWebElement campoReadonly =
                driver.FindElement(By.Name("my-readonly"));

            Assert.AreEqual(
                "Readonly input",
                campoReadonly.GetAttribute("value")
            );

            driver.FindElement(
                By.CssSelector("button[type='submit']")
            ).Click();

            bool mensagemRecebida = wait.Until(d =>
                d.FindElement(By.TagName("body"))
                 .Text.Contains("Received!")
            );

            Assert.IsTrue(mensagemRecebida);
        }

        // EXERCICIO 2 - DROPDOWNS E DATALIST
        [TestMethod]
        public void Exercicio2_DropdownsEDatalist()
        {
            driver.Navigate().GoToUrl(
                "https://www.selenium.dev/selenium/web/web-form.html"
            );

            IWebElement dropdownElemento =
                driver.FindElement(By.Name("my-select"));

            SelectElement dropdown =
                new SelectElement(dropdownElemento);

            dropdown.SelectByText("Two");

            Assert.AreEqual(
                "2",
                dropdown.SelectedOption.GetAttribute("value")
            );

            driver.FindElement(By.Name("my-datalist"))
                .SendKeys("Seattle");

            driver.FindElement(
                By.CssSelector("button[type='submit']")
            ).Click();

            bool formularioEnviado = wait.Until(d =>
                d.FindElement(By.TagName("body"))
                 .Text.Contains("Received!")
            );

            Assert.IsTrue(formularioEnviado);
        }

        // EXERCICIO 3 - CHECKBOXES, RADIOS E COLOR PICKER
        [TestMethod]
        public void Exercicio3_CheckboxesRadiosEColorPicker()
        {
            driver.Navigate().GoToUrl(
                "https://www.selenium.dev/selenium/web/web-form.html"
            );

            // Verificar os checkboxes
            var checkboxes = driver.FindElements(
                By.Name("my-check")
            );

            // Primeiro checkbox deve estar marcado
            Assert.IsTrue(checkboxes[0].Selected);

            // Marcar o segundo checkbox
            if (!checkboxes[1].Selected)
            {
                checkboxes[1].Click();
            }

            Assert.IsTrue(checkboxes[1].Selected);

            // Selecionar o segundo radio
            var radios = driver.FindElements(
                By.Name("my-radio")
            );

            radios[1].Click();

            Assert.IsTrue(radios[1].Selected);

            // Alterar a cor
            IWebElement colorPicker =
                driver.FindElement(By.Name("my-colors"));

            colorPicker.SendKeys("#ff0000");

            Assert.AreEqual(
                "#ff0000",
                colorPicker.GetDomProperty("value")
            );

            // Enviar formulário
            driver.FindElement(
                By.CssSelector("button[type='submit']")
            ).Click();

            bool formularioEnviado = wait.Until(d =>
                d.FindElement(By.TagName("body"))
                 .Text.Contains("Received!")
            );

            Assert.IsTrue(formularioEnviado);
        }
    }
}