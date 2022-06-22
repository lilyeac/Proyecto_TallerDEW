import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Serv1Service } from '../serv1.service';
import { Usuario } from '../usuario';

@Component({
  selector: 'app-listar-usuario',
  templateUrl: './listar-usuario.component.html',
  styleUrls: ['./listar-usuario.component.css']
})
export class ListarUsuarioComponent implements OnInit {

  constructor(private serv1: Serv1Service,
    private router : Router) { }
    
  ngOnInit(): void {

    this.obtenerlistar();
  }


  lista : Array<Usuario> = [];

  obtenerlistar():void{
    console.log("Llammar http");
    this.serv1.obtenerusuarios().subscribe((data : any)=>{
  
      this.lista = data;
      console.log(this.lista);
    })
  
    } 



}
