using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace B3Poc.Biblioteca.Global
{
    public class Begin
    {
        #region ConfiguraçãoDeVariaveis
        private static IWebDriver Driver;
        public static string PastaDosTeste = "";
        public static string Ambiente = "";
        public static int NumeroDaExecucao;
        static Random NumAleatorio => new Random();
        public static int ValorAleatorio => NumAleatorio.Next(1,10000);
        #endregion
                            
        [BeforeScenario]
        public static IWebDriver GetDriver()
        {
            Ambiente = "http://sampleapp.tricentis.com/101/app.php";
            if (Driver == null)
            {
                NumeroDaExecucao = ValorAleatorio;
                ChromeOptions Configuracoes = new ChromeOptions();
                Configuracoes.AddArguments("--lang=en-GB");
                Configuracoes.AddArguments("start-maximized");
                Driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), Configuracoes, TimeSpan.FromSeconds(120));
            }
            return Driver;
        }


        [AfterScenario]
        public void TearDown()
        {
            // Encerra o driver
            if (GetDriver() != null)
            {
                GetDriver().Quit();
            };
        }
    }
}
