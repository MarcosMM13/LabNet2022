import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoriaAltaComponent } from './categoriaABM.component';

describe('CategoriaAltaComponent', () => {
  let component: CategoriaAltaComponent;
  let fixture: ComponentFixture<CategoriaAltaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CategoriaAltaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CategoriaAltaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
