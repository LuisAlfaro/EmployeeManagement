import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { EmployeeShop } from '../interfaces/employee-shop';

@Injectable({
  providedIn: 'root'
})
export class EmployeeShopService {

  myAppUrl = environment.endpoint;
  myApiUrl = 'api/employeeshop/';

  constructor(private httpClient: HttpClient) { }

  assingEmployeeShop(employeeShop: EmployeeShop): Observable<EmployeeShop> {
    return this.httpClient.post<EmployeeShop>(`${this.myAppUrl}${this.myApiUrl}`, employeeShop);
  }

  editEmployeeShop(id: number, employeeShop: EmployeeShop): Observable<EmployeeShop> {
    return this.httpClient.post<EmployeeShop>(`${this.myAppUrl}${this.myApiUrl}${id}`, employeeShop);
  }
  
}
