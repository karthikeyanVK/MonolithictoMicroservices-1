import { Component, OnInit } from '@angular/core';
import { ProductService } from './product.service'
import { Product } from './product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  constructor(private productService: ProductService) { }
  private addProductResult: boolean;
  private product: Product;

  ngOnInit() {
   
    this.product = new Product();
  }


  addProduct = function () {
    this.productService.addProduct(this.product).subscribe(result => this.addProductResult = result);
  }
 
}
