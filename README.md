# 💻 Minha Primeira API

Projeto desenvolvido durante o módulo de APIs com ASP.NET Core do Bootcamp.

A aplicação está sendo construída de forma incremental ao longo das aulas, com o objetivo de praticar os principais conceitos relacionados ao desenvolvimento de APIs REST utilizando C# e .NET.

---

## 🎯 Objetivos

- Praticar os fundamentos do desenvolvimento de APIs com ASP.NET Core.
- Desenvolver endpoints utilizando controllers e rotas.
- Trabalhar com métodos HTTP e parâmetros de rota.
- Compreender o funcionamento de requisições e respostas HTTP.
- Evoluir progressivamente uma Web API durante o módulo.

---

## 📁 Estrutura

O projeto está organizado como uma aplicação ASP.NET Core Web API.

```text
MinhaPrimeiraApi/
├── Controllers/
├── Models/
├── Properties/
├── Program.cs
├── appsettings.json
└── MinhaPrimeiraApi.csproj
```
---

## 📦 Produtos

A API possui um controller para gerenciamento de produtos.

Atualmente, os produtos são mantidos em memória, sendo utilizados como contexto para praticar a construção dos endpoints e o tratamento das requisições.

### Endpoints disponíveis

| Método | Rota | Descrição |
|---|---|---|
| `GET` | `/api/produtos` | Lista todos os produtos |
| `GET` | `/api/produtos/{id}` | Busca um produto pelo ID |

---

## 🚀 Tecnologias

- C#
- .NET
- ASP.NET Core
- REST API
