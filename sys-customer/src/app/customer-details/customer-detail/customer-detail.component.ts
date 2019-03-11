import { Component, OnInit } from '@angular/core';
import { CustomerDetailService } from 'src/app/shared/customer-detail.service';

@Component({
  selector: 'app-customer-detail',
  templateUrl: './customer-detail.component.html',
  styles: []
})
export class CustomerDetailComponent implements OnInit {

  constructor(private service: CustomerDetailService) {
    
   }

  ngOnInit() {
  }

}
