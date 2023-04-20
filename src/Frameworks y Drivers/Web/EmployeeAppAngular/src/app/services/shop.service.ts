import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Shop } from '../interfaces/shop';

@Injectable({
  providedIn: 'root'
})
export class ShopService {

  myAppUrl = environment.endpoint;
  myApiUrl = 'api/shop/';

  constructor(private httpClient: HttpClient) { }

  getShops(): Observable<Shop[]> {
    return this.httpClient.get<Shop[]>(`${this.myAppUrl}${this.myApiUrl}`);
  }
}
