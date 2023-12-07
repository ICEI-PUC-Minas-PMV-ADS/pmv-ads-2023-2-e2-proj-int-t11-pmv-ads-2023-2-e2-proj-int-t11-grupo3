# Plano de Testes de Software
 
| **Caso de Teste** 	| **CT-01 – Ver anúncios na home** 	|
|:---:	|:---:	|
|	Requisito Associado 	| 	RF-001 - A homepage da aplicação deverá apresentar uma lista de itens de vestuário disponíveis, com suas respectivas imagens e descrições. |
| Objetivo do Teste 	| Ser possível observar uma série de anúncios na homepage da aplicação |
| Passos 	| - Acessar a aplicação |
|Critério de Êxito | - Ver anúncios com imagem e descrição |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Filtragem de anúncios**	|
|Requisito Associado | RF-002	- Na homepage, logada ou não, deverá existir filtros de busca que permitirão ao usuário filtrar os anúncios por categorias como tipo de vestuário, tamanho, cor, entre outros. |
| Objetivo do Teste 	| Ser capaz de filtrar anúncios |
| Passos 	| - Acessar a aplicação <br> - Escolher um dos filtros disponíveis na homepage - Filtrar os anúncios |
|Critério de Êxito | - Os anúncios foram filtrados de acordo com o filtro escolhido |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Pedido de login ao tentar cadastrar anúncio sem ter uma conta**	|
|Requisito Associado | RF-003	- Usuários não registrados deverão ser capazes de visualizar os itens, mas para anunciar em anúncios a criação de uma conta ou login será requerido. |
| Passos 	| - Acessar a aplicação sem estar logado<br> - Adentrar um anúncio<br> |
|Critério de Êxito | - Deve ser mostrado um modal sugerindo ao usuário fazer login ou criar uma conta para que possa criar um anúncio ou interagir com um. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Criação de anúncio com sucesso**	|
|Requisito Associado | RF-004	- Ao criar um anúncio, o usuário deverá fornecer informações do anúncio como valor, título, descrição, localidade, foto, tamanho, tipo de vestuário, condição (novo/usado), entre outros. |
| Objetivo do Teste 	| Permitir que o usuário crie um anúncio. |
| Passos 	| - Acessar a aplicação<br> - Fazer login<br> - Entrar na parte administrativa da conta<br> - Clicar em "Criar Anúncio"<br> - Preencher todas as informações necessárias<br> - Clicar no botão de criar anúncio<br> |
|Critério de Êxito | - O usuário é redirecionado para a homepage onde poderá ver o novo anúncio que criou |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Tentativa de criação de anúncio com erro de validação**	|
|Requisito Associado | RF-004	- Ao criar um anúncio, o usuário deverá fornecer informações do anúncio como valor, título, descrição, localidade, foto, tamanho, tipo de vestuário, condição (novo/usado), entre outros. |
| Objetivo do Teste 	| Não permitir que o usuário crie um anúncio sem preencher todos os campos. |
| Passos 	| - Acessar a aplicação<br> - Fazer login<br> - Entrar na parte administrativa da conta<br> - Clicar em "Criar Anúncio"<br> - Não preencher as informações necessárias<br> - Clicar no botão de criar anúncio<br> |
|Critério de Êxito | - Deve ser mostrado em vermelho os campos faltantes para criação do anúncio |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Anúncio estar completo**	|
|Requisito Associado | RF-005	- Cada anúncio deve mostrar claramente o nome do vendedor e dados de contato, além dos dados essenciais sobre aquele anúncio, de acordo com os informados na RF-004. |
| Objetivo do Teste 	| Verificar se o anúncio está com todas as informações necessárias |
| Passos 	| - Acessar a aplicação<br> - Fazer login<br> - Clicar em um dos anúncios disponíveis<br> |
|Critério de Êxito | - O anúncio terá todas as informações essenciais dele (como preço, titulo, descrição, tamanho, marca, etc), além dos dados de quem está anunciando, a fim de facilitar o contato para a venda. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Ver anúncios ativos no painel do usuário**	|
|Requisito Associado | RF-006	- O usuário logado deverá ter um painel pessoal onde poderá visualizar seus anúncios ativos. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar anúncios ativos no seu perfil|
| Passos 	| - Acessar a aplicação<br> - Fazer login<br> - Adentrar a área administrativa da conta<br> - Visualizar anúncios ativos se tiver. Senão, criar um anúncio para visualiza-lo<br> |
|Critério de Êxito | - O usuário poderá ver seus anúncios ativos assim como clicar neles e ver mais detalhes |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Ter botão de criação de anúncio no painel do usuário**	|
|Requisito Associado | RF-007	- O usuário logado deverá ter um painel pessoal onde poderá criar anúncios. |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar o botão para criação de anúncios na parte de seu perfil|
| Passos 	| - Acessar a aplicação<br> - Fazer login<br> - Adentrar a área administrativa da conta<br> - Visualizar o botão de criar anúncio<br> |
|Critério de Êxito | - O usuário deverá ver o botão de criar anúncio |
|  	|  	|
| **Caso de Teste** 	| **CT-09 – Alteração de dados cadastrais feito com sucesso**	|
|Requisito Associado | RF-008	- O usuário logado deverá ter um painel pessoal onde poderá gerenciar seus dados de perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue modificar as informações da sua conta|
| Passos 	| - Acessar a aplicação<br> - Fazer login<br> - Adentrar a área administrativa da conta<br> - Clicar no botão que permite alteração dos dados cadastrais<br> - Alterar um ou mais dados cadastrais<br> |
|Critério de Êxito | - O usuário deverá ter sucesso |
|  	|  	|
| **Caso de Teste** 	| **CT-10 – Alteração de dados cadastrais com erro**	|
|Requisito Associado | RF-008	- O usuário logado deverá ter um painel pessoal onde poderá gerenciar seus dados de perfil. |
| Objetivo do Teste 	| Não permitir o usuário modificar as informações da sua conta em caso de informação faltante |
| Passos 	| - Acessar a aplicação<br> - Fazer login<br> - Adentrar a área administrativa da conta<br> - Clicar no botão que permite alteração dos dados cadastrais<br> - Apagar algum dado obrigatório<br>- Clicar no botão que salva os novos dados<br> |
|Critério de Êxito | - O usuário deverá ver erro de validação pela falta de informação obrigatória no salvamento do formulário |
|  	|  	|
| **Caso de Teste** 	| **CT-11 – Alteração de dados cadastrais com erro**	|
|Requisito Associado | RF-009	- No painel pessoal, o usuário deve ter a opção de marcar um item como vendido, o que irá mover o anúncio da lista principal para uma lista específica de vendidos. |
| Objetivo do Teste 	| Verificar se um anúncio some da lista quando o usuário marca como vendido|
| Passos 	| - Acessar a aplicação<br> - Fazer login<br> - Adentrar a área administrativa da conta<br> - Clicar no botão que marca um anuncio como vendido<br> |
|Critério de Êxito | - O anúncio é movido para outra área do perfil do usuário |
|  	|  	|

