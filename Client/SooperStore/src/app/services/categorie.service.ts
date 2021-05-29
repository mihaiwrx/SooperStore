import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { SelectItem } from "primeng/api";
import { Observable } from "rxjs";
import { Categorie } from "../interfaces/categorie.interface";

@Injectable()
export class CategorieService {
  baseUrl = 'https://localhost:44344/api/categorie';
  constructor(private http: HttpClient) {
    }

   getAllCategories(): Observable<SelectItem[]> {
    return this.http.get<SelectItem[]>(this.baseUrl+"/getallselect")
  }

  getAll(): Observable<Categorie[]> {
    return this.http.get<Categorie[]>(this.baseUrl)
  }
  createCategory(model: Categorie): Observable<any>{
    return this.http.post<Categorie>(this.baseUrl,model);
  }
  getCategory(id: number): Observable<Categorie>{
    return this.http.get<Categorie>(this.baseUrl+"/"+id);
  }
  deleteCategory(id: number): Observable<any>{
    return this.http.delete<any>(this.baseUrl+"/"+id);
  }
  updateCategory(model: Categorie, id: number): Observable<any>{
    return this.http.put<any>(this.baseUrl+"/"+id, model);
  }
}