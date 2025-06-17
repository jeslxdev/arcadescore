import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, Validators, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ScoreService } from '../../shared/score.service';

@Component({
  selector: 'app-register-score',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, HttpClientModule],
  templateUrl: './register-score.component.html',
  styleUrls: ['./register-score.component.scss']
})
export class RegisterScoreComponent {
  message = '';
  scoreForm: FormGroup;

  constructor(private fb: FormBuilder, private scoreService: ScoreService) {
    this.scoreForm = this.fb.group({
      player: ['', Validators.required],
      points: [0, [Validators.required, Validators.min(0)]],
      date: [new Date().toISOString().substring(0, 16), Validators.required]
    });
  }

  submit() {
    if (this.scoreForm.valid) {
      const value = this.scoreForm.value;
      this.scoreService.registerScore({
        player: value.player,
        points: value.points,
        date: value.date
      }).subscribe(() => {
        this.message = 'Pontuação registrada com sucesso!';
        this.scoreForm.reset({ date: new Date().toISOString().substring(0, 16), points: 0 });
      });
    }
  }
}
