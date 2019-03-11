import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CustomerDetailsComponent } from './customer-details/customer-details.component';
import { CustomerDetailComponent } from './customer-details/customer-detail/customer-detail.component';
import { CustomerDetailListComponent } from './customer-details/customer-detail-list/customer-detail-list.component';

@NgModule({
  declarations: [
    AppComponent,
    CustomerDetailsComponent,
    CustomerDetailComponent,
    CustomerDetailListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
