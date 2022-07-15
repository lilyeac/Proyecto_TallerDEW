import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

//import { ApartmentListComponent } from "./app./admin/apartment/apartment-list/apartment-list.component";
//import { ApartmentNewComponent } from "./admin/apartment/apartment-new/apartment-new.component";
//import { ProjectListComponent } from "./admin/project/project-list/project-list.component";
//import { ProjectNewComponent } from "./admin/project/project-new/project-new.component";
//import { AboutusComponent } from "./pages/aboutus/aboutus.component";
//import { ContactoComponent } from "./contacto/contacto.component";
import { HomeComponent } from "./home/home.component";
import { ActualizarNegocioComponent } from "./actualizar-negocio/actualizar-negocio.component";
import {ContactoComponent } from "./contacto/contacto.component";
import { EditarPerfilComponent } from './editar-perfil/editar-perfil.component';
import { EliminarUsuarioComponent } from './eliminar-usuario/eliminar-usuario.component';
import { InsertMacotaComponent } from './insert-macota/insert-macota.component';
import { ListarNegocioComponent } from './listar-negocio/listar-negocio.component';
import { ListarUsuarioComponent } from './listar-usuario/listar-usuario.component';
import { LoginComponent } from './login/login.component';
import { RecuperaContraseniaComponent } from './recupera-contrasenia/recupera-contrasenia.component';
import { RegistrarseComponent } from './registrarse/registrarse.component';
import { NavbarComponent } from './navbar/navbar.component';

const routes: Routes = [

  
{ path: 'home', component: HomeComponent },
{ path: 'contacto', component: ContactoComponent },
{ path: 'actualizar-negocio', component: ActualizarNegocioComponent },
{ path: 'editar-perfil', component: EditarPerfilComponent },
{ path: 'eliminar-perfil', component: EliminarUsuarioComponent },
{ path: 'insert-macota', component: InsertMacotaComponent },
{path: 'listar-negocio', component: ListarNegocioComponent},
{path: 'listar-usuario', component: ListarUsuarioComponent},
{path: 'login', component: LoginComponent},
{path: 'recuperar-contrasenia', component: RecuperaContraseniaComponent},
{path: 'registrarse', component: RegistrarseComponent},
//{path: 'navbar', component: NavbarComponent},


{ path: '', redirectTo: 'home', pathMatch: 'full' },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
