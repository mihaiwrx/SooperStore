import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import Chart from 'chart.js';
import { Produs } from 'src/app/interfaces/produs.interface';
import { ProdusService } from 'src/app/services/produs.service';
import {TableModule} from 'primeng/table';
import { Router } from '@angular/router';
import { SelectItem } from 'primeng/api';
import { Recenzie } from 'src/app/interfaces/recenzie.interface';
import { RecenzieService } from 'src/app/services/recenzie.service';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  public products: Produs[];
  public display: boolean = false;
  public note: SelectItem[] = [
    {label: 'Prost', value: 1},
    {label: 'Okaish', value: 2},
    {label: 'Bine', value: 3},
    {label: 'Foarte Bine', value: 4},
    {label: 'Excelent', value: 5}
];
  public recenzie: Recenzie = new Recenzie();
  public search: string;
  public copie: Produs[];

  @Output() cos = new EventEmitter<Produs>();
  constructor(private _produsService: ProdusService,
    private router: Router,
    private _recenzieService: RecenzieService){}

  ngOnInit() {
   this.getProducts();
   this.router.routeReuseStrategy.shouldReuseRoute = () => {
    return false;
  }
  }
  getProducts(){
    this._produsService.getAllProducts().subscribe((items: Produs[])=> {
      this.products = items;
      this.copie = items;
    })
  }
  delete(id: number){
    this._produsService.deleteProduct(id).subscribe();
    this.getProducts();
    window.location.reload();
  }
  addItem(item: Produs){
    this.cos.emit(item);
  }

  setReview(id:number){
    this.recenzie.produsId = id;
  }
  toggleDisplay(){
    if(this.display == false){
      this.recenzie = new Recenzie();
    }
    this.display = !this.display;
  }

  addReview(){
    this.recenzie.numeUtilizator='userTest';
    this._recenzieService.createReview(this.recenzie).subscribe();
  }

  filter(){
    this.products = this.copie.filter(x => x.nume.indexOf(this.search) > -1);
  }

}
