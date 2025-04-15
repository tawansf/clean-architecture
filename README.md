
# 🧱 Clean Architecture

Este projeto é um boilerplate (whitelabel) baseado nos princípios da **Clean Architecture**. Ideal para projetos que buscam um ponto de partida sólido e bem estruturado.

---

## 🚀 Tecnologias e Padrões Utilizados

- .NET 9
- Clean Architecture
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
├── 📂 CleanArc.API             → Camada de apresentação (Controllers, Middlewares, Filtros).
├── 📂 CleanArc.Application     → Casos de uso, DTOs, interfaces de serviços de aplicação.
├── 📂 CleanArc.Domain          → Entidades, ValueObjects, Interfaces, Enums, Validações.
├── 📂 CleanArc.Infrastructure  → Implementações de repositórios, serviços externos, persistência.
├── 📂 CleanArc.Shared          → Helpers, constantes, exceções e base classes reutilizáveis.
├── 📂 CleanArc.Tests           → Testes unitários e testes de integração.
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

Sinta-se livre para abrir uma issue ou um pull request 🙏

