using PractEntregable3.dao;
using System;

using System.Windows;


namespace PractEntregable3
{
    /// <summary>
    /// Lógica de interacción para pantallaRegistro.xaml
    /// </summary>
    public partial class pantallaRegistro : Window
    {
        public pantallaRegistro()
        {
            InitializeComponent();
            enviar.IsEnabled = false;
            this.WindowStyle = 0;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            UsuarioOP lop = new UsuarioOP();
            MainWindow mostrar = new MainWindow();


            try
                {
                if (!(nombre.Equals("") && usuario.Equals("") && edad.Equals("") && correo.Equals("") && apellidos.Equals("") && sexo.Equals("") && password.Equals(""))){
                    lop.registrarUsuario(usuario.Text, password.Text, nombre.Text, apellidos.Text, Convert.ToInt32(edad.Text), sexo.Text, correo.Text);
                    MessageBox.Show("Usuario registrado con éxito!");
                    this.Close();
                    mostrar.Show();
                }
                else
                {
                    MessageBox.Show("Introduzca datos en todos los campos");
                } 
                    
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("No has introducido la edad correctamente"); 
                }
            
            
            
           
                
                
                
            
            
        }

        private void check_Checked(object sender, RoutedEventArgs e)
        {
            enviar.IsEnabled = true;
        }

        private void check_Unchecked(object sender, RoutedEventArgs e)
        {
            enviar.IsEnabled = false;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mostrar = new MainWindow();
            mostrar.Show();
            this.Close();
        }
    }
}
