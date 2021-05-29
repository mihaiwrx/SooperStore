import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Produs } from 'src/app/interfaces/produs.interface';
import { InputTextModule } from 'primeng/inputtext';

import { SelectItem } from 'primeng/api';
import { toJSDate } from '@ng-bootstrap/ng-bootstrap/datepicker/ngb-calendar';
import { CategorieService } from 'src/app/services/categorie.service';
import { FurnizorService } from 'src/app/services/furnizor.service';
import { ProdusService } from 'src/app/services/produs.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-addprodus',
  templateUrl: './addprodus.component.html',
  encapsulation: ViewEncapsulation.None
})

export class AddProdusComponent implements OnInit {
    furnizorService:FurnizorService;
    categorieService: CategorieService;
    entity: Produs = new Produs();
    categories: SelectItem[] = [];
    furnizors: SelectItem[] = [];

  constructor(private _furnizorService: FurnizorService,
    private _categorieService: CategorieService,
    private _produsService: ProdusService,
    private router: Router) {
    }

  ngOnInit() {
      this.loadFurnizori();
      this.loadCategorii();
  }
  loadFurnizori(){
    this._furnizorService.getAllFurnizors().subscribe((items: SelectItem[])=>{
        this.furnizors = items;
    })
  }
  loadCategorii(){
      this._categorieService.getAllCategories().subscribe((items: SelectItem[])=>{
        this.categories = items;
    })
  }
  add(){
   this._produsService.createProduct(this.entity).subscribe();
   this.router.navigate(['dashboard']).then(() => {
    window.location.reload();
  });
  }
}
