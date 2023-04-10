import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListEmployeeShopComponent } from './components/employee-shop/list-employee-shop/list-employee-shop.component';
import { ListEmployeeTypeComponent } from './components/employee-type/list-employee-type/list-employee-type.component';
import { CreateEditEmployeeComponent } from './components/employee/create-edit-employee/create-edit-employee.component';
import { DetailEmployeeComponent } from './components/employee/detail-employee/detail-employee.component';
import { ListEmployeeComponent } from './components/employee/list-employee/list-employee.component';
import { ListShopComponent } from './components/shop/list-shop/list-shop.component';

const routes: Routes = [
  { path: '', redirectTo:'listEmployee', pathMatch:'full'},  
  { path: 'listEmployee', component: ListEmployeeComponent },  
  { path: 'listEmployeeType', component: ListEmployeeTypeComponent },
  { path: 'listShop', component: ListShopComponent },
  { path: 'listEmployeeShop', component: ListEmployeeShopComponent },

  { path: 'createEditEmployee', component: CreateEditEmployeeComponent },
  { path: 'detailEmployee', component: DetailEmployeeComponent },

  { path: '**', redirectTo: 'listEmployee', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
