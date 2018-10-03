import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient }    from '@angular/common/http'; 
@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }
  public addProduct():Observable<boolean> {
    
    console.log("addProduct called");
    return of(true);
  }
  public getProducts():Observable<boolean> {
    return of(true);
   
  }
}
