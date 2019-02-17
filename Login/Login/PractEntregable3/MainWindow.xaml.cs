using PractEntregable3.dao;
using PractEntregable3.vo;

using System.Collections.Generic;

using System.Windows;
using System.Windows.Input;

namespace PractEntregable3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //CREATE TABLE Usuarios(username VARCHAR(20) PRIMARY KEY, password VARCHAR(20), nombre VARCHAR(20), apellidos VARCHAR(40), edad INT(3), sexo VARCHAR(10), correo VARCHAR(30));



        private void Login_Click(object sender, RoutedEventArgs e)
        {
            UsuarioOP lop = new UsuarioOP();
            List<Usuario> lista = lop.Login();
            bool si = false;

            for(int i = 0; i < lista.Count; i++)
            {
                
                if (lista[i].getUsername().Equals(Username.Text) && lista[i].getPassword().Equals(Contraseña.Text)){
                    si = true;
                    
                    Window1 mostrar = new Window1();
                    mostrar.ShowDialog();
                    this.Close();
                }

                
            }

            if (!si)
            {
                MessageBox.Show("El usuario o contraseña es incorrecto o no existe");
            }
            

        }

        private void Registrarse_Click(object sender, RoutedEventArgs e)
        {
            pantallaRegistro mostrar = new pantallaRegistro();
            mostrar.ShowDialog();
            this.Close();
        }

        private void Recuperar_Click(object sender, RoutedEventArgs e)
        {
            Window2 mostrar = new Window2();
            mostrar.ShowDialog();
            this.Close();
        }
    }
}
