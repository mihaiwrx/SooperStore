import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Produs } from 'src/app/interfaces/produs.interface';
import { InputTextModule } from 'primeng/inputtext';

import { SelectItem } from 'primeng/api';
import { toJSDate } from '@ng-bootstrap/ng-bootstrap/datepicker/ngb-calendar';
import { CategorieService } from 'src/app/services/categorie.service';
import { FurnizorService } from 'src/app/services/furnizor.service';
import { ProdusService } from 'src/app/services/produs.service';
import { ActivatedRoute, Router } from '@angular/router';
import { RecenzieService } from 'src/app/services/recenzie.service';
import { Recenzie } from 'src/app/interfaces/recenzie.interface';

@Component({
  selector: 'app-editprodus',
  templateUrl: './editprodus.component.html',
  encapsulation: ViewEncapsulation.None
})

export class EditProdusComponent implements OnInit {
    furnizorService:FurnizorService;
    categorieService: CategorieService;
    entity: Produs = new Produs();
    id: number;
    private sub: any;
    categories: SelectItem[] = [];
    furnizors: SelectItem[] = [];
    recenzii: Recenzie[] = [];
  constructor(private _furnizorService: FurnizorService,
    private _categorieService: CategorieService,
    private _produsService: ProdusService,
    private router: Router,
    private route: ActivatedRoute,
    private _recenzieService: RecenzieService) {
    }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
        this.id = +params['id'];
     });
     this._produsService.getProduct(this.id).subscribe((item: Produs)=>{
         this.entity=item;
     })
      this.loadFurnizori();
      this.loadCategorii();
      this.loadRecenzii();
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
  loadRecenzii(){
    this._recenzieService.getAllReviewsByProductId(this.id).subscribe((items: Recenzie[])=>{
      this.recenzii = items;
    })
  }
  update(){
   this._produsService.updateProduct(this.entity, this.id).subscribe();
   this.router.navigate(['dashboard']).then(() => {
    window.location.reload();
  });
  }
}
