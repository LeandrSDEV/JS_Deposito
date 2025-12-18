# 🥤 JSDeposito — Plataforma Completa para Depósito de Bebidas

Sistema completo para gestão e venda online de um depósito de bebidas, desenvolvido com Blazor Server + API em C#, seguindo Clean Architecture, com MySQL, autenticação segura e painel administrativo avançado.
O projeto foi pensado para ambiente de produção, priorizando manutenibilidade, segurança, escalabilidade e clareza arquitetural.

---

## 🚀 Stack Tecnológica
### Backend

- ASP.NET Core 8
- C#
- Clean Architecture
- Entity Framework Core
- MySQL (Pomelo Provider)
- JWT Authentication
- ASP.NET Core Identity

---

### Frontend

- Blazor Server
- MudBlazor (UI moderna e responsiva)
- JavaScript Interop (Maps e integrações externas)
- Infra / Utilitários
- ClosedXML (Exportação Excel formatada)
- QuestPDF (Geração de PDFs profissionais)
- Swagger / OpenAPI
- Google Maps / Mapbox API

---

## 🧱 Arquitetura

O projeto segue Clean Architecture, separando claramente responsabilidades e evitando acoplamento indevido.

      src/
      ├── JSDeposito.Domain
      │   ├── Entities
      │   ├── Enums
      │   └── ValueObjects
      │
      ├── JSDeposito.Application
      │   ├── DTOs
      │   ├── Interfaces
      │   ├── Services
      │   └── Validators
      │
      ├── JSDeposito.Infrastructure
      │   ├── Data
      │   ├── Repositories
      │   ├── Payments
      │   └── Reports
      │
      ├── JSDeposito.Api
      │   ├── Controllers
      │   ├── Auth
      │   └── Middlewares
      │
      └── JSDeposito.Blazor
          ├── Pages
          ├── Components
          ├── Layout
          ├── Services
          └── Admin

- Princípios aplicados
- Regras de negócio isoladas
- UI desacoplada do core
- Backend agnóstico de framework
- Facilidade para troca de frontend (React, Mobile, etc.)

---

## ✨ Funcionalidades
### 🛍️ Vitrine de Produtos

- Listagem de produtos disponíveis
- Exibição de preços atualizados
- Cálculo automático do valor total ao adicionar ao carrinho
- Atualização dinâmica do carrinho

---

### 🛒 Carrinho de Compras

- Adição e remoção de produtos
- Edição de quantidade em tempo real
- Recalculo automático do total
- Aplicação de cupons de desconto
- Validação de estoque no backend

---

### 👤 Autenticação e Perfis

- Login de Cliente e Administrador
- Autenticação via JWT
- Controle de acesso por roles
- Proteção de rotas (API e Blazor)

---

### 📍 Endereço e Frete Inteligente

- Cadastro de endereço de entrega
- Seleção via mapa interativo
- Cálculo automático da distância
- Precificação de frete baseada na rota:
- Até X km → valor fixo
- Acima → valor progressivo

---

### 💳 Pagamentos Online

- PIX
- Cartão de crédito
- Integração direta no site
- Processamento seguro no backend
- Webhooks para confirmação de pagamento

---

### 🎟️ Cupons de Desconto

- Criação e gerenciamento via painel admin
- Regras de validade e uso
- Aplicação direta no carrinho
- Histórico de utilização

---

### 📦 Gestão de Estoque

- Adição e retirada de produtos
- Controle automático após pedidos
- Visualização em tempo real

---

### 🧑‍💼 Painel Administrativo

- Dashboard completo e responsivo
- Visualização de:
- Produtos
- Pedidos
- Vendas
- Estoque
- Interface moderna com MudBlazor

---

### 📊 Relatórios e Exportações

Exportação de dados em:

- Excel (.xlsx) com:
- Cabeçalho formatado
- Moeda
- Datas
- AutoFilter
- PDF com layout profissional
- Relatórios de vendas e produtos

---

### 🔐 Segurança

- Autenticação JWT
- Proteção de rotas por role
- Validação server-side
- Separação clara entre áreas pública e administrativa
- Boas práticas de Identity Core

---

### ⚙️ Configuração do Ambiente
Pré-requisitos

- .NET SDK 8.0+
- MySQL 8+
- Visual Studio 2022+
- Node.js (para libs auxiliares, se necessário)
- Banco de Dados

Configure a connection string no appsettings.json:

      "ConnectionStrings": {
        "Default": "server=localhost;port=3306;database=jsdeposito;user=root;password=senha;"
      }

      Migrations
      Add-Migration InitialCreate -Project JSDeposito.Infrastructure -StartupProject JSDeposito.Api
      Update-Database

Executando o Projeto:

- Defina JSDeposito.Api como projeto de inicialização
- Execute a API
- Execute o JSDeposito.Blazor

Acesse:

- Vitrine: /
- Admin: /admin
- Swagger: /swagger

---

### 🧪 Padrões e Boas Práticas

- SOLID
- Clean Code
- DTOs para comunicação
- Repositórios desacoplados
- Serviços de domínio isolados
- Facilidade de testes e manutenção

---

### 📌 Status do Projeto

- 🚧 Em desenvolvimento contínuo
- 🔐 Pronto para ambiente de produção
- 📈 Escalável e extensível

---
