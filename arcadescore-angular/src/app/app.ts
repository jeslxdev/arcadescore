import { Component, AfterViewInit, Inject } from '@angular/core';
import { RouterOutlet, RouterLink, RouterLinkActive } from '@angular/router';
import { isPlatformBrowser } from '@angular/common';
import { PLATFORM_ID } from '@angular/core';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink, RouterLinkActive],
  templateUrl: './app.html',
  styleUrls: ['./app.scss']
})
export class AppComponent implements AfterViewInit {
  protected title = 'arcadescore';

  constructor(@Inject(PLATFORM_ID) private platformId: Object) {}

  ngAfterViewInit() {
    if (isPlatformBrowser(this.platformId)) {
      // Adiciona pixels animados ao fundo
      const bg = document.querySelector('.arcade-bg');
      if (bg) {
        for (let i = 0; i < 32; i++) {
          const px = document.createElement('div');
          px.className = 'pixel';
          px.style.left = Math.random() * 100 + 'vw';
          px.style.top = (Math.random() * 100 - 10) + 'vh';
          px.style.animationDelay = (Math.random() * 6) + 's';
          bg.appendChild(px);
        }
      }
    }
  }
}
