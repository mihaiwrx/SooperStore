import { DesprenoiComponent } from './../../pages/desprenoi/desprenoi.component';
import { TermeniComponent } from 'src/app/pages/termeni/termeni.component';
import { Routes } from '@angular/router';

import { LoginComponent } from '../../pages/login/login.component';
import { RegisterComponent } from '../../pages/register/register.component';

export const AuthLayoutRoutes: Routes = [
    { path: 'login',          component: LoginComponent },
    { path: 'register',       component: RegisterComponent },
    { path: 'termeni',       component: TermeniComponent },
    { path: 'desprenoi',       component: DesprenoiComponent }
];
