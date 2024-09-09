#language:pt

Funcionalidade: Cadastro Veiculos
Como usuário Operacional,
Quero ter a possibilidade de informar todos os dados de um veiculo em um formulário
E Assim conseguir cadastrar um veiculo no sistema



Contexto: Acessar a Interface de Cadastro Dados de Veiculo
	Entao Acesso o Formulario

Cenário: Cadastro de Veiculo Com Sucesso
	Quando Preencho os Formulário de Enter Vehicle Data
	E Preencho os Formulario de Enter Insurant Data
	E Preencho os Formulario de Enter Product Data
	E Seleciono a opção de Preço
	E Preencho os Formulario de Send Quote
	E Clico Em Enviar
	Entao Valido o Cadastro de veiculo Com Sucesso

Cenário: Validação opcoes apresentadas do Combo Make
	Entao Valido que combo Make Tem Todas opcoes esperadas de Marcas

Cenário: Validar se Campo Make e obrigatório
	Quando Clico no Combo Make
	Entao Valido mensagem apresentada de Combo obrigatório

Cenário: Validar comportamento ao preencher Campo Engine Perfomance Com Valor Menor que um
	Quando Preencho Campo Engine Perfomance com Valor 0
	Entao Valido Mensagem apresentada de Limite dos campos

Cenário: Validar comportamento ao preencher Campo Engine Perfomance Com Valor Maior que 2000
	Quando Preencho Campo Engine Perfomance com Valor 2001
	Entao Valido Mensagem apresentada de Limite dos campos

Cenário: Validar comportamento ao preencher Campo Engine Perfomance Com Valor Positivo
	Quando Preencho Campo Engine Perfomance com Valor 2000
	Entao Valido Sistema Aceitando Preenchimento Valido

Cenário: Validar se sistema não aceita o preenchimento do Campo Date of Manufacture com uma data sem mascara
	Quando preencho o campo Date of Manufacture sem colocar uma mascara
	Entao Valido mensagem sendo apresentada pedindo data valida


Cenário: Validar se sistema não aceita o preenchimento do Campo Date of Manufacture com uma data futura
	Quando preencho o campo Date of Manufacture sem colocar uma mascara
	Entao Valido mensagem sendo apresentada pedindo data valida

Cenário: Validar se campo Date of Manufacture é Numérico
	Quando preencho o campo Date of Manufacture sem colocar uma mascara
	Entao Valido mensagem sendo apresentada pedindo data valida

Cenário: Validar se campo Date of Manufacture é obrigatório
	Quando Deixo o campo Date of Manufacture sem preenchimento
	Entao Valido mensagem dizendo que o campo é obrigatório


Cenario: Validar Se combo Fuel Type é obrigatório
	Quando Deixo sem preencher o combo Fuel Type
	Entao Valido mensagem apresentada para preencher campo Fuel Type


Cenario: Validar se Combo Fuel Type está com todas as opções corretas
	Entao Valido se combo Fuel Type está com todas as opcoes esperadas


Cenario: Validar se Campo List Price é obrigatório
	Quando Deixo sem preencher o combo List Price
	Entao Valido mensagem apresentada dizendo que campo List Price é obrigatório



Cenario: Validar valores limite do cammpo List Price
	Quando preencho campo List Price com <Valor>
	Entao Campo List Price deve <Resultado> Valor preenchido

Exemplos:
	| Valor  | Resultado   |
	| 499    | Nao Aceitar |
	| 100000 | Aceitar     |
	| 500    | Aceitar     |
	| 100001 | Nao Aceitar |


Cenario: Validar se Campo Annual Mileage é obrigatório
	Quando Deixo sem preencher o combo Annual Mileage
	Entao valido que sistema apresenta mensagem dizendo que campo Annual Mileage é obrigatório

Cenario: Validar valores limite do cammpo Annual Mileage
	Quando preencho campo Annual Mileage com <Valor>
	Entao Campo Annual Mileage  deve <Resultado> Valor preenchido
Exemplos:
	| Valor  | Resultado   |
	| 99     | Nao Aceitar |
	| 100000 | Aceitar     |
	| 100    | Aceitar     |
	| 100001 | Nao Aceitar |



Cenario: Anexo de Arquivo de forma valida no campo Picture
	Quando Preencho os Formulário de Enter Vehicle Data
	E efetuo o Anexo de um arquivo no Campo Picture
	Entao Valido Anexo feito com sucesso

Cenario: Validar se Campo Website nao aceita link invalido sem pontos
	Quando Preencho os Formulário de Enter Vehicle Data
	E preencho campo Website com <Valor>
	Entao Valido que Campo Website deve <Resultado> Valor Informado

Exemplos:
	| Valor      | Resultado   |
	| site       | Nao Aceitar |
	| site.teste | Aceitar     |
	| site.com   | Aceitar     |



Cenario: Validar se Checkbox hobbies é obrigatório
	Quando Preencho os Formulário de Enter Vehicle Data
	E Deixo sem preencher o Checkbox hobbies
	Entao Valido que sistema pede para selecionar pelo menos 1 opção de checkbox

Cenario: Validar se Campo Date of Birth tem validação para idades limites
	Quando Preencho os Formulário de Enter Vehicle Data
	Quando Preencho Campo Date of Birth com uma idade de <Idade> anos
	Entao Verifico que sistema deve <Resultado> Preenchimento
Exemplos:
	| Idade | Resultado   |
	| 17    | Nao Aceitar |
	| 18    | Aceitar     |
	| 70    | Nao Aceitar |
	| 71    | Nao Aceitar |

Cenario: Validar se Campo Start Date não aceita Data Retroativa
	Quando Preencho os Formulário de Enter Vehicle Data
	E Preencho os Formulario de Enter Insurant Data
	E Preencho campo Start Date com uma data retroativa
	Entao Verifico apresnetação de mensagem nao aceitando valor

Cenario: Validar se Campo Start Date não aceita Data menor que 1 Mês no futuro
	Quando Preencho os Formulário de Enter Vehicle Data
	E Preencho os Formulario de Enter Insurant Data
	E Preencho uma data futura Limite que não chega a 1 mês redondo
	Entao Verifico que sistema não permite usuário preencher campo Start date com data futura menor que um Mês

Cenario: Validar se Campo Email tem validação de formato de e-mail
	Quando Preencho os Formulário de Enter Vehicle Data
	E Preencho os Formulario de Enter Insurant Data
	E Preencho os Formulario de Enter Product Data
	E Seleciono a opção de Preço
	E preencho campo Email com <Valor>
	Entao Valido que Campo Email deve <Resultado> Valor Informado
Exemplos:
	| Valor           | Resultado   |
	| teste           | Nao Aceitar |
	| teste@teste     | Nao Aceitar |
	| teste@teste.com | Aceitar     |


Cenario: Validar se Campo Telefone é Numerico
	Quando Preencho os Formulário de Enter Vehicle Data
	E Preencho os Formulario de Enter Insurant Data
	E Preencho os Formulario de Enter Product Data
	E Seleciono a opção de Preço
	E Preencho Campo Telefone com Valor alfanumérico
	Entao Verifico que sistema informa que campo só aceita caracteres numéricos


Cenario: Validar Valores Limites do Campo Telefone
	Quando Preencho os Formulário de Enter Vehicle Data
	E Preencho os Formulario de Enter Insurant Data
	E Preencho os Formulario de Enter Product Data
	E Seleciono a opção de Preço
	E Preencho campo Telefone com <Telefone>
	Entao Valido que sistema deve <Resultado> Valor Informado
Exemplos:
	| Telefone         | Resultado   |
	| 1195845          | Nao Aceitar |
	| 20121070         | Aceitar     |
	| 119586936587412  | Aceitar     |
	| 1195869365874122 | Nao Aceitar |

Cenario: Validar Valores Limites Campo Nome
	Quando Preencho os Formulário de Enter Vehicle Data
	E Preencho os Formulario de Enter Insurant Data
	E Preencho os Formulario de Enter Product Data
	E Seleciono a opção de Preço
	E Preencho Campo Nome com valor <Nome>
	Entao Verifico que sistema deve <Resultado> Valor informado

Exemplos:
	| Nome                              | Resultado   |
	| Sam                               | Nao Aceitar |
	| Ravi                              | Aceitar     |
	| FernandaAMontenegro2Vasconcelos3S | Nao Aceitar |
	| FernandaAMontenegrosBVasconcelos  | Aceitar     |


