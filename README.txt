Siga os passos para rodar a aplicação. 

Tanto Front End Quanto Back foram desenvolvidos no Visual Studio 20223

1 - Ambos projetam devem rodar juntos, tanto a camada CDBCalculation.API e CDBCalculation.Presentation
2 - Deve estar instalado no Visual Studio Installer o pacote "Desenvolvimento em Node.js"
3 - Ainda com a ferramenta Visual Studio Installer aberta verificar se os pacotes abaixo estao instalados
     - Na sessao Asp.NET e desenvolvimento WEB - "Modelo de projetos e item do .NET Framework" 
     - Na sessao Asp.NET e desenvolvimento WEB - "Modelo de projetos adicionais (versoes anteriores) 
4 - Abrir a solucao no Visual Studio 2022, apos feito as intalacoes dos pacotes mencionados acima.
5 - Clicar com o botao direito do mouse na solution e clicar em Propriedades
6 - Selecionar "Varios projetos de instalacao"
7 - Escolher CDBCalculation.API = Iniciar  e  CDBCalculation.Presentation = Iniciar
8 - Clicar Ok
9 - Rodar Aplicacao

Ambos os projetos irão rodar em paralelo, verificar se a Api rodara na porta https://localhost:44348/,
caso na maquina aonde sera feito o teste essa porta estiver ocupada devera alterar no arquivo
Environment.ts do front end a nova porta da api. 

Obs: Foram Feito testes unitário utilizando FakeItEasy package e Xunit package, para roda-los
podera ser utilizado a o menu de testes do Visual Studio mesmo.
