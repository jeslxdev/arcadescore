import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PlayerStatisticsDto } from './player-statistics.dto';

export interface ScoreDto {
  id?: number;
  player: string;
  points: number;
  date: string;
}

@Injectable({ providedIn: 'root' })
export class ScoreService {
  private apiUrl = 'http://localhost:8080/api/scores';

  constructor(private http: HttpClient) {}

  getRanking(): Observable<ScoreDto[]> {
    return this.http.get<ScoreDto[]>(`${this.apiUrl}/ranking`);
  }

  registerScore(score: Partial<ScoreDto>): Observable<void> {
    return this.http.post<void>(this.apiUrl, score);
  }

  getPlayerStatistics(player: string): Observable<PlayerStatisticsDto> {
    return this.http.get<PlayerStatisticsDto>(`${this.apiUrl}/player/${player}`);
  }
}
