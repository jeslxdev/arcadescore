# ArcadeScore

ArcadeScore é um front-end moderno em Angular para registrar e visualizar rankings de pontuação de jogadores, com visual inspirado em fliperamas e arquitetura MVVM, clean code e responsivo.

## Como rodar o projeto

### Pré-requisitos
- Node.js 18+
- Angular CLI (`npm install -g @angular/cli`)
- Backend .NET rodando em http://localhost:8080 (veja instruções no backend)

### Instalação

```bash
npm install
```

### Rodando o projeto

```bash
ng serve
```

Acesse: [http://localhost:4200](http://localhost:4200)

- O menu permite navegar entre Início, Ranking e Registrar Pontuação.
- O ranking mostra os 10 melhores jogadores.
- Clique no nome do jogador para ver estatísticas detalhadas em um modal.
- O formulário permite registrar pontuação informando nome, pontos e data.

## Boas práticas e arquitetura
- Angular Standalone Components (Angular 17+)
- MVVM, separação clara de responsabilidades
- Serviços para comunicação com API
- Responsivo e acessível
- Código limpo, tipado e comentado
- Animação de fundo arcade feita com CSS/JS, sem imagens externas

## Estrutura principal
- `src/app/features/ranking/` — Ranking de jogadores
- `src/app/features/register-score/` — Formulário de registro
- `src/app/shared/` — Serviços e DTOs
- `src/app/home.component.ts` — Tela inicial
- `src/app/app.ts` — Componente raiz, animação de fundo

---

Sinta-se à vontade para customizar o visual, adicionar novas features ou integrar com outros sistemas!
