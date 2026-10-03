# Sistema de Contatos

Aplicação web para cadastro e gerenciamento de contatos, desenvolvida com **ASP.NET Core MVC**, **.NET 9**, **C#**, **Entity Framework Core** e **SQL Server**.

## Funcionalidades

- Listagem de contatos cadastrados;
- Cadastro de novos contatos;
- Edição de contatos existentes;
- Exclusão de contatos com confirmação;
- Validação dos dados do formulário;
- Mensagens de sucesso e erro com fechamento por JavaScript;
- Persistência dos dados em SQL Server;
- Controle da estrutura do banco de dados com Entity Framework Core Migrations.

## Tecnologias utilizadas

- [.NET 9](https://dotnet.microsoft.com/);
- ASP.NET Core MVC;
- C# 13;
- Entity Framework Core 9;
- SQL Server;
- Razor Views;
- Bootstrap;
- HTML5, CSS3 e JavaScript;
- Git e GitHub.

## Pré-requisitos

Antes de executar o projeto, instale:

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0);
- SQL Server ou SQL Server Express;
- Visual Studio 2022/2026 com a carga de trabalho **ASP.NET e desenvolvimento Web**, ou outra IDE compatível.

## Como executar o projeto

1. Clone o repositório:

   ```bash
   git clone https://github.com/guxxp/Contact_systems_in_MVC.git
   ```

2. Acesse a pasta do projeto:

   ```bash
   cd "Contact systems in MVC"
   ```

3. Configure a conexão com o SQL Server no arquivo `appsettings.json`:

   ```json
   {
     "ConnectionStrings": {
       "DataBase": "Server=localhost;Database=DB_SistemaContatos;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```

   Altere o valor de `Server` conforme a instalação do SQL Server na sua máquina. Não publique credenciais reais no repositório.

4. Restaure as dependências:

   ```bash
   dotnet restore
   ```

5. Aplique as migrations no banco de dados:

   ```bash
   dotnet ef database update
   ```

   Caso o comando `dotnet ef` não esteja disponível, instale a ferramenta:

   ```bash
   dotnet tool install --global dotnet-ef
   ```

6. Execute a aplicação:

   ```bash
   dotnet run
   ```

   Alternativamente, abra o arquivo `.csproj` no Visual Studio e pressione `F5`.

## Estrutura do projeto

```text
Contact systems in MVC/
├── Controllers/
│   ├── ContatoController.cs
│   └── HomeController.cs
├── Data/
│   └── BancoContext.cs
├── Migrations/
│   └── Migrations do Entity Framework Core
├── Models/
│   ├── ContatoModel.cs
│   └── ErrorViewModel.cs
├── Repositorio/
│   ├── ContatoRepositorio.cs
│   └── IContatoRepositorio.cs
├── Views/
│   ├── Contato/
│   ├── Home/
│   └── Shared/
├── wwwroot/
│   ├── css/
│   └── js/
├── appsettings.json
├── Program.cs
└── Contact systems in MVC.csproj
```

## Banco de dados

O projeto utiliza o `BancoContext` para acessar a tabela de contatos no SQL Server. Para criar uma nova migration após alterar os modelos:

```bash
dotnet ef migrations add NomeDaMigration
dotnet ef database update
```

## Licença

Este projeto está disponível para fins de estudo e demonstração. Caso deseje utilizar o código em outro projeto, mantenha os créditos do repositório original.
