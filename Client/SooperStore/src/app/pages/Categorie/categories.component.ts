import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import Chart from 'chart.js';
import { Produs } from 'src/app/interfaces/produs.interface';
import { ProdusService } from 'src/app/services/produs.service';
import {TableModule} from 'primeng/table';
import { Router } from '@angular/router';
import { SelectItem } from 'primeng/api';
import { Recenzie } from 'src/app/interfaces/recenzie.interface';
import { RecenzieService } from 'src/app/services/recenzie.service';
import { Categorie } from 'src/app/interfaces/categorie.interface';
import { CategorieService } from 'src/app/services/categorie.service';


@Component({
  selector: 'app-categorie',
  templateUrl: './categories.component.html'
})
export class CategorieComponent implements OnInit {

  public categories: Categorie[];
  public search: string;
  public copie: Categorie[];
  public display: boolean = false;
  constructor(private _categorieService: CategorieService,
    private router: Router,
    private _recenzieService: RecenzieService){}

  ngOnInit() {
   this.getCategory();
  }
  getCategory(){
    this._categorieService.getAll().subscribe((items: Categorie[])=> {
      this.categories = items;
      this.copie = items;
    })
  }
  delete(id: number){
    this._categorieService.deleteCategory(id).subscribe(()=> this.getCategory());
   
  }

  filter(){
    this.categories = this.copie.filter(x => x.nume.indexOf(this.search) > -1);
  }

}
