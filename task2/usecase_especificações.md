# Especificação dos Use Cases

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
4. Sistema guarda a ficha do registo de empresa e envia-a para os Organizadores, para poderem validá-la

### Fluxo alternativo (1)[Falta de campos preenchidos](passo 3):
3.1 Sistema verifica que nem todos os campos foram preenchidos e salienta os campos que falta preencher
3.2 Utilizador preenche os campos em falta
3.3 Regressa a 3

---

## Consultar Carrinho

### Descrição:
- Utilizador pretende consultar todos os produtos que adicionou ao carrinho

### Cenários:
1. O Carlos queria consultar o carrinho, para ver quantos produtos tinha adicionado. Para isso ele clicou no icon do carrinho e reparou que tinha dois artigos que custavam 10 euros e um serviço. Também verificou que o custo total do cesto era de 20 euros e o tempo que cada artigo tem antes que volte a sair do carrinho.

### Mockups de referência:
- Carrinho de Compras

### Pré-condição:
- Utilizador autenticado

### Pós-condição:
- True

### Fluxo normal:
1. Utilizador clica no icon do carrinho de compras, presente em todas as páginas desde que esteja autenticado
2. Sistema calcula o preço de todos os produtos no carrinho do utilizador
3. Utilizador vê todos os produtos que tem no carrinho, o preço total de todos os produtos e, caso seja um artigo, o tempo que tem até sair do carrinho 

---

## Adição de Produto no Carrinho

### Descrição:
- Utilizador adiciona o produto pretendido ao carrinho

### Cenários:
1. O Gustavo estava a ver a banca da "Par de Solas", na feira "Expo Calçado e Materias", e viu uns pares de sapatos azuis que gostava de comprar para si e para o seu irmão, portanto clicou no produto e viu que estavam dois em stock, selecionou "2" na quantidade pretendida e clicou em "Adicionar ao carrinho", e, consequentemente, foi levado para a página do seu carrinho, agora com dois pares de sapatos azuis novos.
2. O Gustavo queria comprar dois pares de sapatos azuis mas só havia 1 em stock, mesmo assim selecionou "1" na quantidade pretendida e clicou em "Adicionar ao carrinho" resultando num aviso de adição impossibilitada.

### Mockups de referência:
- Banca de Feira
- Produto - vista utilizador

### Pré-condição:
- Utilizador autenticado e na página de uma banca de uma feira.

### Pós-condição:
- Novo produto adicionado ao carrinho do utilizador

### Fluxo normal:
1. Utilizador clica no produto do tipo artigo que pretende comprar
2. Utilizador seleciona a quantidade pretendida desse produto e clica no botão "Adicionar ao carrinho"
3. Sistema verifica que a quantidade pretendida é igual ou menor que a quantidade de stock desse produto
4. Sistema adiciona os produtos ao carrinho do utilizador, tirando-os de stock e reservando-os durante 30 minutos, tirando-os do carrinho e voltando a pô-los em stock se estes produtos não tiverem sido comprados durante esse espaço de tempo

### Fluxo alternativo(1)[Tipo de produto "Serviço"](passo 1):
1.1 Utilizador clica no produto do tipo serviço que pretende comprar
1.2 Utilizador clica no botão "Adicionar ao carrinho"
1.3 Sistema adiciona o produto ao carrinho do utilizador
1.4 Salta para 5

### Fluxo exceção(2)[Quantidade pretendida > quantidade de stock](passo 3):
3.1 Sistema verifica que a quantidade pretendida é maior que a quantidade de stock desse produto
3.2 Sistema cancela a adição do produto no carrinho do utilizador e mostra um aviso de adição impossibilitada

---

## Remoção de Produto no Carrinho

### Descrição:
- Utilizador pretende remover um produto no seu carrinho de compras

### Cenários:
1. O Vasco queria remover o serviço de pintar o seu carro, pois não achou mais que era uma boa ideia. Como tal, ele clicou no icon do carrinho e clicou em "Remover" no produto pretendido. A página deu reload e Vasco notou que já não estava lá o produto.

### Mockups de referência:
- Carrinho de Compras

### Pré-condição:
- Utilizador autenticado e na página do carrinho

### Pós-condição:
- Produto removido do carrinho de compras

### Fluxo normal:
1. Utilizador clica em "Remover" no produto que pretende remover do carrinho
2. Sistema remove o produto pretendido do carrinho de compras do utilizador e dá refresh à página

---

## Compra de Produtos

### Descrição:
- Utilizador pretende comprar todos os produtos que foi adicionando ao seu carrinho

### Cenários:
1. O Tiago decidiu comprar os produtos que tinha adicionado ao carrinho, então clicou no icon do carrinho de compras e verificou que tinha lá dois artigos e um serviço e que o preço dos produtos era de 100 euros e decidiu continuar com a compra clicando em "Validar Cesto". De seguida reparou que o custo da entrega, que é adicionado ao preço total, era de 10 euros, tornando o preço total a 110 euros e confirmando o pagamento clicando em "Pagar". Foi-lhe apresentado os detalhes da sua encomenda, e agora o Tiago está à espera que os comerciantes o contactem sobre o serviço e sobre a encomenda dos dois artigos.

### Mockups de referência:
- Carrinho de Compras
- Pagamento e expedição
- Confirmação de encomenda

### Pré-condição:
- Utilizador autenticado e na página do carrinho

### Pós-condição:
- Carrinho de compras vazio e os comerciantes, dos respetivos produtos comprados, notificados

### Fluxo normal:
1. Utilizador clica em "Validar o cesto"
2. Sistema notifica os comerciantes de todos os produtos do tipo serviço enviando-lhes mais uma encomenda no seu menu de encomendas
3. Sistema calcula o custo de entrega
4. Utilizador vê o custo dos produtos mais o custo de entrega e clica em "Pagar"
5. Sistema confirma o pagamento, enviando uma notificação aos comerciantes dos respetivos produtos para o seu menu de encomendas, e esvaziando o carrinho de compras do utilizador 

### Fluxo alternativo(1)[Cliente não tem morada registada]
4.1 Utilizador fornece morada
4.2 Sistema guarda a morada nos dados do utilizador
4.2 Regressa a 4

### Fluxo exceção(2)[Carrinho Vazio](passo 4):
4.1 Sistema verifica que o carro está vazio
4.2 Sistema avisa que o carro está vazio

---

## Visita Banca

### Descrição:
- Utilizador pretende aceder à sua banca pessoal

### Cenários:
1. O Carlos pretende consultar a sua banca pessoal, para ver os produtos que já tinha adicionado. Para isso, ele clicou no icon da banca e reparou que tinha 3 produtos do tipo artigo, onde dois estavam em stock e um sem.

### Mockups de referência:
- Produtos-comerciante

### Pré-condição:
- Utilizador autenticado

### Pós-condição:
- True

### Fluxo normal:
1. Utilizador clica no icon da banca, presente em todas as páginas desde que esteja autenticado
3. Utilizador vê todos seus produtos, se estão em stock ou não, e os seus tipos (artigo ou serviço)

---

## Adição de Produto à Banca

### Descrição:
- Utilizador adiciona um produto à sua banca pessoal

### Cenários:
1. 

### Mockups de referência:
- Produtos-comerciante
- Adição de um produto-comerciante

### Pré-condição:
- Utilizador autenticado e na página da banca pessoal

### Pós-condição:
- Novo produto adicionado à banca pessoal do utilizador

### Fluxo normal:
1. Utilizador clica em "Adicionar produto"
2. Utilizador carrega uma foto do produto, escreve um nome, uma descrição, seleciona o tipo do produto como "Artigo" e dá o preço e o stock do produto
3. Sistema verifica que todos os campos foram preenchidos
4. Sistema verifica que o preço está no formato de número e que não passa das duas casas decimais e que o stock está no formato de um número inteiro
5. Sistema adiciona o produto à banca pessoal do utilizador

### Fluxo alternativo(1)[Falta de campos preenchidos](passo 3):
3.1 Sistema verifica que nem todos os campos foram preenchidos e salienta os campos que falta preencher
3.2 Utilizador preenche os campos em falta
3.3 Regressa a 3

### Fluxo alternativo(2)[Formato de preço e stock errados](passo 4):
4.1 Sistema verifica que o preço não está no formato de número ou que passa das duas casas decimais ou que o stock está no formato de um número inteiro, salientado os campos que estiverem no formato errado
4.2 Utilizador preenche os campos de preço e de stock com o formato certo
4.3 Regressa a 4

### Fluxo alternativo(3)[tipo de produto como "Serviço"](passo 2):
2.1 Utilizador carrega uma foto do produto, escreve uma descrição e seleciona o tipo do produto como "Serviço"
2.2 Sistema verifica que todos os campos foram preenchidos
2.3 Salta para 5

### Fluxo alternativo(4)[Falta de campos preenchidos](passo 2.2):
2.2.1 Sistema verifica que nem todos os campos foram preenchidos e salienta os campos que falta preencher
2.2.2 Utilizador preenche os campos em falta
2.2.3 Regressa a 2.2

---

## Remoção de Produto à Banca

### Descrição:
- Utilizador remove um produto à sua banca pessoal

### Cenários:
1. 

### Mockups de referência:
- Produtos-comerciante

### Pré-condição:
- 

### Pós-condição:
- 

### Fluxo normal:
1.

---

## Envio de candidatura de participação

### Descrição:
- Utilizador pretende participar numa feira criando, assim, uma banca para a feira, podendo dar uma descrição para a banca e uma fotografia, e adicionar produtos da sua banca pessoal para a banca de feira

### Cenários:
1. 

### Mockups de referência:
- Feira por decorrer
- Candidatura a feira aka criação de banca - comerciante

### Pré-condição:
- Utilizador autenticado e na página de uma feira por decorrer

### Pós-condição:
- Nova ficha de candidatura de participação entregue para os Organizadores.

### Fluxo normal:
1. Utilizador clica no botão "Participar"
2. Utilizador escreve uma descrição de banca (opcional), fornece uma imagem (opcional) e seleciona os produtos da sua banca pessoal que pretende levar para a banca de feira
4. Sistema guarda a ficha de candidatura de participação e envia-a para os Organizadores, para poderem validá-la

---




