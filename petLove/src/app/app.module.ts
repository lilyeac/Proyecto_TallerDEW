import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegistrarseComponent } from './registrarse/registrarse.component';
import { EditarPerfilComponent } from './editar-perfil/editar-perfil.component';
import { RecuperaContraseniaComponent } from './recupera-contrasenia/recupera-contrasenia.component';
import { InsertMacotaComponent } from './insert-macota/insert-macota.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { EliminarUsuarioComponent } from './eliminar-usuario/eliminar-usuario.component';
import { ListarUsuarioComponent } from './listar-usuario/listar-usuario.component';
import { RegistrarNegocioComponent } from './registrar-negocio/registrar-negocio.component';
import { ActualizarNegocioComponent } from './actualizar-negocio/actualizar-negocio.component';
import { ListarNegocioComponent } from './listar-negocio/listar-negocio.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    RegistrarseComponent,
    EditarPerfilComponent,
    RecuperaContraseniaComponent,
    InsertMacotaComponent,
    NavbarComponent,
    EliminarUsuarioComponent,
    ListarUsuarioComponent,
    RegistrarNegocioComponent,
    ActualizarNegocioComponent,
    ListarNegocioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
