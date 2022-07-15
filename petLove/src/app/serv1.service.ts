import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Usuario } from './usuario';

@Injectable({
  providedIn: 'root'
})
export class Serv1Service {

  constructor(private httpClient: HttpClient) { }



  agregarusuarios(model: any):any{
    
    return this.httpClient.post<any>("http://localhost:10995/WeatherForecast/insertar-usuarios", model);
  }


   actualizarusuarios(model: any):any{
    
    return this.httpClient.post<any>("http://localhost:10995/WeatherForecast/actualizar-usuarios", model);
  }

  obtenerusuarios():any{
    
    return this.httpClient.get<Array<Usuario>>("http://localhost:10995/WeatherForecast/select-all-usuarios");
    
  }

  obtenernegocios():any{
    
    return this.httpClient.get<Array<Usuario>>("http://localhost:10995/WeatherForecast/select-all-negocios");
    
  }


  agregarnegocios(model: any):any{
    
    return this.httpClient.post<any>("http://localhost:10995/WeatherForecast/insertar-negocios", model);
  }











}
