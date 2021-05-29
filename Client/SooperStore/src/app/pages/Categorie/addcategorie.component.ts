import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Produs } from 'src/app/interfaces/produs.interface';
import { InputTextModule } from 'primeng/inputtext';

import { SelectItem } from 'primeng/api';
import { toJSDate } from '@ng-bootstrap/ng-bootstrap/datepicker/ngb-calendar';
import { CategorieService } from 'src/app/services/categorie.service';
import { FurnizorService } from 'src/app/services/furnizor.service';
import { ProdusService } from 'src/app/services/produs.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Categorie } from 'src/app/interfaces/categorie.interface';

@Component({
  selector: 'app-addcategorie',
  templateUrl: './addcategorie.component.html'
})

export class AddCategorieComponent implements OnInit {
    entity: Categorie = new Categorie();

  constructor(
    private _categoryService: CategorieService,
    private router: Router) {
    }

  ngOnInit() {

  }
  add(){
   this._categoryService.createCategory(this.entity).subscribe();
   this.router.navigate(['categories']).then(() => {
    window.location.reload();
  });
  }
}
