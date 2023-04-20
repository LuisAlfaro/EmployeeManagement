import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { EmployeeType } from '../interfaces/employee-type';

@Injectable({
  providedIn: 'root'
})
export class EmployeeTypeService {

  myAppUrl = environment.endpoint;
  myApiUrl = 'api/employeeType/';

  constructor(private httpClient: HttpClient) { }

  getEmployeeTypes(): Observable<EmployeeType[]> {
    return this.httpClient.get<EmployeeType[]>(`${this.myAppUrl}${this.myApiUrl}`);
  }
  

}
