# Requisitos

## Requisitos do Utilizador

### Usuários

Um usuário é qualquer pessoa que utilize a plataforma.
Este pode adotar 3 papéis distintos:
- Visitante
- Cliente/Comerciante
- Organizador

### Visitantes

Considera-se um visitante qualquer **usuário não cadastrado** que utilize a plataforma.

Um visitante terá a capacidade de ver as feiras a decorrer no momento, as que já decorreram e as que estão por se realizar, mas não poderá ingressar nas mesmas.

### Clientes e Comerciantes

Um cliente trata-se de um **usuário cadastrado** que utiliza a plataforma com o intuito de **ingressar** em feiras, onde poderá **visitar bancas** e **adquirir produtos ou serviços**. Será alvo de **sugestões** de feiras dentro de mercados do seu interesse e notificado de feiras que tenha **seguido**.

O cadastro como cliente é gratuito, implicando apenas o registo do seu nome e email.
Poderá vir a ser necessário endereços de faturação e de envio mais para a frente (compra de produtos).

Um usuário **cliente pode tornar-se comerciante** através da sua área pessoal na plataforma. Neste caso deve indicar se se trata de um **vendedor individual** ou de uma **marca registada**. Após estar registado o seu papel como comerciante, este usuário terá acesso a uma área de vendedor onde pode consultar e gerir o seu stock, organizar a sua **banca** e categorizar o seu comércio através de **palavras-chave**.

*Objetivo secundário: Um comerciante poderá ser **verificado** por um gestor da plataforma como legítimo reunindo as condições para tal.*

## Requisitos do Sistema

### Feiras

Sendo todo o proṕosito da plataforma, as feiras tratam-se de eventos pontuais, i.e. que se realizam por um determinado período de tempo, onde se agregam comerciantes, sendo eles representantes de marcas registadas e/ou vendedores individuais, e que expõe os seus produtos ou serviços na sua **banca**.

Cada feira é apontada a um mercado específico, acarretando uma curadoria por parte dos organizadores das mesmas para garantir que uma feira se foca no nicho de mercado a que se compromete e não se generaliza para um mercado mais abrangente, dando ao visitante aquilo que ele pretende.

### Tipos de feiras

Será possível organizar:
- **Feiras informais** (onde apenas se aceita a participação de comerciantes individuais) 
- **Feiras corporativas** (onde se econtram apenas marcas registadas)
- **Feiras mistas** (onde se encontram ambas marcas registadas e individuais)

### Bancas

As bancas serão o meio de exposição dos comerciantes, consistindo numa página composta pelos mesmos, onde poderá incluir uma descrição do seu papel naquele mercado, dispor os produtos e serviços que este pretende vender ou publicitar e os seus contactos.

A disposição das bancas na página da feira será feita de forma igualitária para todos aqueles que não tenham qualquer tipo de **regalia**, podendo ser reordenada a cada visita à página da feira.

### Patrocinadores

Na organização de qualquer feira, poderá haver uma ou mais empresas a apoiar o evento, as quais beneficiarão de regalias durante o mesmo.

## Ações
(provavelmente enquadrar em requisitos funcionais tanto de utilizador como sistema)

- compra
- venda
- reserva de produtos em carrinho
- listagem de stock
- registo de stock
- ingressão em feiras
- candidatura à participação em feiras
- criação de feiras
- registo e autenticação
- registo como comerciante
- gestão de bancas
- vista por categorias
- vista de feiras passadas/presentes/futuras

## Ações 2.0

Vista do Visitante:
- Um visitante pode registar uma conta fornecendo ao sistema o seu nome, *username*, *password*, *email*.
- Um visitante pode visualizar o cartaz de feira.

Vista de Utilizador:

- Utilizador é capaz de autenticar-se com os dados da sua conta.
- Um utilizador pode visualizar o cartaz de feira.
- Um utilizador é capaz de visitar uma feira.
- Um utilizador é capaz de visitar uma banca.
- Um utilizador é capaz de adicionar produtos ao carrinho.
- Um utilizador consegue fazer a compra de produtos.

Vista do Sistema
- O sistema faz a reserva de produtos que se encontram no carrinho. (?) 
- O sistema deve ter a implementação de uma vista por categorias.
___________________________________________________________________________________________________________________
# Requisitos

## Requisitos de Utilizador:

### Funcionais:

-Um utilizador pode visualizar o cartaz de feira
-Um visitante pode:
  -registar uma conta fornecendo ao sistema o seu nome, username, password, email
  -autenticar-se com os dados da sua conta (username e password)
-Um utilizador autenticado pode: 
  -visitar uma feira
  -visitar uma banca
  -adicionar produtos ao carrinho
  -fazer a compra de produtos
-Um cliente pode fazer uma candidatura de comerciante
-Um comerciante pode:
  -adicionar produto á sua banca
  -fazer candidatura de participação
  -patrocinar evento
  -associar uma marca
 -Um organizador pode:
  -fazer a validação de candidaturas de comerciante
  -criar feiras informais, coorporativas e mistas
  -remover uma feira
  -validar um produto
  -beneficiar patrocinadores
  -fazer a validação de candidaturas de participação
  -fazer a validação da associação de marca
  
Nota: 
- **Feiras informais** (onde apenas se aceita a participação de comerciantes individuais) 
- **Feiras corporativas** (onde se econtram apenas marcas registadas)
- **Feiras mistas** (onde se encontram ambas marcas registadas e individuais)
  
### Não Funcionais:

  -O utilizador necessita de estar conectado à internet
  
## Requisitos de Sistema:

### Funcionais:

  -O sistema faz a reserva de produtos que se encontram no carrinho.
  -O sistema deve ser capaz de fazer uma listagem e registo de produtos em stock.
  -O sistema deve guardar os registos das contas, para poderem ser autenticadas.
  
### Não Funcionais:

  - O sistema deve ter a implementação de uma vista por categorias
  - O sistema deverá ter um processamento rápido e de curta resposta
  - A plataforma deve estar funcional todos os dias da semana, 24 horas por dia
  - A plataforma deverá ser acessível, com um layout simples e intuitivo
 
	-Desempenho
	-Usabilidade
	-Segurança
	-Disponibilidade
	-Manutenção
	-Confiabilidade
