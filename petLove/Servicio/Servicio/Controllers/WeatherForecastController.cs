using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Servicio.Entities;
using Servicio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }





        //Usuarios




        [HttpGet("select-id-usuarios")]
        public UsuarioEntity Get(int id)
        {
            UsuarioRepository repo = new UsuarioRepository();
            return repo.SelectID(id);
        }

        [HttpGet("select-all-usuarios")]
        public List<UsuarioEntity> Get_all()
        {
            UsuarioRepository repo = new UsuarioRepository();
            return repo.SelectAll();
        }

        [HttpPost("insertar-usuarios")]
        public int Insertar(UsuarioEntity usuarioIns)
        {
            UsuarioRepository repo = new UsuarioRepository();
            repo.Insertar(usuarioIns.Login_usr, usuarioIns.Pwd_usr, usuarioIns.Ape_usr, usuarioIns.Nom_usr, usuarioIns.Ubi_usr, usuarioIns.Cel_usr, usuarioIns.Sta_usr);
            return 1;
        }

        [HttpPost("actualizar-usuarios")]
        public int Actualizar(UsuarioEntity usuarioAct)
        {
            UsuarioRepository repo = new UsuarioRepository();
            repo.Actualizar(usuarioAct.Id_usr, usuarioAct.Login_usr, usuarioAct.Pwd_usr, usuarioAct.Ape_usr, usuarioAct.Nom_usr, usuarioAct.Ubi_usr, usuarioAct.Cel_usr, usuarioAct.Sta_usr);
            return 1;
        }

        [HttpPost("Eliminar-usuarios")]
        public int Eliminar(UsuarioEntity usuarioEli)
        {
            UsuarioRepository repo = new UsuarioRepository();
            repo.Eliminar(usuarioEli.Id_usr);
            return 1;
        }











        //Negocio


        [HttpGet("select-id-Negocios")]

        public NegociosEntity SelectIdNegocios(string idneg)
        {
            NegocioRepository repo = new NegocioRepository();
            return repo.SelectID(idneg);
        }

        [HttpGet("select-all-negocios")]
        public List<NegociosEntity> Get_all_negocios()
        {
            NegocioRepository repo = new NegocioRepository();
            return repo.SelectAll();
        }


        [HttpPost("insertar-negocios")]
        public int Insertarnegocios(NegociosEntity NegocioIns)
        {
            NegocioRepository repo = new NegocioRepository();
            repo.Insertar(NegocioIns.Nom_neg, NegocioIns.Dir_neg, NegocioIns.Ubi_neg, NegocioIns.Aqd_neg, NegocioIns.Fre_neg, NegocioIns.Sta_neg, NegocioIns.Not_neg);
            return 1;

        }



        [HttpPost("actualizar-negocios")]
        public int Actualizarnegocios(NegociosEntity NegocioAct)
        {
            NegocioRepository repo = new NegocioRepository();
            repo.Actualizar(NegocioAct.Id_neg, NegocioAct.Nom_neg, NegocioAct.Dir_neg, NegocioAct.Ubi_neg, NegocioAct.Aqd_neg, NegocioAct.Fre_neg, NegocioAct.Sta_neg, NegocioAct.Not_neg);
            return 1;
        }



        [HttpPost("Eliminar-negocios")]
        public int Eliminarnegocios(NegociosEntity NegocioEli)
        {
            NegocioRepository repo = new NegocioRepository();
            repo.Eliminar(NegocioEli.Id_neg);
            return 1;
        }









        // Ubigeo


        [HttpGet("select-id-ubigeo")]
        public UbigeoEntity Getubigeo(int idubi)
        {
            UbigeoRepository repo = new UbigeoRepository();
            return repo.SelectID(idubi);
        }


        [HttpGet("select-all-ubigeo")]
        public List<UbigeoEntity> Get_all_ubigeo()
        {
            UbigeoRepository repo = new UbigeoRepository();
            return repo.SelectAll();
        }




        [HttpPost("insertar-ubigeo")]
        public int InsertarUbigeo(string Dis_ubi, string Prv_ubi, string Dep_ubi, int Ord_ubi, string Not_ubi, string Cdi_ubi)
        {
            UbigeoRepository repo = new UbigeoRepository();
            repo.Insertar(Dis_ubi, Prv_ubi, Dep_ubi, Ord_ubi, Not_ubi, Cdi_ubi);
            return 1;
        }





        [HttpPost("actualizar-ubigeo")]
        public int ActualizarUbigeo(int Cod_ubi, string Dis_ubi, string Prv_ubi, string Dep_ubi, int Ord_ubi, string Not_ubi, string Cdi_ubi)
        {
            UbigeoRepository repo = new UbigeoRepository();
            repo.Actualizar(Cod_ubi, Dis_ubi, Prv_ubi, Dep_ubi, Ord_ubi, Not_ubi, Cdi_ubi);
            return 1;
        }




        [HttpPost("Eliminar-ubigeo")]
        public int Eliminarubigeo(int Cod_ubi)
        {
            UbigeoRepository repo = new UbigeoRepository();
            repo.Eliminar(Cod_ubi);
            return 1;
        }




        //Mascotas




        [HttpGet("select-id-mascotas")]
        public MascotasEntity GetMascotas(int idmas)
        {
            MascotaRepository repo = new MascotaRepository();
            return repo.SelectID(idmas);
        }


        [HttpGet("select-all-mascotas")]
        public List<MascotasEntity> Get_all_Mascotas()
        {
            MascotaRepository repo = new MascotaRepository();
            return repo.SelectAll();
        }




        [HttpPost("insertar-mascotas")]
        public int InsertarMascotas(MascotasEntity MascotasIns)
        {
            MascotaRepository repo = new MascotaRepository();
            repo.Insertar(MascotasIns.Fre_mas, MascotasIns.Usr_mas, MascotasIns.Gen_mas, MascotasIns.Raz_mas, MascotasIns.Fna_mas, MascotasIns.Not_mas, MascotasIns.Sta_mas);
            return 1;
        }





        [HttpPost("actualizar-mascotas")]
        public int ActualizarMascotas(MascotasEntity MascotasAct)
        {
            MascotaRepository repo = new MascotaRepository();
            repo.Actualizar(MascotasAct.Id_mas, MascotasAct.Fre_mas, MascotasAct.Usr_mas, MascotasAct.Gen_mas, MascotasAct.Raz_mas, MascotasAct.Fna_mas, MascotasAct.Not_mas, MascotasAct.Sta_mas);
            return 1;
        }




        [HttpPost("Eliminar-mascotas")]
        public int EliminarMascotas(MascotasEntity MascotasEli)
        {
            MascotaRepository repo = new MascotaRepository();
            repo.Eliminar(MascotasEli.Id_mas);
            return 1;
        }















    }
}
