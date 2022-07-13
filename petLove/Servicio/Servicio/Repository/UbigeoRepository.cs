using MySql.Data.MySqlClient;
using Servicio.Entities;
using System;
using System.Collections.Generic;



namespace Servicio.Repository
{
    public class UbigeoRepository
    {




        public UbigeoEntity SelectID(int Cod_ubi)
        {
            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=root;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"select * from Ubigeo where Cod_ubi = ?Cod_ubi";
                cmd.Parameters.Add("?Cod_ubi", MySqlDbType.Int32).Value = Cod_ubi;

                UbigeoEntity ubigeo = new UbigeoEntity();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ubigeo.Cod_ubi = Convert.ToInt32(reader["Cod_ubi"]);
                        ubigeo.Dis_ubi = reader["Dis_ubi"].ToString();
                        ubigeo.Prv_ubi = reader["Prv_ubi"].ToString();
                        ubigeo.Dep_ubi = reader["Dep_ubi"].ToString();
                        ubigeo.Ord_ubi = Convert.ToInt32(reader["Ord_ubi"]);
                        ubigeo.Not_ubi = reader["Not_ubi"].ToString();
                        ubigeo.Cdi_ubi = reader["Cdi_ubi"].ToString();


                    }
                }
        
                return ubigeo;
            }

        }









        public List<UbigeoEntity> SelectAll()
        {
            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"select * from Ubigeo";

                List<UbigeoEntity> ubigeos = new List<UbigeoEntity>();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ubigeo = new UbigeoEntity();
                        ubigeo.Cod_ubi = Convert.ToInt32(reader["Cod_ubi"]);
                        ubigeo.Dis_ubi = reader["Dis_ubi"].ToString();
                        ubigeo.Prv_ubi = reader["Prv_ubi"].ToString();
                        ubigeo.Dep_ubi = reader["Dep_ubi"].ToString();
                        ubigeo.Ord_ubi = Convert.ToInt32(reader["Ord_ubi"]);
                        ubigeo.Not_ubi = reader["Not_ubi"].ToString();
                        ubigeo.Cdi_ubi = reader["Cdi_ubi"].ToString();

                        ubigeos.Add(ubigeo);
                    }
                }




                return ubigeos;
            }

        }




        public void Insertar(string Dis_ubi, string Prv_ubi, string Dep_ubi, int Ord_ubi, string Not_ubi, string Cdi_ubi)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"insert into Ubigeo (Dis_ubi,Prv_ubi,Dep_ubi,Ord_ubi,Not_ubi,Cdi_ubi)  values (?Dis_ubi,?Prv_ubi,?Dep_ubi,?Ord_ubi,?Not_ubi,?Cdi_ubi);";
                cmd.Parameters.Add("?Dis_ubi", MySqlDbType.String).Value = Dis_ubi;
                cmd.Parameters.Add("?Prv_ubi", MySqlDbType.String).Value = Prv_ubi;
                cmd.Parameters.Add("?Dep_ubi", MySqlDbType.String).Value = Dep_ubi;
                cmd.Parameters.Add("?Ord_ubi", MySqlDbType.Int16).Value = Ord_ubi;
                cmd.Parameters.Add("?Not_ubi", MySqlDbType.String).Value = Not_ubi;
                cmd.Parameters.Add("?Cdi_ubi", MySqlDbType.String).Value = Cdi_ubi;
                cmd.ExecuteReader();
            }

      


        }







        public void Actualizar(int Cod_ubi, string Dis_ubi, string Prv_ubi, string Dep_ubi, int Ord_ubi, string Not_ubi, string Cdi_ubi)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"Update Ubigeo set Dis_ubi = ?Dis_ubi, Prv_ubi = ?Prv_ubi, Dep_ubi = ?Dep_ubi, Ord_ubi = ?Ord_ubi, Not_ubi = ?Not_ubi, Cdi_ubi = ?Cdi_ubi  where Cod_ubi = ?Cod_ubi";
                cmd.Parameters.Add("?Cod_ubi", MySqlDbType.Int16).Value = Cod_ubi;
                cmd.Parameters.Add("?Dis_ubi", MySqlDbType.String).Value = Dis_ubi;
                cmd.Parameters.Add("?Prv_ubi", MySqlDbType.String).Value = Prv_ubi;
                cmd.Parameters.Add("?Dep_ubi", MySqlDbType.String).Value = Dep_ubi;
                cmd.Parameters.Add("?Ord_ubi", MySqlDbType.Int16).Value = Ord_ubi;
                cmd.Parameters.Add("?Not_ubi", MySqlDbType.String).Value = Not_ubi;
                cmd.Parameters.Add("?Cdi_ubi", MySqlDbType.String).Value = Cdi_ubi;
                cmd.ExecuteReader();
            }
        }









        public void Eliminar(int Cod_ubi)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"delete from Ubigeo where Cod_ubi = ?Cod_ubi";
                cmd.Parameters.Add("?Cod_ubi", MySqlDbType.Int32).Value = Cod_ubi;
                cmd.ExecuteReader();
            }
        }




































    }
}
