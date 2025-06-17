# ArcadeScore API

API para registro e consulta de pontuações de jogadores em Arcade, seguindo Clean Architecture, SOLID e boas práticas.

## Pré-requisitos
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)

## Como rodar o projeto

1. **Abra o terminal na pasta do projeto:**
   ```
   cd arcadescore-api
   ```

2. **Restaure os pacotes:**
   ```
   dotnet restore
   ```

3. **Compile o projeto:**
   ```
   dotnet build
   ```

4. **Execute a API:**
   ```
   dotnet run
   ```

5. **Acesse a documentação Swagger:**
   - Abra o navegador em: [http://localhost:8080/swagger](http://localhost:8080/swagger)

## Estrutura principal
- `Domain/` - Entidades e contratos de domínio
- `Application/` - Interfaces de serviço
- `Infrastructure/` - Implementação do repositório em memória
- `API/DTOs/` - Objetos de transferência de dados
- `Controllers/` - Endpoints da API

## Observações
- Não é necessário banco de dados, os dados ficam em memória.
- Para reiniciar os dados, basta reiniciar a aplicação.

---
Se precisar de frontend Angular, veja a pasta `arcadescore-angular`.
