import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Product } from './product'

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};
@Injectable({
  providedIn: 'root'
})

export class ProductService {

  private productUrl: string;
  constructor(private http: HttpClient) {
    this.productUrl = "http://localhost:8059/api/Product"
  }
  public addProduct(product: Product): Observable<Product> {

   return this.http.post<Product>(this.productUrl, product, httpOptions)
     
  }
  public getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.productUrl)
  }

}
