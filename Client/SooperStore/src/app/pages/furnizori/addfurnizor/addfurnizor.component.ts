import { Router } from '@angular/router';
import { FurnizorService } from 'src/app/services/furnizor.service';
import { Component, OnInit } from '@angular/core';
import { Furnizor } from 'src/app/interfaces/furnizor.interface';
import { FurnizoriComponent } from '../furnizori.component';

@Component({
  selector: 'app-addfurnizor',
  templateUrl: './addfurnizor.component.html',
  styleUrls: ['./addfurnizor.component.css']
})
export class AddfurnizorComponent implements OnInit {

  entity: Furnizor = new Furnizor();

  constructor(private _furnizorService: FurnizorService,
    private router: Router) { }

  ngOnInit(): void {
  }

  add(){
    this._furnizorService.createFurnizor(this.entity).subscribe();
    this.router.navigate(['furnizori']).then(() => {
      window.location.reload();
    });
   }

}
