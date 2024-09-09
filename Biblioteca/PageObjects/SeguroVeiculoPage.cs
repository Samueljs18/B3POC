using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using B3Poc.Biblioteca.Global;
using static B3Poc.Biblioteca.Global.Begin;


namespace B3Poc.Biblioteca.PageObjects
{
    public class SeguroVeiculoPage : BasePage
    {

        #region Combos

        public SelectElement ComboMake => new SelectElement(CampoMake());
        public SelectElement ComboModel => new SelectElement(CampoModel());
        public SelectElement ComboNumberOfSeats => new SelectElement(CampoNumberOfSeats());
        public SelectElement ComboNumberOfSeatsCycle => new SelectElement(CampoNumberOfSeatsCycle());
        public SelectElement ComboFuelType => new SelectElement(CampoFuelType());
        public SelectElement ComboCountry => new SelectElement(CampoCountry());
        public SelectElement ComboOccupation=> new SelectElement(CampoOccupation());
        public SelectElement ComboInsuranceSum => new SelectElement(CampoInsuranceSum());
        public SelectElement ComboMerit => new SelectElement(CampoMeritRating());
        public SelectElement ComboDamageInsurance => new SelectElement(CampoDamageInsurance());
        public SelectElement ComboCourtes => new SelectElement(CampoCourtesyCar());
        #endregion

        #region ElementosInterativosbotoesCampos
        public IWebElement CampoMake()
        {
            Esperar("//*[@id='make']");
            return ProcurarElementoPorXpath("//*[@id='make']");
        }
        public IWebElement CampoModel()
        {
            Esperar("//*[@id='model']");
            return ProcurarElementoPorXpath("//*[@id='model']");
        }
        public IWebElement CampoCylinderCapacity()
        {
            Esperar("//*[@id='cylindercapacity']");
            return ProcurarElementoPorXpath("//*[@id='cylindercapacity']");
        }

   
        public IWebElement CampoEnginePerfomance()
        {
            Esperar("//*[@id='engineperformance']");
            return ProcurarElementoPorXpath("//*[@id='engineperformance']");
        }
        public IWebElement CampoDateOfManufacture()
        {
            Esperar("//*[@id='dateofmanufacture']");
            return ProcurarElementoPorXpath("//*[@id='dateofmanufacture']");
        }
        public IWebElement CampoNumberOfSeats()
        {
            Esperar("//*[@id='numberofseats']");
            return ProcurarElementoPorXpath("//*[@id='numberofseats']");
        }        public IWebElement CampoNumberOfSeatsCycle()
        {
            Esperar("//*[@id='numberofseatsmotorcycle']");
            return ProcurarElementoPorXpath("//*[@id='numberofseatsmotorcycle']");
        }
        public IWebElement CampoFuelType()
        {
            Esperar("//*[@id='fuel']");
            return ProcurarElementoPorXpath("//*[@id='fuel']");
        }
        public IWebElement CampoTotalWeight()
        {
            Esperar("//*[@id='totalweight']");
            return ProcurarElementoPorXpath("//*[@id='totalweight']");
        }
        public IWebElement CampoPayload()
        {
            Esperar("//*[@id='payload']");
            return ProcurarElementoPorXpath("//*[@id='payload']");
        }
        public IWebElement CampoListPrice()
        {
            Esperar("//*[@id='listprice']");
            return ProcurarElementoPorXpath("//*[@id='listprice']");
        }
        public IWebElement CampoLicensePlateNumber()
        {
            Esperar("//*[@id='licenseplatenumber']");
            return ProcurarElementoPorXpath("//*[@id='licenseplatenumber']");
        }
        public IWebElement CampoAnualMileage()
        {
            Esperar("//*[@id='annualmileage']");
            return ProcurarElementoPorXpath("//*[@id='annualmileage']");
        }
        public IWebElement BotaoNext()
        {
            Esperar("//*[@id='nextenterinsurantdata']");
            return ProcurarElementoPorXpath("//*[@id='nextenterinsurantdata']");
        }
        public IWebElement BotaoNextSelectPrice()
        {
            Esperar("//*[@id='nextsendquote']");
            return ProcurarElementoPorXpath("//*[@id='nextsendquote']");
        }
        public IWebElement BotaoNextEnterInsurantData()
        {
            Esperar("//*[@id='nextenterproductdata']");
            return ProcurarElementoPorXpath("//*[@id='nextenterproductdata']");
        }
        public IWebElement BotaoNextEnterProductData()
        {
            Esperar("//*[@id='nextselectpriceoption']");
            return ProcurarElementoPorXpath("//*[@id='nextselectpriceoption']");
        }

        public IWebElement CampoFirstName()
        {
            Esperar("//*[@id='firstname']");
            return ProcurarElementoPorXpath("//*[@id='firstname']");
        }
        public IWebElement CampoLastName()
        {
            Esperar("//*[@id='lastname']");
            return ProcurarElementoPorXpath("//*[@id='lastname']");
        }
        public IWebElement CampoDateOfBirth()
        {
            Esperar("//*[@id='birthdate']");
            return ProcurarElementoPorXpath("//*[@id='birthdate']");
        }
        public IWebElement CheckboxGenderMale()
        {
            Esperar("//*[@id='gendermale']//following-sibling::span");
            return ProcurarElementoPorXpath("//*[@id='gendermale']//following-sibling::span");
        }
        public IWebElement CampoStreetAddress()
        {
            Esperar("//*[@id='streetaddress']");
            return ProcurarElementoPorXpath("//*[@id='streetaddress']");
        }
        public IWebElement CampoCountry()
        {
            Esperar("//*[@id='country']");
            return ProcurarElementoPorXpath("//*[@id='country']");
        }
        public IWebElement CampoZipCode()
        {
            Esperar("//*[@id='zipcode']");
            return ProcurarElementoPorXpath("//*[@id='zipcode']");
        }
        public IWebElement CampoCity()
        {
            Esperar("//*[@id='city']");
            return ProcurarElementoPorXpath("//*[@id='city']");
        }
        public IWebElement CampoOccupation()
        {
            Esperar("//*[@id='occupation']");
            return ProcurarElementoPorXpath("//*[@id='occupation']");
        }
        public IWebElement CheckboxHobbiesSpeeding()
        {
            Esperar("//*[@id='speeding']//following-sibling::span");
            return ProcurarElementoPorXpath("//*[@id='speeding']//following-sibling::span");
        }
        public IWebElement CampoWebiste()
        {
            Esperar("//*[@id='website']");
            return ProcurarElementoPorXpath("//*[@id='website']");
        }

        public IWebElement BotaoPrev()
        {
            Esperar("//*[@id='']");
            return ProcurarElementoPorXpath("//*[@id='']");
        }
        public IWebElement CampoStartDate()
        {
            Esperar("//*[@id='startdate']");
            return ProcurarElementoPorXpath("//*[@id='startdate']");
        }
        public IWebElement CampoAnexoPicture()
        {
            Esperar("//*[@id='firstname']");
            return ProcurarElementoPorXpath("//*[@id='picturecontainer']");
        }
        public IWebElement CampoInsuranceSum()
        {
            Esperar("//*[@id='insurancesum']");
            return ProcurarElementoPorXpath("//*[@id='insurancesum']");
        }
        public IWebElement CampoMeritRating()
        {
            Esperar("//*[@id='meritrating']");
            return ProcurarElementoPorXpath("//*[@id='meritrating']");
        }
        public IWebElement CampoDamageInsurance()
        {
            Esperar("//*[@id='damageinsurance']");
            return ProcurarElementoPorXpath("//*[@id='damageinsurance']");
        }
        public IWebElement CheckboxLegalDefenseInsurance()
        {
            Esperar("//*[@id='LegalDefenseInsurance']");
            return ProcurarElementoPorXpath("//*[@id='LegalDefenseInsurance']");
        }
        public IWebElement CheckboxEuroProtection()
        {
            Esperar("//*[@id='LegalDefenseInsurance']//following-sibling::span");
            return ProcurarElementoPorXpath("//*[@id='LegalDefenseInsurance']//following-sibling::span");
        }
        public IWebElement CheckboxYesRighhandDrive()
        {
            Esperar("//*[@id='righthanddriveyes']//following-sibling::span");
            return ProcurarElementoPorXpath("//*[@id='righthanddriveyes']//following-sibling::span");
        }
    

        public IWebElement CampoCourtesyCar()
        {
            Esperar("//*[@id='courtesycar']");
            return ProcurarElementoPorXpath("//*[@id='courtesycar']");
        }
        public IWebElement BotaoSelectPlatinum()
        {
            Esperar("//*[@id='selectplatinum']//following-sibling::span");
            return ProcurarElementoPorXpath("//*[@id='selectplatinum']//following-sibling::span");
        }
        public IWebElement CampoEmail()
        {
            Esperar("//*[@id='email']");
            return ProcurarElementoPorXpath("//*[@id='email']");
        }
        public IWebElement CampoPhone()
        {
            Esperar("//*[@id='phone']");
            return ProcurarElementoPorXpath("//*[@id='phone']");
        }
        public IWebElement CampoUserName()
        {
            Esperar("//*[@id='username']");
            return ProcurarElementoPorXpath("//*[@id='username']");
        }
        public IWebElement CampoPassword()
        {
            Esperar("//*[@id='password']");
            return ProcurarElementoPorXpath("//*[@id='password']");
        }
        public IWebElement CampoConfirmPassword()
        {
            Esperar("//*[@id='confirmpassword']");
            return ProcurarElementoPorXpath("//*[@id='confirmpassword']");
        }
        public IWebElement CampoComments()
        {
            Esperar("//*[@id='Comments']");
            return ProcurarElementoPorXpath("//*[@id='Comments']");
        }
        public IWebElement BotaoSend()
        {
            Esperar("//*[@id='sendemail']");
            return ProcurarElementoPorXpath("//*[@id='sendemail']");
        }

        public IWebElement BotaoOK()
        {
            Esperar("//button[.='OK']");
            return ProcurarElementoPorXpath("//button[.='OK']");
        }
        #endregion

        #region LogicasBooleanas
        public bool UsuarioEstaNaTelaEnterVehicleData()
        {
            Thread.Sleep(1000);
            return VerificarSeElementoExiste(By.XPath("//*[@id='make']"));
        }
        public bool UsuarioEstaNaTelaEnterInsurantData()
        {
            Thread.Sleep(1000);
            return VerificarSeElementoExiste(By.XPath("//*[@id='firstname']"));
        }
        public bool CampoModeloEstaPresenteNaTela()
        {
            Thread.Sleep(1000);
            return VerificarSeElementoExiste(By.XPath("//*[@id='model']"));
        }

        #endregion

    }
}
