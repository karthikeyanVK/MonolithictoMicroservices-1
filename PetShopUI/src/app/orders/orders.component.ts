import { Component, OnInit } from '@angular/core';
import { ProductService } from '../products/product.service'
import { Product } from '../products/product';
import { OrderService } from './order.service'
import { Order } from './order'
import { UUID } from 'angular2-uuid';
import { ResourceLoader } from '@angular/compiler';
@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit {

  constructor(private productService: ProductService, private orderService: OrderService) { }
  private result: boolean;
  private orders: Order[];
  ngOnInit() {
    this.getProducts();
  }
  getProducts = function () {
    this.productService.getProducts().subscribe(result => this.orders = this.getOrdersData(result));
  }
  orderProduct = function (order: Order) {
    if (order.Quantity <= order.AvailableQuantity) {
      this.orderService.orderProduct(order).subscribe(result => { this.result = result; this.getProducts(); });
    }
  }
  getOrdersData(products: Product[]): Order[] {
    let ordersData = [];
    products.forEach(product => {
      let order = new Order();
      order.OrderId = UUID.UUID();
      order.ProductId = product.ProductId;
      order.ProductName = product.ProductName;
      order.AvailableQuantity = product.AvailableQuantity;
      order.Quantity = 0;
      ordersData.push(order);
    });
    return ordersData;
  }
}
