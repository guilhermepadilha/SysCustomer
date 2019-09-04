import { CustomerDetail } from './customer-detail.model';
import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class CustomerDetailService {
  formData: CustomerDetail;
  readonly rootURL = 'http://localhost:54717/api';
  list : CustomerDetail[];

  constructor(private http: HttpClient) { }

  postCustomerDetail() {
    return this.http.post(this.rootURL + '/CustomerDetail', this.formData);
  }
  putCustomerDetail() {
    return this.http.put(this.rootURL + '/CustomerDetail/'+ this.formData.Id, this.formData);
  }
  deleteCustomerDetail(id) {
    return this.http.delete(this.rootURL + '/CustomerDetail/'+ id);
  }

  refreshList(){
    debugger;
    this.http.get(this.rootURL + '/CustomerDetail')
    .toPromise()
    .then(res => this.list = res as CustomerDetail[]);
  }
}