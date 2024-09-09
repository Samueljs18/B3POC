using B3Poc.Biblioteca.PageObjects;
using OpenQA.Selenium;
using static B3Poc.Biblioteca.Global.Begin;
using static B3Poc.Biblioteca.Global.GeradorDeRelatorio;

namespace B3Poc.Biblioteca.Global
{
    public class BaseTests : BasePage
    {
        #region InstanciacaoClassesPageObject
        public SeguroVeiculoPage ElementoDaCadastroVeiculo => new SeguroVeiculoPage();
        public GeradorDeRelatorio Gerar => new GeradorDeRelatorio();

        public DateTime Data => DateTime.Now;
        public TimeSpan timeSpan => TimeSpan.FromDays(364);
        public DateTime DataAnoPassado => Data - timeSpan;

        #endregion

        #region Funções Reutilizaveis



        public void RolarParaPosicaoDefinida(int Posicao) => Js.ExecuteScript("scroll(0, " + Posicao + ");");
        public void PreencherCampo(IWebElement Campo, string Valor)
        {
            Campo.SendKeys(Valor);
        }
        public void ApagarCampo(IWebElement Campo)
        {
            Campo.SendKeys(Keys.Control + "A");
            Campo.SendKeys(Keys.Backspace);
        }
        public void ClicarElemento(IWebElement Elemento)
        {
            Elemento.Click();
        }

        public void VerificarCondicaoVerdadeira(bool StatusDoTeste, string NomeDaVerificacao, string NomeDaEstoriaDeTeste = "", int QuantidadeDeTeste = 1)
        {
            int Verdadeiro = 0, Falso = 0;
            if (StatusDoTeste == true) { Verdadeiro = QuantidadeDeTeste; } else { Falso = QuantidadeDeTeste; }
            if (StatusDoTeste == true)
            {
                Assert.True(StatusDoTeste);
                GerarRelatorio(NomeDaVerificacao, StatusDoTeste, Verdadeiro, Falso, NomeDaEstoriaDeTeste + NumeroDaExecucao);
            }
            else { GerarRelatorio(NomeDaVerificacao, StatusDoTeste, Verdadeiro, Falso, NomeDaEstoriaDeTeste + NumeroDaExecucao); }
            CapturaTela(NomeDaVerificacao);
        }

        public bool CampoTipoTextoEstaComValorCorreto(IWebElement Campo, string Valor)
        {
            return Campo.Text.Equals(Valor);
        }

        public bool MensageriaApresentadaEstaDoElementoAcordoComOEsperado(string Xpath, string Valor)
        {
            Esperar(Xpath);
            return GetDriver().FindElement(By.XPath(Xpath)).Text.Equals(Valor);
        }
        public bool MensagemDeValidacaoEstaOCulta(string Xpath)
        {
            return GetDriver().FindElement(By.XPath(Xpath)).GetAttribute("style").Equals("display: none;");
        }
        public string PegarValorDoCampo(IWebElement Campo)
        {
            return Campo.GetAttribute("value");
        }
        public static void CapturaTela(string NomeDoArquivo)
        {
            string PastaDosTeste = Path.Combine(new FileInfo(typeof(GeradorDeRelatorio).Assembly.Location).DirectoryName, "Relatorios Testes Backoffice\\Relatorio " + NomeDaEstoriaTestadaAtualmente + " " + DataDoRelatorio);

            try
            {
                Screenshot ss = ((ITakesScreenshot)GetDriver()).GetScreenshot();
                ss.SaveAsFile(PastaDosTeste + "\\" + NomeDoArquivo + ".png");

            }
            catch (Exception e)
            {
                throw;
            }

        }

        public bool VerificarSeElementoEstaoculto(string Elemento)
        {
            try { GetDriver().FindElement(By.XPath(Elemento)); return false; } catch (NoSuchElementException) { return true; }
        }

        public bool VerificarSeElementoEstaExiste(string Elemento)
        {
            try { GetDriver().FindElement(By.XPath(Elemento)); return true; } catch (NoSuchElementException) { return false; }
        }

        static Random NumAleatorio => new Random();
        public int NumeroAleatorio(int NumeroLimite) => NumAleatorio.Next(1, NumeroLimite);
    }
    #endregion Funções Reutilizaveis


}
