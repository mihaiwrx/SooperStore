import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppRoutingModule } from './app.routing';
import { ComponentsModule } from './components/components.module';
import { ProdusService } from './services/produs.service';
import { CategorieService } from './services/categorie.service';
import { FurnizorService } from './services/furnizor.service';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { TableModule } from 'primeng/table';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { InputNumberModule } from 'primeng/inputnumber';
import { DropdownModule } from 'primeng/dropdown';
import { ListaProduse } from './interfaces/produse.interface';
import { CommonModule } from '@angular/common';
import { TermeniComponent } from './pages/termeni/termeni.component';
import { StartpageComponent } from './pages/startpage/startpage.component';
import { DialogModule } from 'primeng/dialog';
import {InputTextareaModule} from 'primeng/inputtextarea';
import { RecenzieService } from './services/recenzie.service';


@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    ComponentsModule,
    NgbModule,
    RouterModule,
    AppRoutingModule,
    TableModule,
    InputTextModule,
    ButtonModule,
    InputNumberModule,
    DropdownModule,
    CommonModule,
    DialogModule,
    InputTextareaModule
  ],
  declarations: [
    AppComponent,
    AdminLayoutComponent,
    AuthLayoutComponent,
    TermeniComponent,
    StartpageComponent,
    DashboardComponent
  ],
  providers: [ProdusService,FurnizorService, CategorieService, ListaProduse, RecenzieService],
  bootstrap: [AppComponent]
})
export class AppModule { }
