import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditfurnizorComponent } from './editfurnizor.component';

describe('EditfurnizorComponent', () => {
  let component: EditfurnizorComponent;
  let fixture: ComponentFixture<EditfurnizorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditfurnizorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditfurnizorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
