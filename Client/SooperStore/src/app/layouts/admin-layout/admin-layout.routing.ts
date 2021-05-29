import { DesprenoiComponent } from './../../pages/desprenoi/desprenoi.component';
import { Routes } from '@angular/router';

import { DashboardComponent } from '../../pages/dashboard/dashboard.component';
import { IconsComponent } from '../../pages/icons/icons.component';
import { MapsComponent } from '../../pages/maps/maps.component';
import { UserProfileComponent } from '../../pages/user-profile/user-profile.component';
import { TablesComponent } from '../../pages/tables/tables.component';
import { AddProdusComponent } from 'src/app/pages/Produs/addprodus.component';
import { EditProdusComponent } from 'src/app/pages/Produs/editprodus.component';
import { CosComponent } from 'src/app/pages/cos/cos.component';
import { TermeniComponent } from 'src/app/pages/termeni/termeni.component';
import { CategorieComponent } from 'src/app/pages/Categorie/categories.component';
import { AddCategorieComponent } from 'src/app/pages/Categorie/addcategorie.component';
import { EditCategorieComponent } from 'src/app/pages/Categorie/editcategorie.component';
import { FurnizoriComponent } from 'src/app/pages/furnizori/furnizori.component';
import { AddfurnizorComponent } from 'src/app/pages/furnizori/addfurnizor/addfurnizor.component';
import { EditfurnizorComponent } from 'src/app/pages/furnizori/editfurnizor/editfurnizor.component';

export const AdminLayoutRoutes: Routes = [
    { path: 'dashboard',      component: DashboardComponent },
    { path: 'addprodus',      component: AddProdusComponent },
    { path: 'editprodus/:id',      component: EditProdusComponent },
    { path: 'categories',      component: CategorieComponent },
    { path: 'addcategorie',      component: AddCategorieComponent },
    { path: 'editcategorie/:id',      component: EditCategorieComponent },
    { path: 'user-profile',   component: UserProfileComponent },
    { path: 'tables',         component: TablesComponent },
    { path: 'termeni',        component: TermeniComponent},
    { path: 'desprenoi',      component: DesprenoiComponent},
    { path: 'icons',          component: IconsComponent },
    { path: 'cos',            component: CosComponent},
    { path: 'furnizori',      component: FurnizoriComponent},
    { path: 'addfurnizor',    component: AddfurnizorComponent},
    { path: 'editfurnizor/:id',    component: EditfurnizorComponent}
];
