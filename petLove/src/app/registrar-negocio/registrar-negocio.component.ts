import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Serv1Service } from '../serv1.service';

@Component({
  selector: 'app-registrar-negocio',
  templateUrl: './registrar-negocio.component.html',
  styleUrls: ['./registrar-negocio.component.css']
})
export class RegistrarNegocioComponent implements OnInit {

  negocios: FormGroup;

  constructor(private serv1: Serv1Service,
    private router : Router) { }

  ngOnInit(): void {

    this.negocios = new FormGroup({
      Id_neg : new FormControl("", Validators.required),
      Nom_neg : new FormControl("", Validators.required),
      Dir_neg : new FormControl("", Validators.required),
      Ubi_neg : new FormControl("", Validators.required),
      Aqd_neg : new FormControl("", Validators.required),
      Fre_neg : new FormControl("", Validators.required),
      Sta_neg : new FormControl("", Validators.required),
      Not_neg : new FormControl("", Validators.required),
   

    });


  }


  Agregar(): void {

    var json ={
      "Id_neg": this.negocios.get("Id_neg")?.value,
      "Nom_neg": this.negocios.get("Nom_neg")?.value,
      "Dir_neg": this.negocios.get("Dir_neg")?.value,
      "Ubi_neg": this.negocios.get("Ubi_neg")?.value,
      "Aqd_neg": this.negocios.get("Aqd_neg")?.value,
      "Fre_neg": this.negocios.get("Fre_neg")?.value,
      "Sta_neg": this.negocios.get("Sta_neg")?.value,
      "Not_neg": this.negocios.get("Not_neg")?.value,
    }


    
    this.serv1.agregarnegocios(json).subscribe((data: any)=>{
      
      this.negocios.reset();
    })

    
    }









}
