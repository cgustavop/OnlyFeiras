# Especificação dos Use Cases

-É suposto selecionarmos algumas espeficações para fazermos bem, para mostrar na apresentação ao stor
-Eu que o use case "criação de feira" do ator "organizador" devia ser um deles

## Registo de Empresa

### Descrição:
- Utilizador preenche uma ficha, com os seus dados e os dados da sua Empresa, com o objetivo de associar a Empresa à sua conta.

### Cenários:
1. O Jorge pretende associar a sua empresa "Par de Solas" à sua conta do Onlyfeiras. Como tal, foi às definições da sua conta e clicou no botão "Faz o registo aqui". De seguida preencheu os dados que foram pedidos fornecendo primeiro as suas informações pessoais: o seu nome completo "Jorge Fernando Ramires Lencastre", o seu email "jorge@pardesolas.pt", a sua morada "Rua Moura Coutinho 63", o seu código-postal "4704-512", o seu telemóvel "920956755" e o seu cargo na empresa "CEO & Manager"; e depois os dados de empresa: o local "Rua de Caires 284", o nome de registo "Par de Solas", o número de contruibuinte "272443590", o código-postal "4704-502" e o número de telemóvel "289603101". Ao fim de ter preenchido todos os campos, Jorge clica em "Submeter" e recebe um aviso a dizer "O teu registo foi submetido com sucesso! Irás receber um email assim que este for aprovado".
2. O Jorge clicou em "Submeter" antes de ter preenchido o seu cargo na empresa, o que resultou do campo "cargo na empresa" ter ficado salientado, acabando o Jorge por preenhcer o seu cargo na empreasa e clicar "Submeter" recebendo um aviso a dizer "O teu registo foi submetido com sucesso! Irás receber um email assim que este for aprovado".

### Mockups de referência:
- Definições de conta - Usuário Cadastrado
- Registo Empresa - Usuário Cadastrado
- Confirmação Registo Empresa

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

---

## Adicionar de Produto ao Carrinho

### Descrição:
- Utilizador adiciona o produto pretendido ao carrinho

### Cenários:
1. O Gustavo estava a ver banca da "Par de Solas", na feira "Expo Calçado e Materias", e viu uns pares de sapatos azuis que gostava de comprar para si e para o seu irmão, portanto clicou no produto e viu que estavam dois em stock, portanto selecionou "2" na quantidade pretendida e clicou em "Adicionar ao carrinho", e, consequentemente, foi levado para a página do seu carrinho, agora com dois pares de sapatos azuis novos.
2. O Gustavo queria comprar dois pares de sapatos azuis mas só havia 1 em stock, mesmo assim selecionou "1" na quantidade pretendida e clicou em "Adicionar ao carrinho" resultando num aviso de adição impossibilitada.

### Mockups de referência:
- Banca - Vista Visitante
- Registo Empresa - Usuário Cadastrado
- Carrinho de Compras

### Pré-condição:
- Utilizador autenticado e na página de uma banca de uma feira.

### Pós-condição:
- Novo produto adicionado ao carrinho do utilizador

### Fluxo normal:
1. Utilizador clica no produto que pretende comprar
2. Utilizador seleciona a quantidade pretendida desse produto e clica no botão "Adicionar ao carrinho"
3. Sistema verifica que a quantidade pretendida é igual ou menor que a quantidade de stock desse produto
4. Sistema adiciona os produtos ao carrinho do utilizador, tira-os de stock e reservando-os durante 30 minutos, tirando-os do carrinho e voltando a pô-los em stock se estes produtos não tiverem sido comprados durante esse espaço de tempo
5. Sistema mostra o carrinho de compras do cliente já com os novos produtos adicionados

### Fluxo exceção (1)[Quantidade pretendida maior que a quantidade de stock](passo 3):
3.1 Sistema verifica que a quantidade pretendida é maior que a quantidade de stock desse produto
3.2 Sistema cancela a adição do produto no carrinho do utilizador e mostra um aviso de adição impossibilitada

---

## Compra de Produtos

### Descrição:
- Utilizador pretende comprar todos os produtos que foi adicionando ao seu carrinho

### Cenários:
1. O Tiago decidiu comprar os produtos que tinha adicionado ao carrinho, então clicou no icon do carrinho de compras e verificou que tinha lá dois artigos e dois um serviço e que o preço dos produtos era de 100 euros e decidiu continuar com a compra clicando em "Validar Cesto". De seguida reparou que o custo da entrega, que é adicionado ao preço total, era de 10 euros, tornando o preço total a 110 euros e confirmando o pagamento clicando em "Pagar". Foi-lhe apresentado os detalhes da sua encomenda, e agora o Tiago está à espera que os comerciantes o contactem sobre o serviço e sobre a encomenda dos dois artigos.

### Mockups de referência:
- Carrinho de Compras
- Pagamento e expedição
- Confirmação de encomenda

### Pré-condição:
- Utilizador autenticado

### Pós-condição:
- Carrinho de compras vazio e os comerciantes, dos respetivos produtos comprados, notificados

### Fluxo normal:
1. Utilizador clica no icon do carrinho de compras
2. Sistema calcula o preço de todos os produtos no carrinho do utilizador
3. Utilizador vê todos os produtos que tem no carrinho e o preço total de todos os produtos e clica em "Validar o cesto"
4. Sistema notifica os comerciantes de todos os produtos do tipo serviço enviando-lhes mais uma encomenda no seu menu de encomendas
5. Sistema calcula o custo de entrega
6. Utilizador vê o custo dos produtos mais o custo de entrega e clica em "Pagar"
7. Sistema confirma o pagamento, enviando uma notificação aos comerciantes dos respetivos produtos para o seu menu de encomendas, e esvaziando o carrinho de compras do utilizador 

### Fluxo exceção (1)[Carrinho Vazio](passo 4):
4.1 Sistema verifica que o carro está vazio
4.2 Sistema avisa que o carro está vazio

---




