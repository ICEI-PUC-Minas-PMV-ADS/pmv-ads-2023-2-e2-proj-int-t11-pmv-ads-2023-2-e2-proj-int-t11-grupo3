# Especificações do Projeto

O projeto Outra Chance é uma ferramenta útil para ajudar os usuários a vender e/ou comprar itens de vestuários usados, facilitando o contato entre os interessados.  

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas nas Figuras que se seguem. 

![Persona1 1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-proj-int-t11-grupo3/assets/126190493/2fb42323-abbf-431a-8063-b9164d401294)

![Persona2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-proj-int-t11-grupo3/assets/126190493/c5b9ec42-87fe-438a-8826-231d7b466c51)

![Persona3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-proj-int-t11-grupo3/assets/126190493/32a4b002-00e3-454c-9529-4b8dc388177a)

![Persona4](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-proj-int-t11-grupo3/assets/126190493/2bd66e30-7559-47e4-8a3a-e88e77db135e)

![Persona5](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-proj-int-t11-grupo3/assets/126190493/a83adb01-219e-4239-8c6a-e3022ee4e1ba)

## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários:

|EU COMO... `PERSONA`|QUERO/DESEJO ... `O QUE`                                                                    |PARA ... `POR QUE`                                                                                          |
|--------------------|--------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------|
|Lilian Elizei       | uma fonte de renda extra                                                                   | para ajudar nas despesas de casa                                                                           |
|Lilian Elizei       | revender roupas                                                                            | conseguir uma renda extra                                                                                  |
|Joana Marques       | revender roupas sem tomar tanto tempo                                                      | para ajudar famílias carentes                                                                              | 
|Ana Pereira         | renovar seu guarda-roupa de forma fácil e ecconômica                                       | melhorar a autoestima                                                                                      |
|Ana Pereira         | vender roupas sem usa                                                                      | desapegar de itens que não combinam mais                                                                   |
|Carla Montenegro    | aumentar o faturamento do seu brechó                                                       | adquirir novas peças para renovação do estoque                                                             |
|Carla Montenegro    | encontrar uma plataforma de venda on line de vestuário usuado                              | encontrar maneiras mais eficazes para vender suas peças                                                    |
|Lucas Oliveira      | encontrar roupas que reflitam suas personalidade, mantendo um estilo de compra sustentável | encontrar roupas que encaixem no seu orçamento, mas mantendo uma boa qualidade                             |

   
## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID       | Descrição do Requisito                                                                                                                                                     | Prioridade |
|---------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
|RF-001   | A homepage da aplicação deverá apresentar uma lista de itens de vestuário disponíveis, com suas respectivas imagens e descrições.                                          | ALTA       | 
|RF-002   | Na homepage, logada ou não, deverá existir uma barra de busca que permitirá ao usuário filtrar os itens por categorias como tipo de vestuário, tamanho, cor, entre outros. | ALTA       |
|RF-003   | Usuários não registrados deverão ser capazes de visualizar os itens, mas para anunciar ou salvar itens, a criação de uma conta ou login será requerido.                    | ALTA       |
|RF-004   | Ao criar um anúncio, o usuário deverá fornecer informações como: descrição do item, imagem, tamanho, tipo de vestuário, condição (novo/usado), e dados de contato.         | ALTA       |
|RF-005   | Cada anúncio deve mostrar claramente o nome do vendedor, dados de contato, e a data em que o anúncio foi postado.                                                          | ALTA       |
|RF-006   | O usuário logado deverá ter um painel pessoal onde poderá visualizar seus anúncios ativos, itens salvos e gerenciar seus dados de perfil.                                  | MÉDIA      |
|RF-007   | No painel pessoal, o usuário deve ter a opção de marcar um item como vendido, o que irá remover o anúncio da lista principal, mas manter no histórico do usuário.          | ALTA       |
|RF-008   | O usuário deve poder salvar itens de interesse em sua conta para visualizar posteriormente sem a necessidade de buscá-los novamente na plataforma.                         | MÉDIA      |
|RF-009   | Ao visualizar um anúncio, o sistema apresentará sugestões de peças para o usuário advindas de anúncios pagos por empresas, baseando-se em categorias semelhantes.          | MÉDIA      |
|RF-010   | Os anúncios permitirão que usuários interajam por meio de comentários para que tirem dúvidas ou apenas expressem opiniões sobre as peças.                                  | BAIXA      |

### Requisitos não Funcionais

|ID        | Descrição do Requisito                                                                                                                                                    | Prioridade |
|----------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
|RNF-001   | O sistema deve ser responsivo para rodar em variados dispositivos.                                                                                                        | ALTA       | 
|RNF-002   | Garantir a privacidade e segurança dos dados dos usuários.                                                                                                                | ALTA       |
|RNF-003   | Deve processar requisições do usuário em no máximo 2s.                                                                                                                    | BAIXA      |
|RNF-004   | Fornecer uma interface amigável e intuitiva.                                                                                                                              | MÉDIA      |
|RNF-005   | Facilitar a integração com futuras atualizações.                                                                                                                          | BAIXA      |
|RNF-006   | O sistema deverá fornecer feedbacks de ações para o usuário, como confirmações ou erros durante a interação.                                                              | MÉDIA      |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                                                                                                                                                                      |
|--|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre.                                                                                                                                         |
|02| Deverá ser desenvolvido um módulo de backend e frontend.                                                                                                                                       |
|03| Não será possível realizar transações financeiras na plataforma.                                                                                                                               |


## Diagrama de Casos de Uso

![Diagrama de Uso - Outra Chance](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t11-pmv-ads-2023-2-e2-proj-int-t11-grupo3/assets/126190493/0ae734ca-bfd8-4bb0-bb6e-b754b5b8cd47)

