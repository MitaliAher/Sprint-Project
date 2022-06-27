import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  private _categoryUrl ="https://localhost:44326/api/Category";

  constructor(private http:HttpClient,_router:Router) { }

  getCategorys() {
    return this.http.get<any>(this._categoryUrl);
}
}
