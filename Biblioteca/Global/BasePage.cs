using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static B3Poc.Biblioteca.Global.Begin;
using EsperarCondicao = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace B3Poc.Biblioteca.Global
{
    public class BasePage
    {
        public WebDriverWait Wait { get; private set; }
        public IJavaScriptExecutor Js => (IJavaScriptExecutor)GetDriver();
        public IWebElement ProcurarElementoPorXpath(string Xpath) => GetDriver().FindElement(By.XPath(Xpath));

        public IWebElement ProcurarElementoPorID(string Elemento) => GetDriver().FindElement(By.Id(Elemento));

        public IWebElement ProcurarElemento(By Elemento) => GetDriver().FindElement(Elemento);

        public void Esperar(string Xpath, bool VerificarElementoClicavel = true, int TempoEspera = 30)
        {
            Wait = new WebDriverWait(GetDriver(), new TimeSpan(0, 0, TempoEspera));
            Wait.Until(EsperarCondicao.InvisibilityOfElementLocated(By.CssSelector(".load-interceptor")));
            Wait.Until(x => Js.ExecuteScript("return document.readyState").ToString() == "complete");
            Wait.Until(EsperarCondicao.InvisibilityOfElementLocated(By.CssSelector(".load-interceptor")));
            try
            {
                int contador = 1;
                while (contador < 10)
                {
                    if (VerificarSeElementoExiste(By.XPath(Xpath)))
                    { break; }
                    Thread.Sleep(500);
                    contador += 1;
                }
            }
            catch
            {
                Thread.Sleep(500);
            }
            if (!VerificarSeElementoEstaoculto(Xpath))
            {
                Wait.Until(EsperarCondicao.ElementExists(By.XPath(Xpath)));
                Wait.Until(EsperarCondicao.ElementIsVisible(By.XPath(Xpath)));
                if (ProcurarElementoPorXpath(Xpath).Enabled)
                {
                    Wait.Until(EsperarCondicao.ElementToBeClickable(By.XPath(Xpath)));
                }
            }

            Wait.Until(EsperarCondicao.InvisibilityOfElementLocated(By.CssSelector(".load-interceptor")));
        }
        public bool VerificarSeElementoExiste(By Elemento) { try { GetDriver().FindElement(Elemento); return true; } catch (NoSuchElementException) { return false; } }
        public bool VerificarSeElementoEstaoculto(string Elemento)
        {
            try { GetDriver().FindElement(By.XPath(Elemento)); return false; } catch (NoSuchElementException) { return true; }
        }
    }
}
