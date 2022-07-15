using MySql.Data.MySqlClient;
using Servicio.Entities;
using System;
using System.Collections.Generic;


namespace Servicio.Repository
{
    public class NegocioRepository
    {


        public NegociosEntity SelectID(string idU)
        {
            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"select * from negocios where Id_neg = ?id";
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = idU;

                NegociosEntity negocio = new NegociosEntity();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        negocio.Id_neg = Convert.ToInt32(reader["Id_neg"]);
                        negocio.Nom_neg = reader["Nom_neg"].ToString();
                        negocio.Dir_neg = reader["Dir_neg"].ToString();
                        negocio.Ubi_neg = Convert.ToInt32(reader["Ubi_neg"]);
                        negocio.Aqd_neg = reader["Aqd_neg"].ToString();
                        negocio.Fre_neg = Convert.ToDateTime(reader["Fre_neg"]);
                        negocio.Sta_neg = Convert.ToInt32(reader["Sta_neg"]);
                        negocio.Not_neg = reader["Not_neg"].ToString();
                        
                    }
                }

                return negocio;
            }

        }






        public List<NegociosEntity> SelectAll()
        {
            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=root;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"select * from negocios";

                List<NegociosEntity> negocios = new List<NegociosEntity>();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var negocio = new NegociosEntity();
                        negocio.Id_neg = Convert.ToInt32(reader["Id_neg"]);
                        negocio.Nom_neg = reader["Nom_neg"].ToString();
                        negocio.Dir_neg = reader["Dir_neg"].ToString();
                        negocio.Ubi_neg = Convert.ToInt32(reader["Ubi_neg"]);
                        negocio.Aqd_neg = reader["Aqd_neg"].ToString();
                        negocio.Fre_neg = Convert.ToDateTime(reader["Fre_neg"]);
                        negocio.Sta_neg = Convert.ToInt32(reader["Sta_neg"]);
                        negocio.Not_neg = reader["Not_neg"].ToString();

                        negocios.Add(negocio);
                    }
                }

                return negocios;
            }

        }




        public void Insertar(string Nom_neg, string Dir_neg, int Ubi_neg, string Aqd_neg, string Fre_neg, int Sta_neg, string Not_neg)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"insert into Negocios (Nom_neg,Dir_neg,Ubi_neg,Aqd_neg,Fre_neg,Sta_neg,Not_neg)  values (?Nom_neg,?Dir_neg,?Ubi_neg,?Aqd_neg,?Fre_neg,?Sta_neg,?Not_neg);";
                cmd.Parameters.Add("?Nom_neg", MySqlDbType.String).Value = Nom_neg;
                cmd.Parameters.Add("?Dir_neg", MySqlDbType.String).Value = Dir_neg;
                cmd.Parameters.Add("?Ubi_neg", MySqlDbType.Int16).Value = Ubi_neg;
                cmd.Parameters.Add("?Aqd_neg", MySqlDbType.String).Value = Aqd_neg;
                cmd.Parameters.Add("?Fre_neg", MySqlDbType.String).Value = Fre_neg;
                cmd.Parameters.Add("?Sta_neg", MySqlDbType.Int16).Value = Sta_neg;
                cmd.Parameters.Add("?Not_neg", MySqlDbType.String).Value = Not_neg;
                cmd.ExecuteReader();
            }
        }


        public void Actualizar(int Id_neg, string Nom_neg, string Dir_neg, int Ubi_neg, string Aqd_neg, DateTime Fre_neg, int Sta_neg, string Not_neg)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"Update Negocios set Nom_neg = ?Nom_neg, Dir_neg = ?Dir_neg, Ubi_neg = ?Ubi_neg, Aqd_neg = ?Aqd_neg, Fre_neg = ?Fre_neg, Sta_neg = ?Sta_neg, Not_neg = ?Not_neg  where Id_neg = ?Id_neg";
                cmd.Parameters.Add("?Id_neg", MySqlDbType.Int32).Value = Id_neg;
                cmd.Parameters.Add("?Nom_neg", MySqlDbType.String).Value = Nom_neg;
                cmd.Parameters.Add("?Dir_neg", MySqlDbType.String).Value = Dir_neg;
                cmd.Parameters.Add("?Ubi_neg", MySqlDbType.Int16).Value = Ubi_neg;
                cmd.Parameters.Add("?Aqd_neg", MySqlDbType.String).Value = Aqd_neg;
                cmd.Parameters.Add("?Fre_neg", MySqlDbType.Date).Value = Fre_neg;
                cmd.Parameters.Add("?Sta_neg", MySqlDbType.Int16).Value = Sta_neg;
                cmd.Parameters.Add("?Not_neg", MySqlDbType.String).Value = Not_neg;
                cmd.ExecuteReader();
            }
        }



        public void Eliminar(int Id_neg)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"delete from Negocios where Id_neg = ?Id_neg";
                cmd.Parameters.Add("?Id_neg", MySqlDbType.Int32).Value = Id_neg;
                cmd.ExecuteReader();
            }
        }






    }
}
