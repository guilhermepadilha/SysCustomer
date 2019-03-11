import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { CustomerDetailsComponent } from './customer-details/customer-details.component';
import { CustomerDetailComponent } from './customer-details/customer-detail/customer-detail.component';
import { CustomerDetailListComponent } from './customer-details/customer-detail-list/customer-detail-list.component';
import { CustomerDetailService } from './shared/customer-detail.service';
import { HttpClientModule } from '@angular/common/http';

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
    // BrowserAnimationModule,
    // ToastrModule.forRoot()
  ],
  providers: [CustomerDetailService],
  bootstrap: [AppComponent]
})
export class AppModule { }
