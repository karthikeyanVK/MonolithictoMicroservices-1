import { Component, OnInit } from '@angular/core';
import { ProductService } from './product.service'
@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  constructor(private productService: ProductService) { }

  ngOnInit() {
  }

  addProduct = function () {
    this.productService.addProduct();
  }
}
