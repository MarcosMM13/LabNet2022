import { Category } from '../../Models/Category';
import { CategoriaService } from '../../service/categoria-service.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import Swal from 'sweetalert2'

@Component({
  selector: 'app-categoriaABM',
  templateUrl: './categoriaABM.component.html',
  styleUrls: ['./categoriaABM.component.scss']
})
export class CategoriaAltaComponent implements OnInit {

  form: FormGroup;
  listCategorias: Category[] = [];
  id: number | undefined;
  accion: string = 'Alta'
  tittle = 'sweetAlert'

  constructor(private fb: FormBuilder,
    private _categoriaService: CategoriaService) {
    this.form = this.fb.group({
      nombre: ['', [Validators.required, Validators.maxLength(15), Validators.minLength(1)]],
      descripcion: ['']
    })
  }

  ngOnInit(): void {
    this.obtenerCategoria();
  }

  showModalEliminar() {
    Swal.fire({
      position: 'top-end',
      icon: 'success',
      title: 'Ha eliminado con exito!!',
      text: 'Se ha borrado una categoria!',
    })
  }

  showModalGuardar() {
    Swal.fire({
      position: 'top-end',
      icon: 'success',
      title: 'Se ha guardado la Categoria',
      text: 'Tarea Exitosa!',
      showConfirmButton: false,
      timer: 1500
    })
  }

  showModalError() {
    Swal.fire({
      icon: 'error',
      title: 'No se a podido realizar la tarea!!',
      text: 'Oops!',
    })
  }

  obtenerCategoria() {
    this._categoriaService.getListCategoria().subscribe(
      data => { this.listCategorias = data },
      error => {
        console.log(error);
      })
  }

  eliminarCategoria(id: number) {
    this._categoriaService.deleteCategoria(id).subscribe(
      data => {
        this.obtenerCategoria();
        this.showModalEliminar();
      }, error => {
        this.showModalError();
      })
    this.form.reset();
  };

  guardarCategoria() {
    const categoria: any = {
      Nombre: this.form.get('nombre')?.value,
      Descripcion: this.form.get('descripcion')?.value
    }

    if (this.id == undefined) {
      this._categoriaService.saveCategoria(categoria).subscribe(
        data => {
          this.obtenerCategoria()
          this.showModalGuardar()
        },
        error => {
          this.showModalError();
        }
      )
      this.form.reset();
    } else {
      categoria.Id = this.id;
      this._categoriaService.updateCategoria(this.id, categoria).subscribe(data => {
        this.form.reset();
        this.accion = 'Agregar'
        this.id = undefined
        this.obtenerCategoria();
        this.showModalGuardar();
      }, error => {
        this.showModalError();
      })
    }
  }

  modificarCategoria(categoria: Category) {
    this.id = categoria.Id
    this.accion = 'Modificacion'
    this.form.patchValue({
      nombre: categoria.Nombre,
      descripcion: categoria.Descripcion
    })
  };
}
