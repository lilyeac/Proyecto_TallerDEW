using MySql.Data.MySqlClient;
using Servicio.Entities;
using System;
using System.Collections.Generic;

namespace Servicio.Repository
{
    public class UsuarioRepository
    {


        public UsuarioEntity SelectID(int Id_usr)
        {
            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"select * from usuarios where Id_usr = ?Id_usr";
                cmd.Parameters.Add("?Id_usr", MySqlDbType.Int32).Value = Id_usr;

                UsuarioEntity user = new UsuarioEntity();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.Id_usr = Convert.ToInt32(reader["Id_usr"]);
                        user.Login_usr = reader["Login_usr"].ToString();
                        user.Pwd_usr = reader["Pwd_usr"].ToString();
                        user.Ape_usr = reader["Ape_usr"].ToString();
                        user.Nom_usr = reader["Nom_usr"].ToString();
                        user.Ubi_usr = Convert.ToInt32(reader["Ubi_usr"]);
                        user.Cel_usr = reader["Cel_usr"].ToString();
                        user.Sta_usr = Convert.ToInt32(reader["Sta_usr"]);

    
 
                    }
                }

                return user;
            }

        }
        public List<UsuarioEntity> SelectAll()
        {
            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"select * from Usuarios";

                List<UsuarioEntity> users = new List<UsuarioEntity>();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new UsuarioEntity();
                        user.Id_usr = Convert.ToInt32(reader["Id_usr"]);
                        user.Login_usr = reader["Login_usr"].ToString();
                        user.Pwd_usr = reader["Pwd_usr"].ToString();
                        user.Ape_usr = reader["Ape_usr"].ToString();
                        user.Nom_usr = reader["Nom_usr"].ToString();
                        user.Ubi_usr = Convert.ToInt32(reader["Ubi_usr"]);
                        user.Cel_usr = reader["Cel_usr"].ToString();
                        user.Sta_usr = Convert.ToInt32(reader["Sta_usr"]);

                        users.Add(user);
                    }
                }

                return users;
            }

        }

        public void Insertar(string Login_usr, string Pwd_usr, string Ape_usr, string Nom_usr,int Ubi_usr, string Cel_usr,int Sta_usr)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"insert into usuarios (Login_usr,Pwd_usr,Ape_usr,Nom_usr,Ubi_usr,Cel_usr,Sta_usr)  values(?Login_usr,?Pwd_usr,?Ape_usr,?Nom_usr,?Ubi_usr,?Cel_usr,?Sta_usr)";
                cmd.Parameters.Add("?Login_usr", MySqlDbType.String).Value = Login_usr;
                cmd.Parameters.Add("?Pwd_usr", MySqlDbType.String).Value = Pwd_usr;
                cmd.Parameters.Add("?Ape_usr", MySqlDbType.String).Value = Ape_usr;
                cmd.Parameters.Add("?Nom_usr", MySqlDbType.String).Value = Nom_usr;
                cmd.Parameters.Add("?Ubi_usr", MySqlDbType.Int16).Value = Ubi_usr;
                cmd.Parameters.Add("?Cel_usr", MySqlDbType.String).Value = Cel_usr;
                cmd.Parameters.Add("?Sta_usr", MySqlDbType.Int16).Value = Sta_usr;
                cmd.ExecuteReader();




            }
        }

        public void Actualizar(int Id_usr, string Login_usr, string Pwd_usr, string Ape_usr, string Nom_usr, int Ubi_usr, string Cel_usr, int Sta_usr)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"Update usuarios set  Login_usr = ?Login_usr, Pwd_usr = ?Pwd_usr, Ape_usr = ?Ape_usr, Nom_usr = ?Nom_usr, Ubi_usr = ?Ubi_usr, Cel_usr = ?Cel_usr, Sta_usr = ?Sta_usr  where Id_usr = ?Id_usr";
                cmd.Parameters.Add("?Id_usr", MySqlDbType.Int16).Value = Id_usr;
                cmd.Parameters.Add("?Login_usr", MySqlDbType.String).Value = Login_usr;
                cmd.Parameters.Add("?Pwd_usr", MySqlDbType.String).Value = Pwd_usr;
                cmd.Parameters.Add("?Ape_usr", MySqlDbType.String).Value = Ape_usr;
                cmd.Parameters.Add("?Nom_usr", MySqlDbType.String).Value = Nom_usr;
                cmd.Parameters.Add("?Ubi_usr", MySqlDbType.Int16).Value = Ubi_usr;
                cmd.Parameters.Add("?Cel_usr", MySqlDbType.String).Value = Cel_usr;
                cmd.Parameters.Add("?Sta_usr", MySqlDbType.Int16).Value = Sta_usr;
                cmd.ExecuteReader();
            }
        }

        public void Eliminar(int Id_usr)
        {

            using (MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Port=3306;Database=petlove;Uid=root;password=mysql;"))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = $"delete from usuarios where Id_usr = ?Id_usr"; 
                cmd.Parameters.Add("?Id_usr", MySqlDbType.Int32).Value = Id_usr;
                cmd.ExecuteReader();
            }
        }

    }

}
