export class Produs{
    id: number;
    descriere: string;
    nume: string;
    pret: number;
    stoc: number;
    numeCategorie: string;
    numeFurnizor: string;
    furnizorId: string;
    categorieId: string;
}

export class Produse{
    item: Produs;
    numar: number;
    constructor(x: Produs){
        this.item = x;
        this.numar = 1;
    }
}