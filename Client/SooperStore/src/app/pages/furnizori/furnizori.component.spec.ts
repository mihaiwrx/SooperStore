import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FurnizoriComponent } from './furnizori.component';

describe('FurnizoriComponent', () => {
  let component: FurnizoriComponent;
  let fixture: ComponentFixture<FurnizoriComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FurnizoriComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FurnizoriComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
