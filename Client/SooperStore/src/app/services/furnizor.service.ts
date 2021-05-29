import { Furnizor } from 'src/app/interfaces/furnizor.interface';
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { SelectItem } from "primeng/api";
import { Observable } from "rxjs";

@Injectable()
export class FurnizorService {
  baseUrl = 'https://localhost:44344/api/furnizor';
  constructor(private http: HttpClient) {
    }

  getAllFurnizors(): Observable<SelectItem[]> {
    return this.http.get<SelectItem[]>(this.baseUrl+"/getallselect");
  }
  getAll(): Observable<Furnizor[]>{
    return this.http.get<Furnizor[]>(this.baseUrl);
  }
  createFurnizor(model: Furnizor): Observable<any>{
    return this.http.post<Furnizor>(this.baseUrl,model);
  }
  getFurnizor(id: number): Observable<Furnizor>{
    return this.http.get<Furnizor>(this.baseUrl+"/"+id);
  }
  deleteFurnizor(id: number): Observable<any>{
    return this.http.delete<any>(this.baseUrl+"/"+id);
  }
  updateFurnizor(model: Furnizor, id: number): Observable<any>{
    return this.http.put<any>(this.baseUrl+"/"+id, model);
  }
}
