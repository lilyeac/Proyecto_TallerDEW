import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarNegocioComponent } from './listar-negocio.component';

describe('ListarNegocioComponent', () => {
  let component: ListarNegocioComponent;
  let fixture: ComponentFixture<ListarNegocioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListarNegocioComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarNegocioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
