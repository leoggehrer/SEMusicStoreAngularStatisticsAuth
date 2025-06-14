﻿import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArtistTrackListComponent } from './artist-track-list.component';

describe('ArtistTrackListComponent', () => {
  let component: ArtistTrackListComponent;
  let fixture: ComponentFixture<ArtistTrackListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ArtistTrackListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ArtistTrackListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
