using B3Poc.Biblioteca.Global;
using System;
using TechTalk.SpecFlow;
using static B3Poc.Biblioteca.Global.Begin;

namespace B3POC.MainProject.StepDefinitions
{
    [Binding]
    public class CadastroVeiculosStepDefinitions : BaseTests
    {
        [Then(@"Acesso o Formulario")]
        public void ThenAcessoOFormulario()
        {
            GetDriver().Navigate().GoToUrl(Ambiente);
        }


        [Then(@"Valido que combo Make Tem Todas opcoes esperadas de Marcas")]
        public void ThenValidoQueComboMakeTemTodasOpcoesEsperadasDeMarcas()
        {
           
            ClicarElemento(ElementoDaCadastroVeiculo.CampoMake());
            VerificarCondicaoVerdadeira(CampoTipoTextoEstaComValorCorreto(ElementoDaCadastroVeiculo.CampoMake(), "                                            – please select –\r\n                                            Audi\r\n                                            BMW\r\n                                            Ford\r\n                                            Honda\r\n                                            Mazda\r\n                                            Mercedes Benz\r\n                                            Nissan\r\n                                            Opel\r\n                                            Porsche\r\n                                            Renault\r\n                                            Skoda\r\n                                            Suzuki\r\n                                            Toyota\r\n                                            Volkswagen\r\n                                            Volvo\r\n                                        "), "Teste combo Make tem todas opções esperadas", "Cadastro Veiculo");
            ClicarElemento(ElementoDaCadastroVeiculo.CampoMake());
        }
        [When(@"Clico no Combo Make")]
        public void WhenClicoNoComboMake()
        {
            ClicarElemento(ElementoDaCadastroVeiculo.CampoMake());
        }

        [Then(@"Valido mensagem apresentada de Combo obrigatório")]
        public void ThenValidoMensagemApresentadaDeComboObrigatorio()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='make']/following-sibling::span[.='Select an option']", "Select an option"), "Teste combo Make é obrigatório", "Cadastro Veiculo");

        }

        [When(@"Preencho Campo Engine Perfomance com Valor (.*)")]
        public void WhenPreenchoCampoEnginePerfomanceComValor(int Valor)
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoEnginePerfomance(), Valor.ToString());
        }

        [Then(@"Valido Mensagem apresentada de Limite dos campos")]
        public void ThenValidoMensagemApresentadaDeLimiteDosCampos()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='engineperformance']/following-sibling::span", "Must be a number between 1 and 2000"), "Teste Sistema apresenta mensagem para usuário preencher campo Engine Performance com valor entre 1 e 2000", "Cadastro Veiculo");
        }

        [Then(@"Valido Sistema Aceitando Preenchimento Valido")]
        public void ThenValidoSistemaAceitandoPreenchimentoValido()
        {
            VerificarCondicaoVerdadeira(MensagemDeValidacaoEstaOCulta("//*[@id='engineperformance']/following-sibling::span"), "Teste Sistema não apresenta nenhum erro e aceita preenchimento", "Cadastro Veiculo");
        }

        [When(@"preencho o campo Date of Manufacture sem colocar uma mascara")]
        public void WhenPreenchoOCampoDateOfManufactureSemColocarUmaMascara()
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoDateOfManufacture(), "06092025");
        }

        [Then(@"Valido mensagem sendo apresentada pedindo data valida")]
        public void ThenValidoMensagemSendoApresentadaPedindoDataValida()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='opendateofmanufacturecalender']/following-sibling::span", "Must be a valid date"), "Teste Campo Date of Manufacture só aceita data preenchida com mascara", "Cadastro Veiculo");
        }

        [When(@"Deixo o campo Date of Manufacture sem preenchimento")]
        public void WhenDeixoOCampoDateOfManufactureSemPreenchimento()
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoDateOfManufacture(), "");
        }

        [Then(@"Valido mensagem dizendo que o campo é obrigatório")]
        public void ThenValidoMensagemDizendoQueOCampoEObrigatorio()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='dateofmanufacture']/following-sibling::span", "This field is mandatory"), "Teste Campo Date of Manufacture é obrigatório", "Cadastro Veiculo");

        }

        [When(@"Preencho os Formulário de Enter Vehicle Data")]
        public void WhenPreenchoOsFormularioDeEnterVehicleData()
        {
            if (ElementoDaCadastroVeiculo.UsuarioEstaNaTelaEnterVehicleData())
            {
                ElementoDaCadastroVeiculo.ComboMake.SelectByIndex(NumeroAleatorio(12));
                if (ElementoDaCadastroVeiculo.CampoModeloEstaPresenteNaTela())
                {
                    ElementoDaCadastroVeiculo.ComboModel.SelectByIndex(NumeroAleatorio(4));
                    PreencherCampo(ElementoDaCadastroVeiculo.CampoCylinderCapacity(), "1000");
                    ElementoDaCadastroVeiculo.ComboNumberOfSeatsCycle.SelectByIndex(NumeroAleatorio(2));
                    PreencherCampo(ElementoDaCadastroVeiculo.CampoPayload(), "500");
                    ClicarElemento(ElementoDaCadastroVeiculo.CheckboxYesRighhandDrive());
                    PreencherCampo(ElementoDaCadastroVeiculo.CampoTotalWeight(), "2500");



                }
                PreencherCampo(ElementoDaCadastroVeiculo.CampoEnginePerfomance(), "2000");
                PreencherCampo(ElementoDaCadastroVeiculo.CampoDateOfManufacture(), "05/06/2024");
                ElementoDaCadastroVeiculo.ComboNumberOfSeats.SelectByIndex(NumeroAleatorio(8));
                ElementoDaCadastroVeiculo.ComboFuelType.SelectByIndex(NumeroAleatorio(4));
                PreencherCampo(ElementoDaCadastroVeiculo.CampoListPrice(), "1000");
                PreencherCampo(ElementoDaCadastroVeiculo.CampoLicensePlateNumber(), "ENY1E83");
                PreencherCampo(ElementoDaCadastroVeiculo.CampoAnualMileage(), "10000");
                ClicarElemento(ElementoDaCadastroVeiculo.BotaoNext());
            }
       

        }

        [When(@"Preencho os Formulario de Enter Insurant Data")]
        public void WhenPreenchoOsFormularioDeEnterInsurantData()
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoFirstName(), "Samuel");
            PreencherCampo(ElementoDaCadastroVeiculo.CampoLastName(), "Silva");
            PreencherCampo(ElementoDaCadastroVeiculo.CampoDateOfBirth(), "05/06/2000");
            ClicarElemento(ElementoDaCadastroVeiculo.CheckboxGenderMale());
            PreencherCampo(ElementoDaCadastroVeiculo.CampoStreetAddress(), "Rua Pedra das Maravilhas");
            ElementoDaCadastroVeiculo.ComboCountry.SelectByText("Brazil");
            PreencherCampo(ElementoDaCadastroVeiculo.CampoZipCode(), "08384758");
            PreencherCampo(ElementoDaCadastroVeiculo.CampoCity(), "São Fernando");
            ElementoDaCadastroVeiculo.ComboOccupation.SelectByText("Farmer");
            ClicarElemento(ElementoDaCadastroVeiculo.CheckboxHobbiesSpeeding());
            ClicarElemento(ElementoDaCadastroVeiculo.BotaoNextEnterInsurantData());
        }

        [When(@"Preencho os Formulario de Enter Product Data")]
        public void WhenPreenchoOsFormularioDeEnterProductData()
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoStartDate(), "06/09/2025");
            ElementoDaCadastroVeiculo.ComboInsuranceSum.SelectByIndex(NumeroAleatorio(4));
            ElementoDaCadastroVeiculo.ComboMerit.SelectByIndex(NumeroAleatorio(8));
            ElementoDaCadastroVeiculo.ComboDamageInsurance.SelectByText("Partial Coverage");
            ClicarElemento(ElementoDaCadastroVeiculo.CheckboxEuroProtection());
            ElementoDaCadastroVeiculo.ComboCourtes.SelectByText("Yes");
            ClicarElemento(ElementoDaCadastroVeiculo.BotaoNextEnterProductData());
        }

        [When(@"Seleciono a opção de Preço")]
        public void WhenSelecionoAOpcaoDePreco()
        {
            ClicarElemento(ElementoDaCadastroVeiculo.BotaoSelectPlatinum());
            ClicarElemento(ElementoDaCadastroVeiculo.BotaoNextSelectPrice());
        }

        [When(@"Preencho os Formulario de Send Quote")]
        public void WhenPreenchoOsFormularioDeSendQuote()
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoEmail(), "Samuel@Teste.com");
            PreencherCampo(ElementoDaCadastroVeiculo.CampoPhone(), "11970382569");
            PreencherCampo(ElementoDaCadastroVeiculo.CampoUserName(), "Samuel_B3");
            PreencherCampo(ElementoDaCadastroVeiculo.CampoPassword(), "Teste10%");
            PreencherCampo(ElementoDaCadastroVeiculo.CampoConfirmPassword(), "Teste10%");
        }

        [When(@"Clico Em Enviar")]
        public void WhenClicoEmEnviar()
        {
            ClicarElemento(ElementoDaCadastroVeiculo.BotaoSend());
        }

        [Then(@"Valido o Cadastro de veiculo Com Sucesso")]
        public void ThenValidoOCadastroDeVeiculoComSucesso()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//h2[.='Sending e-mail success!']", "Sending e-mail success!"), "Teste sistema apresenta mensagem de envio email enviado com sucesso", "Cadastro Veiculo");
        }

        [Then(@"Valido Combo Numero of Seats Com todas as opcoes esperadas")]
        public void ThenValidoComboNumeroOfSeatsComTodasAsOpcoesEsperadas()
        {
            ClicarElemento(ElementoDaCadastroVeiculo.CampoNumberOfSeats());
            VerificarCondicaoVerdadeira(CampoTipoTextoEstaComValorCorreto(ElementoDaCadastroVeiculo.CampoNumberOfSeats(), ""), "Teste combo Number of Seats tem todas opções esperadas", "Cadastro Veiculo");
        }

        [When(@"Deixo combo numero Number of Seats sem preenchimento")]
        public void WhenDeixoComboNumeroNumberOfSeatsSemPreenchimento()
        {
            ElementoDaCadastroVeiculo.ComboNumberOfSeats.SelectByIndex(1);
            ElementoDaCadastroVeiculo.ComboNumberOfSeats.SelectByIndex(0);
        }

        [Then(@"Valido mensagem de campo obrigatorio a ser preenchido")]
        public void ThenValidoMensagemDeCampoObrigatorioASerPreenchido()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='numberofseats']/following-sibling::span", "Select an option"), "Teste combo Number of Seats é obrigatório", "Cadastro Veiculo");

        }

        [When(@"Deixo sem preencher o combo Fuel Type")]
        public void WhenDeixoSemPreencherOComboFuelType()
        {
            ElementoDaCadastroVeiculo.ComboFuelType.SelectByIndex(1);
            ElementoDaCadastroVeiculo.ComboFuelType.SelectByIndex(0);
        }

        [Then(@"Valido mensagem apresentada para preencher campo Fuel Type")]
        public void ThenValidoMensagemApresentadaParaPreencherCampoFuelType()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='fuel']/following-sibling::span", "Select an option"), "Teste combo Fuel Type é obrigatório", "Cadastro Veiculo");

        }

        [Then(@"Valido se combo Fuel Type está com todas as opcoes esperadas")]
        public void ThenValidoSeComboFuelTypeEstaComTodasAsOpcoesEsperadas()
        {
            ClicarElemento(ElementoDaCadastroVeiculo.CampoFuelType());
            VerificarCondicaoVerdadeira(CampoTipoTextoEstaComValorCorreto(ElementoDaCadastroVeiculo.CampoFuelType(),"                                            – please select –\r\n                                            Petrol\r\n                                            Diesel\r\n                                            Electric Power\r\n                                            Gas\r\n                                            Other\r\n                                        "), "Teste combo Fuel Type tem todas opções esperadas", "Cadastro Veiculo");
        }

        [When(@"Deixo sem preencher o combo List Price")]
        public void WhenDeixoSemPreencherOComboListPrice()
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoListPrice(), "");

        }

        [Then(@"Valido mensagem apresentada dizendo que campo List Price é obrigatório")]
        public void ThenValidoMensagemApresentadaDizendoQueCampoListPriceEObrigatorio()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='listprice']/following-sibling::span", "This field is mandatory"), "Teste campo List Price é obrigatório", "Cadastro Veiculo");

        }

        [When(@"preencho campo List Price com (.*)")]
        public void WhenPreenchoCampoListPriceCom(string Valor)
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoListPrice(), Valor);
        }

        [Then(@"Campo List Price deve (.*) Valor preenchido")]
        public void ThenCampoListPriceDeveNaoAceitarValorPreenchido(string Resultado)
        {
            string ValorPreenchido = PegarValorDoCampo(ElementoDaCadastroVeiculo.CampoListPrice());
            switch (Resultado)
            {
                case "Nao Aceitar":
                    VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='listprice']/following-sibling::span", "Must be a number between 500 and 100000"), "Teste campo List Price Não Aceita Valor menor igual ou maior que " + ValorPreenchido, "Cadastro Veiculo");
                    break;
                case "Aceitar":
                    VerificarCondicaoVerdadeira(MensagemDeValidacaoEstaOCulta("//*[@id='listprice']/following-sibling::span"), "Teste campo List Price Aceita Valor " + ValorPreenchido, "Cadastro Veiculo");
                    break;
            }

        }

        [When(@"Deixo sem preencher o combo Annual Mileage")]
        public void WhenDeixoSemPreencherOComboAnnualMileage()
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoAnualMileage(), "");
        }

        [Then(@"valido que sistema apresenta mensagem dizendo que campo Annual Mileage é obrigatório")]
        public void ThenValidoQueSistemaApresentaMensagemDizendoQueCampoAnnualMileageEObrigatorio()
        {
            ClicarElemento(ElementoDaCadastroVeiculo.CampoAnualMileage());
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='annualmileage']/following-sibling::span", "This field is mandatory"), "Teste campo Annual Mileage é obrigatório", "Cadastro Veiculo");

        }

        [When(@"preencho campo Annual Mileage com (.*)")]
        public void WhenPreenchoCampoAnnualMileageComLValor(string Valor)
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoAnualMileage(), Valor);

        }

        [Then(@"Campo Annual Mileage  deve (.*) Valor preenchido")]
        public void ThenCampoAnnualMileageDeveNaoAceitarValorPreenchido(string Resultado)
        {
            string ValorPreenchido = PegarValorDoCampo(ElementoDaCadastroVeiculo.CampoAnualMileage());
            switch (Resultado)
            {
                case "Nao Aceitar":
                    VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='annualmileage']/following-sibling::span", "Must be a number between 100 and 100000"), "Teste campo Annual Mileage Não Aceita Valor menor igual ou maior que " + ValorPreenchido, "Cadastro Veiculo");
                    break;
                case "Aceitar":
                    VerificarCondicaoVerdadeira(MensagemDeValidacaoEstaOCulta("//*[@id='annualmileage']/following-sibling::span"), "Teste campo Annual Mileage Aceita Valor " + ValorPreenchido, "Cadastro Veiculo");
                    break;
            }
        }

        [When(@"efetuo o Anexo de um arquivo no Campo Picture")]
        public void WhenEfetuoOAnexoDeUmArquivoNoCampoPicture()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\net7.0\\","\\Biblioteca\\DataBase");
            string filePath = Path.Combine(projectDirectory, "Peugeot.png");
            PreencherCampo(ElementoDaCadastroVeiculo.CampoAnexoPicture(), filePath);
        }

        [Then(@"Valido Anexo feito com sucesso")]
        public void ThenValidoAnexoFeitoComSucesso()
        {
            VerificarCondicaoVerdadeira(PegarValorDoCampo(ElementoDaCadastroVeiculo.CampoAnexoPicture()).Equals("C:\\fakepath\\Peugeot.png"), "Teste sistema anexou arquivo corretamente no sistema", "Cadastro Veiculo");
        }

        [When(@"preencho campo Website com (.*)")]
        public void WhenPreenchoCampoWebsiteComSite(string Valor)
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoWebiste(), Valor);
        }

        [Then(@"Valido que Campo Website deve (.*) Valor Informado")]
        public void ThenValidoQueCampoWebsiteDeveNaoAceitarValorInformado(string Resultado)
        {
            string ValorPreenchido = PegarValorDoCampo(ElementoDaCadastroVeiculo.CampoWebiste());
            switch (Resultado)
            {
                case "Nao Aceitar":
                    VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='website']/following-sibling::span", "Must be a valid URL"), "Teste campo Webiste Não Aceita Valor invalido de site como: " + ValorPreenchido, "Cadastro Veiculo");
                    break;
                case "Aceitar":
                    VerificarCondicaoVerdadeira(MensagemDeValidacaoEstaOCulta("//*[@id='website']/following-sibling::span"), "Teste campo Webiste Aceita Valor valido como: " + ValorPreenchido, "Cadastro Veiculo");
                    break;
            }
        }

        [When(@"Deixo sem preencher o Checkbox hobbies")]
        public void WhenDeixoSemPreencherOCheckboxHobbies()
        {
            ClicarElemento(ElementoDaCadastroVeiculo.CheckboxHobbiesSpeeding());
            ClicarElemento(ElementoDaCadastroVeiculo.CheckboxHobbiesSpeeding());
        }

        [Then(@"Valido que sistema pede para selecionar pelo menos 1 opção de checkbox")]
        public void ThenValidoQueSistemaPedeParaSelecionarPeloMenosOpcaoDeCheckbox()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//span[.='Select at least 1 options']", "Select at least 1 options"), "Teste checkbox Hobbies é obrigatório sendo necessário preencher no minimo 1 opção", "Cadastro Veiculo");

        }

        [When(@"Preencho Campo Date of Birth com uma idade de (.*) anos")]
        public void WhenPreenchoCampoDateOfBirthComUmaIdadeDeAnos(int p0)
        {
            int Ano = DataAnoPassado.Year - p0;  //Removo 17 anos do ano vigente para pegar a data em que o usuário nasceu 
            string DataNascimento = DataAnoPassado.ToString("MM/dd/yyyy").Remove(6)+ Ano;
            PreencherCampo(ElementoDaCadastroVeiculo.CampoDateOfBirth(), DataNascimento);
        }

        [Then(@"Verifico que sistema deve (.*) Preenchimento")]
        public void ThenVerificoQueSistemaDeveNaoAceitarPreenchimento(string Resultado)
        {
            string ValorPreenchido = PegarValorDoCampo(ElementoDaCadastroVeiculo.CampoDateOfBirth());
            switch (Resultado)
            {
                case "Nao Aceitar":
                    VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='birthdate']/following-sibling::span", "You must be between 18 and 70 years of age"), "Teste campo Data Não Aceita Valor de data: " + ValorPreenchido.Replace("/",""), "Cadastro Veiculo");
                    break;
                case "Aceitar":
                    VerificarCondicaoVerdadeira(MensagemDeValidacaoEstaOCulta("//*[@id='birthdate']/following-sibling::span"), "Teste campo data Aceita Valor de data onde idade é maior ou igual a 18 ou menor igual a 70 " + ValorPreenchido.Replace("/", ""), "Cadastro Veiculo");
                    break;
            }
            ApagarCampo(ElementoDaCadastroVeiculo.CampoDateOfBirth());
        }

        [When(@"Preencho campo Start Date com uma data retroativa")]
        public void WhenPreenchoCampoStartDateComUmaDataRetroativa()
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoStartDate(), "05/13/2024");
        }

        [Then(@"Verifico apresnetação de mensagem nao aceitando valor")]
        public void ThenVerificoApresnetacaoDeMensagemNaoAceitandoValor()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//span[.='Must be more than one month in the future']", "Must be more than one month in the future"), "Teste Validar se Sistema não aceita preenchimento de data de inicio menor que a data presente", "Cadastro Veiculo");

        }

        [When(@"Preencho uma data futura Limite que não chega a 1 mês redondo")]
        public void WhenPreenchoUmaDataFuturaLimiteQueNaoChegaAMesRedondo()
        {
            var data = Data.AddDays(29);//pego uma data futura que nao seja 1 mes inteiro
            PreencherCampo(ElementoDaCadastroVeiculo.CampoStartDate(), data.ToString("MM/dd/yyyy"));
        }

        [Then(@"Verifico que sistema não permite usuário preencher campo Start date com data futura menor que um Mês")]
        public void ThenVerificoQueSistemaNaoPermiteUsuarioPreencherCampoStartDateComDataFuturaMenorQueMes()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//span[.='Must be more than one month in the future']", "Must be more than one month in the future"), "Teste Validar se Sistema não aceita preenchimento de data de inicio futura menor que 1 mês no futuro", "Cadastro Veiculo");
        }

        [When(@"preencho campo Email com (.*)")]
        public void WhenPreenchoCampoEmailComTeste(string Valor)
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoEmail(), Valor);
        }

        [Then(@"Valido que Campo Email deve (.*) Valor Informado")]
        public void ThenValidoQueCampoEmailDeveNaoAceitarValorInformado(string Resultado)
        {
            string ValorPreenchido = PegarValorDoCampo(ElementoDaCadastroVeiculo.CampoEmail());
            switch (Resultado)
            {
                case "Nao Aceitar":
                    VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='email']/following-sibling::span", "Must be at least a valid email format"), "Teste campo e-mail nao aceita valor invalido de email: " + ValorPreenchido, "Cadastro Veiculo");
                    break;
                case "Aceitar":
                    VerificarCondicaoVerdadeira(MensagemDeValidacaoEstaOCulta("//*[@id='email']/following-sibling::span"), "Teste campo Email está aceitando valor de email valido: " + ValorPreenchido, "Cadastro Veiculo");
                    break;
            }
        }

        [When(@"Preencho Campo Telefone com Valor alfanumérico")]
        public void WhenPreenchoCampoTelefoneComValorAlfanumerico()
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoPhone(), "ASAOHSOQUIHOI*!(@&!#¨$*@#¨$(*@&#");
        }

        [Then(@"Verifico que sistema informa que campo só aceita caracteres numéricos")]
        public void ThenVerificoQueSistemaInformaQueCampoSoAceitaCaracteresNumericos()
        {
            VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='phone']/following-sibling::span", "Must be only digits"), "Teste campo phone permite somente valor numerais", "Cadastro Veiculo");

        }

        [When(@"Preencho campo Telefone com (.*)")]
        public void WhenPreenchoCampoTelefoneCom(string Valor)
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoPhone(), Valor);

        }

        [Then(@"Valido que sistema deve (.*) Valor Informado")]
        public void ThenValidoQueSistemaDeveNaoAceitarValorInformado(string Resultado)
        {
            string ValorPreenchido = PegarValorDoCampo(ElementoDaCadastroVeiculo.CampoPhone());
            switch (Resultado)
            {
                case "Nao Aceitar":
                    VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='phone']/following-sibling::span", "Must be a number between 8 and 15 digits"), "Teste campo phone não aceita numero menor que 8 e maior que 15" + ValorPreenchido, "Cadastro Veiculo");
                    break;
                case "Aceitar":
                    VerificarCondicaoVerdadeira(MensagemDeValidacaoEstaOCulta("//*[@id='phone']/following-sibling::span"), "Teste campo phone está aceitando valores entre 8 e 15 caracteres" + ValorPreenchido, "Cadastro Veiculo");
                    break;
            }
        }

        [When(@"Preencho Campo Nome com valor (.*)")]
        public void WhenPreenchoCampoNomeComValorSam(string Valor)
        {
            PreencherCampo(ElementoDaCadastroVeiculo.CampoUserName(), Valor);

        }

        [Then(@"Verifico que sistema deve (.*) Valor informado")]
        public void ThenVerificoQueSistemaDeveNaoAceitarValorInformado(string Resultado)
        {
            string ValorPreenchido = PegarValorDoCampo(ElementoDaCadastroVeiculo.CampoUserName());
            switch (Resultado)
            {
                case "Nao Aceitar":
                    VerificarCondicaoVerdadeira(MensageriaApresentadaEstaDoElementoAcordoComOEsperado("//*[@id='username']/following-sibling::span", "Must be between 4 and 32 characters long and start with a letter. You may use letters, numbers, underscores, and one dot"), "Teste nome recusa valores informados que são menor que 4 digitos e maiores que 32" + ValorPreenchido, "Cadastro Veiculo");

                    break;
                case "Aceitar":
                    VerificarCondicaoVerdadeira(MensagemDeValidacaoEstaOCulta("//*[@id='username']/following-sibling::span"), "Teste campo username está aceitando valores entre 4 e 32 caracteres" + ValorPreenchido, "Cadastro Veiculo");
                    break;
            }


        }
    }
    }
