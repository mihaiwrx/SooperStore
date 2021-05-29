import { FurnizorService } from 'src/app/services/furnizor.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Furnizor } from 'src/app/interfaces/furnizor.interface';

@Component({
  selector: 'app-editfurnizor',
  templateUrl: './editfurnizor.component.html',
  styleUrls: ['./editfurnizor.component.css']
})
export class EditfurnizorComponent implements OnInit {
  entity: Furnizor = new Furnizor();
  id: number;
  private sub: any;

  constructor(private _furnizorService: FurnizorService,
    private router: Router,
    private route: ActivatedRoute,) { }

  ngOnInit(): void {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
   });
   this._furnizorService.getFurnizor(this.id).subscribe((item: Furnizor)=>{
       this.entity=item;
   })
  }

  update(){
    this._furnizorService.updateFurnizor(this.entity, this.id).subscribe();
    this.router.navigate(['furnizori']).then(() => {
      window.location.reload();
    });
   }

}
