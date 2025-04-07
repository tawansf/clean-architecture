
# 🧱 Clean Architecture - CQRS + MediatR

Este projeto é um boilerplate (whitelabel) baseado nos princípios da **Clean Architecture**, utilizando **CQRS** e o padrão **MediatR** para separação de responsabilidades e escalabilidade. Ideal para projetos que buscam um ponto de partida sólido e bem estruturado.

---

## 🚀 Tecnologias e Padrões Utilizados

- .NET 9
- Clean Architecture
- CQRS (Command Query Responsibility Segregation)
- MediatR
- Entity Framework Core
- FluentValidation
- Swagger
- SQLServer (pode ser substituído por outro SGBD como **Postgres**, **Oracle** ou **MySQL**)
- **EXTRA**: Autenticação com ASP.NET Identity
- Injeção de Dependência com o built-in do .NET

---

## 📁 Estrutura do Projeto

```
📦 CleanArchitecture
├── 📂 CleanArc.API             → Camada de apresentação (Controllers, Middlewares, etc.)
├── 📂 CleanArc.Application     → Camada de aplicação (CQRS: Commands, Queries, Handlers)
├── 📂 CleanArc.Domain          → Camada de domínio (Entidades, Interfaces, Enums, Validations)
├── 📂 CleanArc.Infrastructure  → Camada de infraestrutura (Repositórios, Persistência, Integrações)
├── 📂 CleanArc.Shared          → Recursos compartilhados entre camadas (helpers, constantes, exceções)
├── 📂 CleanArc.Tests           → Testes unitários e de integração
```

---

## ✨ Recursos Inclusos

- ✅ Estrutura modular e escalável
- ✅ Separação clara de responsabilidades
- ✅ Pronto para integração com qualquer banco de dados
- ✅ Padrão de mensagens de erro e sucesso centralizado
- ✅ Suporte a múltiplos ambientes (Development, Staging, Production)

---

## 🤝 Contribuições

Sinta-se livre para abrir uma issue ou um pull request.

