import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { RequestOptions } from "@angular/http";
import { Observable } from "rxjs";
import { Produs } from "../interfaces/produs.interface";
import { Recenzie } from "../interfaces/recenzie.interface";

@Injectable()
export class RecenzieService {
  baseUrl = 'https://localhost:44344/api/recenzie';
  constructor(private http: HttpClient) {
    }

   getAllReviews(): Observable<Recenzie[]> {
    return this.http.get<Recenzie[]>(this.baseUrl)
  }
  getAllReviewsByProductId(productId: number): Observable<Recenzie[]> {
    return this.http.get<Recenzie[]>(this.baseUrl + "/getall/" + productId)
  }
  createReview(model: Recenzie): Observable<any>{
    return this.http.post<Recenzie>(this.baseUrl,model);
  }

}