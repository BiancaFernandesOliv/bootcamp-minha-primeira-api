# 💻 Minha Primeira API

Projeto desenvolvido durante o módulo de Desenvolvimento de APIs com ASP.NET Core do Bootcamp.

A aplicação foi construída de forma incremental ao longo das aulas, com o objetivo de praticar os principais conceitos relacionados ao desenvolvimento de APIs REST utilizando C# e .NET.

---

## 🎯 Objetivos

- Praticar os fundamentos do desenvolvimento de APIs com ASP.NET Core.
- Desenvolver endpoints utilizando controllers e rotas.
- Trabalhar com métodos HTTP e parâmetros de rota.
- Utilizar Entity Framework Core para persistência de dados.
- Compreender o funcionamento de requisições e respostas HTTP.
- Trabalhar com banco de dados SQLite.
- Evoluir progressivamente uma Web API durante o módulo.

---

## 📁 Estrutura

O projeto está organizado como uma aplicação ASP.NET Core Web API.

```text
MinhaPrimeiraApi/
├── Controllers/
│   └── ProdutosController.cs
├── Data/
│   └── AppDbContext.cs
├── Migrations/
├── Models/
│   └── Produto.cs
├── Repositories/
│   ├── IProdutoRepository.cs
│   └── ProdutoRepository.cs
├── Services/
│   ├── IProdutoService.cs
│   └── ProdutoService.cs
├── Properties/
│   └── launchSettings.json
├── Program.cs
├── appsettings.json
├── MinhaPrimeiraApi.csproj
└── minhaapi.db
```

A aplicação utiliza uma separação entre Controller, Service e Repository, enquanto a camada Data concentra o contexto do Entity Framework.

---

## 🏗️ Arquitetura

O projeto utiliza uma separação de responsabilidades entre as principais camadas:

- **Controller:** recebe e responde às requisições HTTP.
- **Service:** concentra as regras relacionadas aos produtos.
- **Repository:** realiza as operações de acesso aos dados.
- **Data:** contém o `AppDbContext`, responsável pela integração com o Entity Framework Core.
- **Models:** representa as entidades utilizadas pela aplicação.

---

## 📦 Produtos

A API possui um controller responsável pelo gerenciamento de produtos.

Os produtos são persistidos em um banco de dados SQLite utilizando Entity Framework Core.

### Endpoints disponíveis

| Método | Rota | Descrição |
|---|---|---|
| GET | `/api/produtos` | Lista todos os produtos |
| GET | `/api/produtos/{id}` | Busca um produto pelo ID |
| POST | `/api/produtos` | Cadastra um novo produto |
| PUT | `/api/produtos/{id}` | Atualiza um produto existente |
| DELETE | `/api/produtos/{id}` | Remove um produto |

---

## 🗄️ Banco de dados

A aplicação utiliza **SQLite** para persistência dos dados.

O acesso ao banco é realizado por meio do **Entity Framework Core**, utilizando:

- `DbContext`
- `DbSet`
- Migrations

---

## 🌐 Integração com Frontend

A API possui configuração de CORS para permitir requisições provenientes de uma aplicação Angular executada localmente em:

`http://localhost:4200`

---

## 🚀 Documentação da API

Durante a execução em ambiente de desenvolvimento, a API disponibiliza o Swagger para visualização e teste dos endpoints.

---

## 🚀 Tecnologias

- C#
- .NET
- ASP.NET Core
- Entity Framework Core
- SQLite
- REST API
- Swagger

---

## ▶️ Como executar

### Pré-requisitos

- .NET SDK
- Visual Studio ou outra IDE compatível com .NET

### Executando o projeto

Clone o repositório:

```bash
git clone https://github.com/BiancaFernandesOliv/bootcamp-minha-primeira-api.git
