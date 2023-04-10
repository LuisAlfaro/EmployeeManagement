import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';

// Modulos
import { SharedModule } from './shared/shared.module';

// Components
import { CreateEditEmployeeComponent } from './components/employee/create-edit-employee/create-edit-employee.component';
import { ListEmployeeComponent } from './components/employee/list-employee/list-employee.component';
import { DetailEmployeeComponent } from './components/employee/detail-employee/detail-employee.component';
import { ListShopComponent } from './components/shop/list-shop/list-shop.component';
import { ListEmployeeTypeComponent } from './components/employee-type/list-employee-type/list-employee-type.component';
import { ListEmployeeShopComponent } from './components/employee-shop/list-employee-shop/list-employee-shop.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';





@NgModule({
  declarations: [
    AppComponent,
    CreateEditEmployeeComponent,
    ListEmployeeComponent,
    DetailEmployeeComponent,
    ListShopComponent,
    ListEmployeeTypeComponent,
    ListEmployeeShopComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    SharedModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
