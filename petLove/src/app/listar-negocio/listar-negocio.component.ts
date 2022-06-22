import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Negocios } from '../negocios';
import { Serv1Service } from '../serv1.service';

@Component({
  selector: 'app-listar-negocio',
  templateUrl: './listar-negocio.component.html',
  styleUrls: ['./listar-negocio.component.css']
})
export class ListarNegocioComponent implements OnInit {

  constructor(private serv1: Serv1Service,
    private router : Router) { }

  ngOnInit(): void {

    this.obtenerlistar();
  }

  lista : Array<Negocios> = [];

  obtenerlistar():void{
    console.log("Llammar http");
    this.serv1.obtenernegocios().subscribe((data : any)=>{
  
      this.lista = data;
      console.log(this.lista);
    })
  
    } 





}
