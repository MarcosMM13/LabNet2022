import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/Models/Category';
import { CategoriaService } from 'src/app/service/categoria-service.service';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
  listCategorias: Category[] = [];

  constructor(private _categoriaService: CategoriaService) { }

  ngOnInit(): void {
    this.obtenerCategoria();
  }
  obtenerCategoria() {
    this._categoriaService.getListCategoria().subscribe(
      data => { this.listCategorias = data },
      error => {
        console.log(error);
      })
  }

}
