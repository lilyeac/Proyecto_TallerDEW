import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Serv1Service } from '../serv1.service';

@Component({
  selector: 'app-editar-perfil',
  templateUrl: './editar-perfil.component.html',
  styleUrls: ['./editar-perfil.component.css']
})
export class EditarPerfilComponent implements OnInit {

  usuarios: FormGroup;


  constructor(private serv1: Serv1Service,
    private router : Router) { }

  ngOnInit(): void {

    this.usuarios = new FormGroup({
      Id_usr : new FormControl("", Validators.required),
      Login_usr : new FormControl("", Validators.required),
      Pwd_usr : new FormControl("", Validators.required),
      Ape_usr : new FormControl("", Validators.required),
      Nom_usr : new FormControl("", Validators.required),
      Ubi_usr : new FormControl("", Validators.required),
      Cel_usr : new FormControl("", Validators.required),
      Sta_usr : new FormControl("", Validators.required),
   

    });




  }


  Actualizar(): void {

    var json ={
      "Id_usr": this.usuarios.get("Id_usr")?.value,
      "Login_usr": this.usuarios.get("Login_usr")?.value,
      "Pwd_usr": this.usuarios.get("Pwd_usr")?.value,
      "Ape_usr": this.usuarios.get("Ape_usr")?.value,
      "Nom_usr": this.usuarios.get("Nom_usr")?.value,
      "Ubi_usr": this.usuarios.get("Ubi_usr")?.value,
      "Cel_usr": this.usuarios.get("Cel_usr")?.value,
      "Sta_usr": this.usuarios.get("Sta_usr")?.value,
    }

    this.serv1.actualizarusuarios(json).subscribe((data: any)=>{
      
      this.usuarios.reset();
    })



}
}