import { Component, OnInit } from '@angular/core';
import { CustomerDetailService } from 'src/app/shared/customer-detail.service';
import { CustomerDetail } from 'src/app/shared/customer-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-customer-detail-list',
  templateUrl: './customer-detail-list.component.html',
  styles: []
})
export class CustomerDetailListComponent implements OnInit {
  debugger;
  constructor(private service: CustomerDetailService,
    private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(pd: CustomerDetail) {
    this.service.formData = Object.assign({}, pd);
  }

  onDelete(Id) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.deleteCustomerDetail(Id)
        .subscribe(res => {
          debugger;
          this.service.refreshList();
          this.toastr.warning('Deleted successfully', 'Customer Detail Register');
        },
          err => {
            debugger;
            console.log(err);
          })
    }
  }

}
