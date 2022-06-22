import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormGroupName, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Serv1Service } from '../serv1.service';
import { Usuario } from '../usuario';

@Component({
  selector: 'app-registrarse',
  templateUrl: './registrarse.component.html',
  styleUrls: ['./registrarse.component.css']
})
export class RegistrarseComponent implements OnInit {

usuarios: FormGroup;


  constructor(private serv1: Serv1Service,
    private router : Router) { }

  ngOnInit(): void {

    this.usuarios = new FormGroup({
      Login_usr : new FormControl("", Validators.required),
      Pwd_usr : new FormControl("", Validators.required),
      Ape_usr : new FormControl("", Validators.required),
      Nom_usr : new FormControl("", Validators.required),
      Ubi_usr : new FormControl("", Validators.required),
      Cel_usr : new FormControl("", Validators.required),
      Sta_usr : new FormControl("", Validators.required),
   

    });



  }



  Agregar(): void {

    var json ={
      "Login_usr": this.usuarios.get("Login_usr")?.value,
      "Pwd_usr": this.usuarios.get("Pwd_usr")?.value,
      "Ape_usr": this.usuarios.get("Ape_usr")?.value,
      "Nom_usr": this.usuarios.get("Nom_usr")?.value,
      "Ubi_usr": this.usuarios.get("Ubi_usr")?.value,
      "Cel_usr": this.usuarios.get("Cel_usr")?.value,
      "Sta_usr": this.usuarios.get("Sta_usr")?.value,
    }


    
    this.serv1.agregarusuarios(json).subscribe((data: any)=>{
      
      this.usuarios.reset();
    })

    
    }




}
