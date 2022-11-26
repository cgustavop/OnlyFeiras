# Especificação dos Use Cases

-É suposto selecionarmos algumas espeficações para fazermos bem, para mostrar na apresentação ao stor
-Eu que o use case "criação de feira" do ator "organizador" devia ser um deles

## Registo de Empresa

### Descrição:
- Utilizador preenche uma ficha, com os seus dados e os dados da sua Empresa, com o objetivo de associar a Empresa à sua conta.

### Cenários:
1. O Jorge pretende associar a sua empresa "Par de Solas" à sua conta do Onlyfeiras. Como tal, foi às definições da sua conta e clicou no botão "Faz o registo aqui". De seguida preencheu os dados que foram pedidos fornecendo primeiro as suas informações pessoais: o seu nome completo "Jorge Fernando Ramires Lencastre", o seu email "jorge@pardesolas.pt", a sua morada "Rua Moura Coutinho 63", o seu código-postal "4704-512", o seu telemóvel "920956755" e o seu cargo na empresa "CEO & Manager"; e depois os dados de empresa: o local "Rua de Caires 284", o nome de registo "Par de Solas", o número de contruibuinte "272443590", o código-postal "4704-502" e o número de telemóvel "289603101". Ao fim de ter preenchido todos os campos, Jorge clica em "Submeter" e recebe um aviso a dizer "O teu registo foi submetido com sucesso! Irás receber um email assim que este for aprovado".

### Pré-condição:
- Utilizador autenticado e na página de "definições do utilizador"

### Pós-condição:
- Nova ficha de registo de empresa entregue para os Organizadores.

### Fluxo normal:
1. Utilizador clica no botão "Faz o registo aqui"
2. Utilizador fornece na secção de "Informações pessoais do representante" o seu nome completo, o seu email, a sua morada, o seu código-postal, o seu telemóvel e o cargo que exerce na empresa. Fornece na secção de "Dados de empresa" o local, o nome de registo, o numero de contribuinte, o código-postal e o telemóvel da empresa e clica em "Submeter"
3. Sistema verifica que todos os campos foram preenchidos e avisa o utilizador que o seu registo de empresa foi recebido com sucesso e que irá receber um email assim que esteja aprovado
4. Sistema guarda a ficha do registo de empresa e envia para os Organizadores, para poderem validá-la

### Fluxo alternativo (1)[Falta de campos preenchidos](passo 3):
3.1 Sistema verifica que nem todos os campos foram preenchidos e salienta os campos que falta preencher
3.2 Utilizador preenche os campos em falta
3.3 Regressa a 3
