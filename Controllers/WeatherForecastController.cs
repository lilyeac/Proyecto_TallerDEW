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










        [HttpGet("select-id - Usuarios")]
        public UsuarioEntity Get(int id)
        {
            UsuarioRepository repo = new UsuarioRepository();
            return repo.SelectID(id);
        }

        [HttpGet("select-all - Usuarios")]
        public List<UsuarioEntity> Get_all()
        {
            UsuarioRepository repo = new UsuarioRepository();
            return repo.SelectAll();
        }

        [HttpPost("insertar - Usuarios")]
        public int Insertar(string Login_usr, string Pwd_usr, string Ape_usr, string Nom_usr, int Ubi_usr, string Cel_usr, int Sta_usr)
        {
            UsuarioRepository repo = new UsuarioRepository();
            repo.Insertar(Login_usr, Pwd_usr, Ape_usr, Nom_usr, Ubi_usr, Cel_usr, Sta_usr);
            return 1;
        }

        [HttpPost("actualizar - Usuarios")]
        public int Actualizar(int Id_usr, string Login_usr, string Pwd_usr, string Ape_usr, string Nom_usr, int Ubi_usr, string Cel_usr, int Sta_usr)
        {
            UsuarioRepository repo = new UsuarioRepository();
            repo.Actualizar(Id_usr,Login_usr, Pwd_usr, Ape_usr, Nom_usr, Ubi_usr, Cel_usr, Sta_usr);
            return 1;
        }

        [HttpPost("Eliminar - Usuarios")]
        public int Eliminar(int Id_usr)
        {
            UsuarioRepository repo = new UsuarioRepository();
            repo.Eliminar(Id_usr);
            return 1;
        }














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
        public int Insertarnegocios(string Nom_neg, string Dir_neg, int Ubi_neg, string Aqd_neg, DateTime Fre_neg, int Sta_neg, string Not_neg)
        {
            NegocioRepository repo = new NegocioRepository();
            repo.Insertar(Nom_neg, Dir_neg, Ubi_neg, Aqd_neg, Fre_neg, Sta_neg, Not_neg);
            return 1;

        }



        [HttpPost("actualizar-negocios")]
        public int Actualizarnegocios(int Id_neg, string Nom_neg, string Dir_neg, int Ubi_neg, string Aqd_neg, DateTime Fre_neg, int Sta_neg, string Not_neg)
        {
            NegocioRepository repo = new NegocioRepository();
            repo.Actualizar(Id_neg, Nom_neg, Dir_neg, Ubi_neg, Aqd_neg, Fre_neg, Sta_neg, Not_neg);
            return 1;
        }



        [HttpPost("Eliminar-negocios")]
        public int Eliminarnegocios(int Id_neg)
        {
            NegocioRepository repo = new NegocioRepository();
            repo.Eliminar(Id_neg);
            return 1;
        }












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
        public int InsertarMascotas(DateTime Fre_mas, int Usr_mas, int Gen_mas, int Raz_mas, DateTime Fna_mas, string Not_mas, int Sta_mas)
        {
            MascotaRepository repo = new MascotaRepository();
            repo.Insertar(Fre_mas, Usr_mas, Gen_mas, Raz_mas, Fna_mas, Not_mas, Sta_mas);
            return 1;
        }





        [HttpPost("actualizar-mascotas")]
        public int ActualizarMascotas(int Id_mas, DateTime Fre_mas, int Usr_mas, int Gen_mas, int Raz_mas, DateTime Fna_mas, string Not_mas, int Sta_mas)
        {
            MascotaRepository repo = new MascotaRepository();
            repo.Actualizar(Id_mas,Fre_mas, Usr_mas, Gen_mas, Raz_mas, Fna_mas, Not_mas, Sta_mas);
            return 1;
        }




        [HttpPost("Eliminar-mascotas")]
        public int EliminarMascotas(int Cod_ubi)
        {
            MascotaRepository repo = new MascotaRepository();
            repo.Eliminar(Cod_ubi);
            return 1;
        }















    }
}
