import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsertMacotaComponent } from './insert-macota.component';

describe('InsertMacotaComponent', () => {
  let component: InsertMacotaComponent;
  let fixture: ComponentFixture<InsertMacotaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsertMacotaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InsertMacotaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
