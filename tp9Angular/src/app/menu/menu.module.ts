import { CategoriasModule } from './../categorias/categorias.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuComponent } from './menu/menu.component';



@NgModule({
  declarations: [
    MenuComponent
  ],
  imports: [
    CommonModule,
    CategoriasModule
  ]
})
export class MenuModule { }
