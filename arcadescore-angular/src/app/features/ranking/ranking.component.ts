import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ScoreService, ScoreDto } from '../../shared/score.service';
import { Observable } from 'rxjs';
import { PlayerStatisticsDto } from '../../shared/player-statistics.dto';

@Component({
  selector: 'app-ranking',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './ranking.component.html',
  styleUrls: ['./ranking.component.scss']
})
export class RankingComponent implements OnInit {
  scores$!: Observable<ScoreDto[]>;
  showModal = false;
  playerStats: PlayerStatisticsDto | null = null;

  constructor(private scoreService: ScoreService) {}

  ngOnInit(): void {
    this.scores$ = this.scoreService.getRanking();
  }

  openPlayerStats(player: string, event: Event) {
    event.preventDefault();
    this.scoreService.getPlayerStatistics(player).subscribe(stats => {
      this.playerStats = stats;
      this.showModal = true;
    });
  }

  closeModal() {
    this.showModal = false;
    this.playerStats = null;
  }
}
