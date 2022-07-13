using MySql.Data.MySqlClient;
using Servicio.Entities;
using System;
using System.Collections.Generic;




namespace Servicio.Repository
{
    public class MascotaRepository
    {




        public MascotasEntity SelectID(int Id_mas)
        {
            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"select * from Mascotas where Id_mas = ?Id_mas";
                cmd.Parameters.Add("?Id_mas", MySqlDbType.Int32).Value = Id_mas;

                MascotasEntity mascotas = new MascotasEntity();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mascotas.Id_mas = Convert.ToInt32(reader["Id_mas"]);
                        mascotas.Fre_mas = Convert.ToDateTime(reader["Fre_mas"]);
                        mascotas.Usr_mas = Convert.ToInt32(reader["Usr_mas"]);
                        mascotas.Gen_mas = Convert.ToInt32(reader["Gen_mas"]);
                        mascotas.Raz_mas = Convert.ToInt32(reader["Raz_mas"]);
                        mascotas.Fna_mas = Convert.ToDateTime(reader["Fna_mas"]);
                        mascotas.Not_mas = reader["Not_mas"].ToString();
                        mascotas.Sta_mas = Convert.ToInt32(reader["Sta_mas"]);
                        

                    }
                }

                return mascotas;


            }

        }






        public List<MascotasEntity> SelectAll()
        {
            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"select * from Mascotas";

                List<MascotasEntity> Mascotas = new List<MascotasEntity>();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mascota = new MascotasEntity();
                        mascota.Id_mas = Convert.ToInt32(reader["Id_mas"]);
                        mascota.Fre_mas = Convert.ToDateTime(reader["Fre_mas"]);
                        mascota.Usr_mas = Convert.ToInt32(reader["Usr_mas"]);
                        mascota.Gen_mas = Convert.ToInt32(reader["Gen_mas"]);
                        mascota.Raz_mas = Convert.ToInt32(reader["Raz_mas"]);
                        mascota.Fna_mas = Convert.ToDateTime(reader["Fna_mas"]);
                        mascota.Not_mas = reader["Not_mas"].ToString(); 
                        mascota.Sta_mas = Convert.ToInt32(reader["Sta_mas"]);

                        Mascotas.Add(mascota);
                    }
                }

                return Mascotas;
            }

        }


 

        public void Insertar(DateTime Fre_mas, int Usr_mas, int Gen_mas, int Raz_mas, DateTime Fna_mas, string Not_mas, int Sta_mas)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=root;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"insert into Mascotas (Fre_mas,Usr_mas,Gen_mas,Raz_mas,Fna_mas,Not_mas,Sta_mas)  values (?Fre_mas,?Usr_mas,?Gen_mas,?Raz_mas,?Fna_mas,?Not_mas,?Sta_mas);";
                cmd.Parameters.Add("?Fre_mas", MySqlDbType.Date).Value = Fre_mas;
                cmd.Parameters.Add("?Usr_mas", MySqlDbType.Int16).Value = Usr_mas;
                cmd.Parameters.Add("?Gen_mas", MySqlDbType.Int16).Value = Gen_mas;
                cmd.Parameters.Add("?Raz_mas", MySqlDbType.Int16).Value = Raz_mas;
                cmd.Parameters.Add("?Fna_mas", MySqlDbType.Date).Value = Fna_mas;
                cmd.Parameters.Add("?Not_mas", MySqlDbType.String).Value = Not_mas;
                cmd.Parameters.Add("?Sta_mas", MySqlDbType.Int16).Value = Sta_mas;
               
                cmd.ExecuteReader();
            }
        }


        public void Actualizar(int Id_mas, DateTime Fre_mas, int Usr_mas, int Gen_mas, int Raz_mas, DateTime Fna_mas, string Not_mas, int Sta_mas)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"Update Mascotas set Fre_mas = ?Fre_mas, Usr_mas = ?Usr_mas, Gen_mas = ?Gen_mas, Raz_mas = ?Raz_mas, Fna_mas = ?Fna_mas, Not_mas = ?Not_mas, Sta_mas = ?Sta_mas  where Id_mas = ?Id_mas";
                cmd.Parameters.Add("?Id_mas", MySqlDbType.Int16).Value = Id_mas;
                cmd.Parameters.Add("?Fre_mas", MySqlDbType.Date).Value = Fre_mas;
                cmd.Parameters.Add("?Usr_mas", MySqlDbType.Int16).Value = Usr_mas;
                cmd.Parameters.Add("?Gen_mas", MySqlDbType.Int16).Value = Gen_mas;
                cmd.Parameters.Add("?Raz_mas", MySqlDbType.Int16).Value = Raz_mas;
                cmd.Parameters.Add("?Fna_mas", MySqlDbType.Date).Value = Fna_mas;
                cmd.Parameters.Add("?Not_mas", MySqlDbType.String).Value = Not_mas;
                cmd.Parameters.Add("?Sta_mas", MySqlDbType.Int16).Value = Sta_mas;
                cmd.ExecuteReader();
            }
        }



        public void Eliminar(int Id_mas)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"delete from Mascotas where Id_mas = ?Id_mas";
                cmd.Parameters.Add("?Id_mas", MySqlDbType.Int32).Value = Id_mas;
                cmd.ExecuteReader();
            }
        }



























































    }
}
