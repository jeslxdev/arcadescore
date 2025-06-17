# ArcadeScore - Projeto Full Stack

Este repositório contém dois projetos principais:

## 1. **arcadescore-api** (Back-end)
API desenvolvida em **.NET** (C#), responsável por:
- Gerenciar o registro de pontuações dos jogadores.
- Calcular estatísticas individuais (partidas jogadas, média, recordes, tempo jogado, etc).
- Disponibilizar endpoints REST para consulta de ranking e cadastro de pontuação.
- Utilizar repositório em memória (sem banco de dados) para facilitar testes e desenvolvimento.

**Principais tecnologias:**
- .NET 6+ (C#)
- ASP.NET Core Web API
- Swagger (documentação e testes)
- Clean Architecture, SOLID e boas práticas

**Melhorias recomendadas:**
- Implementação de autenticação JWT para proteger os endpoints.
- Dockerização para facilitar o deploy e execução em qualquer ambiente.
- Persistência em banco de dados relacional ou NoSQL.

---

## 2. **arcadescore-angular** (Front-end)
Aplicação web moderna desenvolvida em **Angular**, responsável por:
- Interface para registrar pontuação de jogadores.
- Visualização do ranking e estatísticas.
- Navegação intuitiva com menus para "Ranking" e "Registrar Pontuação".
- Layout responsivo e estilizado, seguindo boas práticas de MVVM e Clean Code.

**Principais tecnologias:**
- Angular 17+
- TypeScript
- Styled Components (para estilização moderna e componentizada)
- Consumo de API REST

---

## Como rodar os projetos

### Pré-requisitos
- [.NET 6+ SDK](https://dotnet.microsoft.com/download)
- [Node.js + npm](https://nodejs.org/) (para o front-end Angular)
- [Angular CLI](https://angular.io/cli) (opcional, mas recomendado)

### Rodando a API
```sh
cd arcadescore-api
dotnet restore
dotnet run
```

cd arcadescore-angular
npm install
ng serve

arcadescore-api/        # Projeto .NET (API)
arcadescore-angular/    # Projeto Angular (Front-end)
README.md               # Este arquivo
.gitignore