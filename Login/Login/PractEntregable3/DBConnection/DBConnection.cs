using MySql.Data.MySqlClient;
using System;

using System.Windows;

namespace PractEntregable3
{
    class DBConnection
    {

        public MySqlConnection Conex = new MySqlConnection();
        static string serv = "Server=localhost;";
        static string db = "Database=wpf;";
        static string usuario = "UID=root;";
        static string pwd = "Password = 123456;";

        string CadenaDeConexion = serv + db + usuario + pwd;


        public void Conectar()
        {
            try
            {
                Conex.ConnectionString = CadenaDeConexion;
                Conex.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public void Desconectar()
        {
            Conex.Close();
        }
    }
}
