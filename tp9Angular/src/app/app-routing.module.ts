import { MenuComponent } from './menu/menu/menu.component';
import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CategoriaAltaComponent } from './categorias/categoriasABM/categoriaABM.component';

const routes: Routes = [
  {
    path: 'Menu',
    component: MenuComponent
  },
  {
     path: '',
     redirectTo:'Menu',
     pathMatch:'full',
  },
  {
    path: 'AltaCategoria',
    component: CategoriaAltaComponent
  },
  {
    path: '**',
    redirectTo:'Menu',
    pathMatch:'full',
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
