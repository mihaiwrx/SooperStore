export class Furnizor{
  id: number;
  nume: string;
  oras: string;
  contact: string;
}

export class Furnizori{
  item: Furnizor;
  numar: number;
  constructor(x: Furnizor){
      this.item = x;
      this.numar = 1;
  }
}
