using System;
using System.Collections.Generic;
using PractEntregable3.vo;

using MySql.Data.MySqlClient;
using System.Windows;

namespace PractEntregable3.dao
{
    class UsuarioOP
    {
        

        public List<Usuario> Login()
        {
            String sql = "SELECT * FROM usuarios";
            List<Usuario> lista = null;
            DBConnection db = new DBConnection();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader myreader = null;
            
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = db.Conex;
                Usuario u1 = null;


                db.Conectar();
                myreader = comando.ExecuteReader();
                lista = new List<Usuario>();
                while (myreader.Read())
                {
                    String username = myreader["Username"].ToString();
                    String password = myreader["Password"].ToString();
                    String nombre = myreader["Nombre"].ToString();
                    String apellidos = myreader["Apellidos"].ToString();
                    int edad = Int32.Parse(myreader["Edad"].ToString());
                    String sexo = myreader["Sexo"].ToString();
                    String correo = myreader["Correo"].ToString();

                    u1 = new Usuario(username, password, nombre, apellidos, edad, sexo, correo);
                    lista.Add(u1);
                }

                comando.ExecuteNonQuery();
                db.Desconectar();
                return lista;

            }
            catch (Exception ex)
            {
                
            }

            return lista;
        }

        public void registrarUsuario(string username, string password, string nombre, string apellidos, int edad, string sexo, string correo)
        {
            try
            {
                String sql = "Insert into usuarios values('" + username + "','" + password + "','" + nombre + "','" + apellidos + "','" + edad + "','" + sexo + "','" + correo + "')";
                DBConnection db = new DBConnection();
                MySqlCommand comando = new MySqlCommand();
                try
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = sql;
                    comando.Connection = db.Conex;

                    db.Conectar();
                    comando.ExecuteNonQuery();
                    db.Desconectar();

                }
                catch (Exception ex)
                {
                    
                }
            }catch(Exception e)
            {
                MessageBox.Show("Introduzca datos en todos los campos");
            }
            
        }
    }
}
