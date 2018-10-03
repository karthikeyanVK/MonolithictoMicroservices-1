import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Order } from './order';
import { Observable, of } from 'rxjs';
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};
@Injectable({
  providedIn: 'root'
})
export class OrderService {
  private orderUrl: string;
  constructor(private http: HttpClient) {
    this.orderUrl = "http://localhost:8059/api/OrderProducts"
  }
  public orderProduct(order: Order): Observable<Order> {
    return this.http.post<Order>(this.orderUrl, order, httpOptions)
  }
}
