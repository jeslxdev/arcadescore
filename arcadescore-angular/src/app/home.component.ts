import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RouterModule],
  template: `
    <div class="home-container">
      <h1>Bem-vindo ao ArcadeScore!</h1>
      <div class="home-menu">
        <a routerLink="/ranking" class="home-btn">Ver Ranking</a>
        <a routerLink="/registrar" class="home-btn">Registrar Pontuação</a>
      </div>
    </div>
  `,
  styles: [`
    .home-container {
      display: flex;
      flex-direction: column;
      align-items: center;
      justify-content: center;
      min-height: 60vh;
    }
    .home-menu {
      display: flex;
      gap: 2rem;
      margin-top: 2rem;
    }
    .home-btn {
      background: #00bcd4;
      color: #fff;
      padding: 1.2rem 2.5rem;
      border-radius: 10px;
      font-size: 1.2rem;
      font-weight: 600;
      text-decoration: none;
      transition: background 0.2s;
      box-shadow: 0 2px 8px rgba(0,0,0,0.08);
    }
    .home-btn:hover {
      background: #0097a7;
    }
    @media (max-width: 600px) {
      .home-menu {
        flex-direction: column;
        gap: 1rem;
      }
      .home-btn {
        width: 100%;
        text-align: center;
      }
    }
  `]
})
export class HomeComponent {}
