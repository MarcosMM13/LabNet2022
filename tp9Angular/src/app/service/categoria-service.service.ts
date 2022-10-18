import { Category } from './../Models/Category';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoriaService{

 private categoriaURL='https://localhost:44344/';
 private  apiURL='api/Category/';

  constructor(private http: HttpClient) { }

  getListCategoria(): Observable<any>{
    return this.http.get(this.categoriaURL + this.apiURL);
  }

  deleteCategoria(id: number):Observable<any>{
    return this.http.delete(this.categoriaURL + this.apiURL + id)
  }

  saveCategoria(categoria : Category) : Observable<any>{
    return this.http.post(this.categoriaURL + this.apiURL,categoria);
  }

  updateCategoria(id:number, categoria : Category): Observable<any>{
    return this.http.put(this.categoriaURL + this.apiURL + id, categoria)
  }
}
