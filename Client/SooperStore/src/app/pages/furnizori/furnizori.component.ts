import { FurnizorService } from 'src/app/services/furnizor.service';
import { Component, OnInit } from '@angular/core';
import { Furnizor } from 'src/app/interfaces/furnizor.interface';
import { Router } from '@angular/router';

@Component({
  selector: 'app-furnizori',
  templateUrl: './furnizori.component.html',
  styleUrls: ['./furnizori.component.css']
})
export class FurnizoriComponent implements OnInit {

  public furnizori: Furnizor[];
  public search: string;
  public copie: Furnizor[];

  constructor(private _furnizorService: FurnizorService,
    private router: Router) { }

  ngOnInit(): void {
    this.getFurnizori();
    this.router.routeReuseStrategy.shouldReuseRoute = () => {
      return false;
    }
  }

  getFurnizori(){
    this._furnizorService.getAll().subscribe((items: Furnizor[])=> {
      this.furnizori = items;
      this.copie = items;
    })
  }

  delete(id: number){
    this._furnizorService.deleteFurnizor(id).subscribe();
    this.getFurnizori();
  }

  filter(){
    this.furnizori = this.copie.filter(x => x.nume.indexOf(this.search) > -1);
  }

}
