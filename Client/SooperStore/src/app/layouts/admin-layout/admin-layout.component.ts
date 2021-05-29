import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Produs, Produse } from 'src/app/interfaces/produs.interface';

@Component({
  selector: 'app-admin-layout',
  templateUrl: './admin-layout.component.html',
  styleUrls: ['./admin-layout.component.scss']
})
export class AdminLayoutComponent implements OnInit {
  items: Produs[] = [];
  cos: Produse[] = [];
  constructor(private router: Router) { }

  ngOnInit() {
    
  }

  add(item: Produs){
    if(this.items !== null && this.items !== undefined){
      if(this.items.indexOf(item) > -1){
        this.cos[this.items.indexOf(item)].numar += 1;
      }else{
        this.items.push(item);
         var itemCos : Produse = new Produse(item);
         this.cos.push(itemCos);
      }
    }
    
  }

}
