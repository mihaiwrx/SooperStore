import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Produse } from 'src/app/interfaces/produs.interface';
import { ListaProduse } from 'src/app/interfaces/produse.interface';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-cos',
  templateUrl: './cos.component.html'
})
export class CosComponent implements OnInit {
  items: Produse[];
  constructor( private _route: ActivatedRoute, private iteme: ListaProduse) { }

  ngOnInit() {
    this.items = this.iteme.items;
  }

}
