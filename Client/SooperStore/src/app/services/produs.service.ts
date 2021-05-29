import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { RequestOptions } from "@angular/http";
import { Observable } from "rxjs";
import { Produs } from "../interfaces/produs.interface";

@Injectable()
export class ProdusService {
  baseUrl = 'https://localhost:44344/api/produs';
  constructor(private http: HttpClient) {
    }

   getAllProducts(): Observable<Produs[]> {
    return this.http.get<Produs[]>(this.baseUrl)
  }
  createProduct(model: Produs): Observable<any>{
    return this.http.post<Produs>(this.baseUrl,model);
  }
  getProduct(id: number): Observable<Produs>{
    return this.http.get<Produs>(this.baseUrl+"/"+id);
  }
  deleteProduct(id: number): Observable<any>{
    return this.http.delete<any>(this.baseUrl+"/"+id);
  }
  updateProduct(model: Produs, id: number): Observable<any>{
    return this.http.put<any>(this.baseUrl+"/"+id, model);
  }
}