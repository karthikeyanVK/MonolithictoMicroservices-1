import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { OrdersComponent } from './orders/orders.component';
import { ProductsComponent } from './products/products.component';
import { HomeComponent } from './home/home.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';


const appRoutes: Routes = [
  { path: '',      component: HomeComponent },
  { path: 'products', component: ProductsComponent },
  { path: 'Orders',      component: OrdersComponent }


];

@NgModule({
  declarations: [
    AppComponent,
    OrdersComponent,
    ProductsComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
