import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainWrapperComponent } from './main-wrapper/main-wrapper.component';
import { SidebarLeftComponent } from './sidebar-left/sidebar-left.component';
import { MainBodyComponent } from './main-body/main-body.component';
import { NavigationBarComponent } from './navigation-bar/navigation-bar.component';
import { MainContentComponent } from './main-content/main-content.component';
import { InvoiceDetailComponent } from './invoice-detail/invoice-detail.component';
import { InvoiceListComponent } from './invoice-list/invoice-list.component';
import { TableComponent } from './table/table.component';
import { SelectOptionComponent } from './select-option/select-option.component';
import { PaginationComponent } from './pagination/pagination.component';



@NgModule({
  declarations: [
    AppComponent,
    MainWrapperComponent,
    SidebarLeftComponent,
    MainBodyComponent,
    NavigationBarComponent,
    MainContentComponent,
    InvoiceDetailComponent,
    InvoiceListComponent,
    TableComponent,
    SelectOptionComponent,
    PaginationComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
