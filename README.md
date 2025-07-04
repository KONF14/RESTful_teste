# RESTful_teste
# API de Gestão de Pedidos - Estágio Backend C# (.NET)

Este projeto é uma API RESTful desenvolvida como parte de um teste técnico para vaga de estagiário backend C#. Ela permite o cadastro e gerenciamento de clientes, produtos e pedidos com boas práticas de programação e arquitetura.

---

##  Objetivo

Construir uma aplicação que:
- Cadastre clientes e produtos
- Crie pedidos associando clientes e múltiplos produtos
- Gerencie estoque e validações

---

##  Tecnologias Utilizadas

- ASP.NET Core Web API 6+
- C#
- Armazenamento: SQLite / InMemory
- Swagger para documentação
- DataAnnotations para validações
- xUnit/NUnit para testes

---

##  Funcionalidades

### Clientes
- Criar, listar, buscar e deletar

### Produtos
- Criar, listar, buscar e deletar
- Listar produtos com estoque baixo (bônus)

### Pedidos
- Criar e listar
- Associar múltiplos produtos por pedido
- Validar estoque e atualizar ao registrar pedido
- Filtrar pedidos por cliente (bônus)

---

## 🔄 Regras de Negócio

- Pedido deve conter ao menos um item
- Total do pedido = soma de itens
- Estoque do produto é reduzido ao realizar o pedido
- Pedido não pode ser criado se não houver estoque suficiente

---

##  Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/KONF14/RESTful_teste.git
