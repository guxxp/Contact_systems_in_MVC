# Sistemas de Contato em MVC

Aplicação web desenvolvida em **ASP.NET Core MVC** para gerenciamento de contatos, utilizando **C#**, **Entity Framework Core** e **SQL Server**.

## Tecnologias utilizadas

- C#
- .NET / ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Razor
- HTML5
- CSS
- Git e GitHub

## Funcionalidades

- Cadastro de contatos
- Listagem de contatos
- Edição de contatos
- Exclusão de contatos
- Confirmação antes da exclusão
- Persistência dos dados em banco de dados
- Migrations para controle da estrutura do banco

## Estrutura do projeto

```text
Sistemas de contato em MVC/
│
├── Controladores/
│   └── Controllers da aplicação
│
├── Dados/
│   └── Contexto do banco de dados
│
├── Migrações/
│   └── Migrations do Entity Framework Core
│
├── Modelos/
│   └── Entidades e modelos da aplicação
│
├── Propriedades/
│   └── Configurações do projeto
│
├── Repositório/
│   └── Implementação do acesso aos dados
│
├── Vistas/
│   └── Páginas Razor da aplicação
│
├── wwwroot/
│   └── Arquivos estáticos (CSS, JavaScript e imagens)
│
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
└── Sistemas de contato em MVC.csproj
