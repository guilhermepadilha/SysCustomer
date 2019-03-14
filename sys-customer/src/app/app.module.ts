import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';
import { AppComponent } from './app.component';
import { CustomerDetailsComponent } from './customer-details/customer-details.component';
import { CustomerDetailComponent } from './customer-details/customer-detail/customer-detail.component';
import { CustomerDetailListComponent } from './customer-details/customer-detail-list/customer-detail-list.component';
import { CustomerDetailService } from './shared/customer-detail.service';



@NgModule({
  declarations: [
    AppComponent,
    CustomerDetailsComponent,
    CustomerDetailComponent,
    CustomerDetailListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [CustomerDetailService],
  bootstrap: [AppComponent]
})
export class AppModule { }
