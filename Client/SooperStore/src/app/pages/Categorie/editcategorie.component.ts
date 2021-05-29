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
import { Categorie } from 'src/app/interfaces/categorie.interface';

@Component({
  selector: 'app-editcategorie',
  templateUrl: './editcategorie.component.html',
  encapsulation: ViewEncapsulation.None
})

export class EditCategorieComponent implements OnInit {
    entity: Categorie = new Categorie();
    id: number;
private sub: any;
  constructor(
    private router: Router,
    private route: ActivatedRoute,
    private _categorieService: CategorieService) {
    }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
        this.id = +params['id'];
     });
     this._categorieService.getCategory(this.id).subscribe((item: Categorie)=>{
         this.entity=item;
     })

  }
  update(){
   this._categorieService.updateCategory(this.entity, this.id).subscribe();
   this.router.navigate(['categories']).then(() => {
    window.location.reload();
  });
  }


}
