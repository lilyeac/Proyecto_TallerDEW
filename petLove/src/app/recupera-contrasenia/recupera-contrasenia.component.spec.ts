import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecuperaContraseniaComponent } from './recupera-contrasenia.component';

describe('RecuperaContraseniaComponent', () => {
  let component: RecuperaContraseniaComponent;
  let fixture: ComponentFixture<RecuperaContraseniaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecuperaContraseniaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RecuperaContraseniaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
