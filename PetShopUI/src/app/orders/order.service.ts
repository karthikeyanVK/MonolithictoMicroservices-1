import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Order } from './order';
import { Observable, of } from 'rxjs';
import { environment } from '../../environments/environment';
const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};
@Injectable({
  providedIn: 'root'
})
export class OrderService {
  private orderUrl: string;
  constructor(private http: HttpClient) {
    this.orderUrl = environment.orderServiceUrl + '/api/OrderProducts';
  }
  public orderProduct(order: Order): Observable<Order> {
    return this.http.post<Order>(this.orderUrl, order, httpOptions)
  }
}
