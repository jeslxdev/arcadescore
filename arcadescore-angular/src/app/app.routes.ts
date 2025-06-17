import { Routes } from '@angular/router';

export const routes: Routes = [
  { path: '', pathMatch: 'full', loadComponent: () => import('./home.component').then(m => m.HomeComponent) },
  { path: 'ranking', loadComponent: () => import('./features/ranking/ranking.component').then(m => m.RankingComponent) },
  { path: 'registrar', loadComponent: () => import('./features/register-score/register-score.component').then(m => m.RegisterScoreComponent) },
  { path: '**', redirectTo: '' }
];
