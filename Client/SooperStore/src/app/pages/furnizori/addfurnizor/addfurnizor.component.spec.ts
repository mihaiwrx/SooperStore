import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddfurnizorComponent } from './addfurnizor.component';

describe('AddfurnizorComponent', () => {
  let component: AddfurnizorComponent;
  let fixture: ComponentFixture<AddfurnizorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddfurnizorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddfurnizorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
