import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { ClipboardModule } from 'ngx-clipboard';

import { AdminLayoutRoutes } from './admin-layout.routing';
import { DashboardComponent } from '../../pages/dashboard/dashboard.component';
import { IconsComponent } from '../../pages/icons/icons.component';
import { MapsComponent } from '../../pages/maps/maps.component';
import { UserProfileComponent } from '../../pages/user-profile/user-profile.component';
import { TablesComponent } from '../../pages/tables/tables.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { TableModule } from 'primeng/table';
import { AddProdusComponent } from 'src/app/pages/Produs/addprodus.component';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { InputNumberModule } from 'primeng/inputnumber';
import { DropdownModule } from 'primeng/dropdown';
import { EditProdusComponent } from 'src/app/pages/Produs/editprodus.component';
import { CosComponent } from 'src/app/pages/cos/cos.component';
import { DialogModule } from 'primeng/dialog';
import { CategorieComponent } from 'src/app/pages/Categorie/categories.component';
import { AddCategorieComponent } from 'src/app/pages/Categorie/addcategorie.component';
import { EditCategorieComponent } from 'src/app/pages/Categorie/editcategorie.component';
import { FurnizoriComponent } from 'src/app/pages/furnizori/furnizori.component';
import { AddfurnizorComponent } from 'src/app/pages/furnizori/addfurnizor/addfurnizor.component';
import { EditfurnizorComponent } from 'src/app/pages/furnizori/editfurnizor/editfurnizor.component';
// import { ToastrModule } from 'ngx-toastr';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(AdminLayoutRoutes),
    FormsModule,
    HttpClientModule,
    NgbModule,
    ClipboardModule,
    TableModule,
    InputTextModule,
    ButtonModule,
    InputNumberModule,
    DropdownModule,
    DialogModule,
    CommonModule
  ],
  declarations: [
    UserProfileComponent,
    TablesComponent,
    IconsComponent,
    MapsComponent,
    AddProdusComponent,
    EditProdusComponent,
    CosComponent,
    CategorieComponent,
    AddCategorieComponent,
    EditCategorieComponent,
    FurnizoriComponent,
    AddfurnizorComponent,
    EditfurnizorComponent
  ]
})

export class AdminLayoutModule {}
