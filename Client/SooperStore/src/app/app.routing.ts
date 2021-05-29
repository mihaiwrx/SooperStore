import { StartpageComponent } from './pages/startpage/startpage.component';
import { NgModule } from '@angular/core';
import { CommonModule, } from '@angular/common';
import { BrowserModule  } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';

import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';
import { AddProdusComponent } from './pages/Produs/addprodus.component';
import { EditProdusComponent } from './pages/Produs/editprodus.component';
import { UserProfileComponent } from './pages/user-profile/user-profile.component';
import { TablesComponent } from './pages/tables/tables.component';
import { IconsComponent } from './pages/icons/icons.component';
import { TermeniComponent } from './pages/termeni/termeni.component';

const routes: Routes =[
  {
    path: '',
    redirectTo: 'startpage',
    pathMatch: 'full',
  }, {
    path: '',
    component: AdminLayoutComponent,
    children: [
      {
        path: '',
        loadChildren: './layouts/admin-layout/admin-layout.module#AdminLayoutModule'
      }
    ]
  }, {
    path: '',
    component: AuthLayoutComponent,
    children: [
      {
        path: '',
        loadChildren: './layouts/auth-layout/auth-layout.module#AuthLayoutModule'
      }
    ]
  }, {
    path: '**',
    redirectTo: 'dashboard'
  },
  {
    path: 'startpage',
    component: StartpageComponent
  }
];

@NgModule({
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forRoot(routes,{
      useHash: false
    })
  ],
  exports: [
  ],
})
export class AppRoutingModule { }
