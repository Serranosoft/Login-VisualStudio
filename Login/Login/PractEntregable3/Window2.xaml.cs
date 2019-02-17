using System;
using System.Collections.Generic;

using System.Windows;

using System.Net;
using System.Net.Mail;
using PractEntregable3.vo;
using PractEntregable3.dao;

namespace PractEntregable3
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            this.WindowStyle = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UsuarioOP lop = new UsuarioOP();
            List<Usuario> lista = lop.Login();
            String email = "";
            String usuario = "";
            String contraseña = "";
            for (int i = 0; i < lista.Count; i++)
            {
                
                if (lista[i].getUsername().Equals(nombre.Text))
                {
                    usuario = lista[i].getUsername();
                    contraseña = lista[i].getPassword().ToString();
                    email = lista[i].getCorreo();
                    
                }
            }
            try
            {
                var fromAddress = new MailAddress("desarrollointerfaces1819@gmail.com", "Servicio de Autenticación de Manuel Serrano");
                var toAddress = new MailAddress(email, usuario);
                const string fromPassword = "interfaces1819";
                const string subject = "Recuperacion de contraseña";
                string body = "Recuperación de contraseña. Usuario: " + usuario + " Contraseña: " + contraseña;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    MessageBox.Show("Se ha reenviado la contraseña correctamente");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("El usuario no existe");
            }
            
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mostrar = new MainWindow();
            mostrar.Show();
            this.Close();
        }
    }
}
