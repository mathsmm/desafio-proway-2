# DESAFIO_Treinamento
## Descrição do projeto
 Neste repositório há uma API RESTful e um projeto Angular criados com o intuito de responder a um desafio de um processo seletivo.
 A API foi desenvolvida com a linguagem de programação C#, utilizando o editor de código-fonte Visual Studio Code. 
 Para a disponibilização dos dados foi utilizado o Framework ASP.NET Core.
 Para criar as requisições foi utilizada a ferramenta Postman, que tem como objetivo testar serviços de WEB APIs por meio do envio de requisições HTTP, sendo possível avaliar as respostas das requisições.

## Sumário
* [Critérios](#Critérios)
* [Como rodar a aplicação](#Como-rodar-a-aplicação)
* [Como rodar os testes unitários](#Como-rodar-os-testes-unitários)
* [Ideia das tabelas](#Ideia-das-tabelas)
* [Pacotes utilizados](#Pacotes-utilizados)
* [Comandos utilizados](#Comandos-utilizados)
* [Funcionamento da API](#Funcionamento-da-API)
    * [Efetuação das restrições](#Efetuação-das-restrições)
    * [Endpoints](#Endpoints)
        * [Student (Estudante)](#Student-Estudante)
        * [Template (Gabarito)](#Template-Gabarito)
        * [StudentReply (Resposta)](#StudentReply-Resposta)
        * [StudentGrade (Nota)](#StudentGrade-Nota)
        * [StudentSituation (Situação)](#StudentSituation-Situação)

## Critérios
 ### O Problema

 A ProWay vai realizar um treinamento para uma grande empresa de TI de Blumenau, especializada em softwares de gestão. O treinamento será realizado em 2 etapas e as pessoas serão divididas em salas com lotação variável. Serão realizados também dois intervalos de café em 2 espaços distintos. Você precisa criar o sistema que gerenciará este evento.

 ### O sistema precisa permitir:

- O cadastro de pessoas, com nome e sobrenome;
- O cadastro das salas do evento, com nome e lotação;
- O cadastro dos espaços de café pelo nome;
  
 A diferença de pessoas em cada sala deverá ser de no máximo 1 pessoa. Para estimular a troca de conhecimentos, metade das pessoas precisam trocar de sala entre as duas etapas do treinamento.
 Ao consultar uma pessoa cadastrada no treinamento, o sistema deverá retornar à sala em que a pessoa ficará em cada etapa e o espaço onde ela realizará cada intervalo de café.
 Ao consultar uma sala cadastrada ou um espaço de café, o sistema deverá retornar uma lista das pessoas que estarão naquela sala ou espaço em cada etapa do evento.

### Requisitos obrigatórios:

 Crie uma interface que permita: 

- O cadastro de pessoas, com nome e sobrenome;
- O cadastro das salas do evento, com nome e lotação;
- O cadastro dos espaços de café com lotação;
- A consulta de cada pessoa;
- A consulta de cada sala e espaço;

### Requisitos desejáveis:
- Persistência de dados;
- Testes unitários;

## Como rodar a aplicação

 Antes de tudo, é preciso ter o SQL Server, o .NET Framework e o .NET Core instalados em seu computador. A API utiliza esses serviços para funcionar e para gerenciar um banco de dados.
  
 Depois de baixar os programas necessários, é preciso configurar a conexão no diretório `BackEnd/Training_API/appsettings.json` e na chave "Connection", cujo valor será a string de conexão do banco de dados no SQL.
  
 Para executar a API através do Visual Studio Code, deve-se abrir o Terminal com a combinação de teclas `Ctrl + Shift + '` ou `Ctrl + '`, selecionar a pasta "Training_API" no diretório "BackEnd" com o comando `cd` e a tecla `TAB` e digitar os seguintes comandos:
 ```
 dotnet tool install --global dotnet-ef
 dotnet ef database update
 dotnet run
```
  
 Antes de iniciar o projeto do Angular, deve-se instalar o Node.js
  
 Após isso, no Visual Studio Code, necessita-se abrir outro Terminal, utilizar o comando `cd` e a tecla `TAB` para selecionar a pasta "Training" no diretório "FrontEnd" e digitar os seguintes comandos:
 ```
 npm install -g @angular/cli
 npm update
 npm start
 ```
  
 Após essas etapas, a API e o Angular estarão rodando ao mesmo tempo, e você poderá acessar o programa através do link `http://localhost:4200` em seu navegador.

## Como rodar os testes unitários
 Para desempenhar os testes unitários do diretório `BackEnd/UnitTesting/Calculation.tests` através do Visual Studio Code, basta abrir o Terminal com a combinação de teclas `Ctrl + Shift + '` ou `Ctrl + '`, selecionar a pasta "EscolaAlf_API" com o comando `cd` e a tecla `TAB` e digitar o seguinte comando:
 ```
 dotnet test
 ```

## Ideia das tabelas
 ![](FrontEnd/IMG/TablesExample.png)

## Pacotes utilizados
 BackEnd:
 - Microsoft.EntityFrameworkCore
 - Microsoft.EntityFrameworkCore.SqlServer
 - Microsoft.EntityFrameworkCore.Design
 - Microsoft.EntityFrameworkCore.Tools
 - Microsoft.EntityFrameworkCore.Analyzers
 - Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.7
 - NUnit --version 3.12.0  
  
 FrontEnd:
 - Bootstrap
 - NGX-Bootstrap
  
 Os pacotes do EntityFrameworkCore foram usados para desenvolver a API;  
 O pacote NewtonsoftJson foi empregado para impedir ciclos incessantes ao receber respostas da API;  
 O pacote NUnit foi utilizado para realizar testes unitários na classe de verificação de listas na API;
 Os pacotes do FrontEnd foram recorridos com o intuito de estilizar as páginas HTML.

## Funcionamento
 