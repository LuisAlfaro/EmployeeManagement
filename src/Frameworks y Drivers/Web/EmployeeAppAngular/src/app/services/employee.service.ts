import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Employee } from '../interfaces/employee';


@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  myAppUrl = environment.endpoint;
  myApiUrl = 'api/employee/';

  constructor(private httpClient: HttpClient) {
  }

  getEmployees(): Observable<Employee[]> {
    return this.httpClient.get<Employee[]>(`${this.myAppUrl}${this.myApiUrl}`);
  }

  getEmployee(id: number): Observable<Employee> {
    return this.httpClient.get<Employee>(`${this.myAppUrl}${this.myApiUrl}${id}`);
  }

  deleteEmployee(id: number): Observable<void> {
    return this.httpClient.delete<void>(`${this.myAppUrl}${this.myApiUrl}${id}`);
  }

  createEmployee(employee: Employee): Observable<Employee> {
    return this.httpClient.post<Employee>(`${this.myAppUrl}${this.myApiUrl}`, employee);
  }

  updateEmployee(id: number, employee: Employee): Observable<void> {
    return this.httpClient.put<void>(`${this.myAppUrl}${this.myApiUrl}${id}`, employee);
  }

}
