
using System.Windows;


namespace PractEntregable3
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.WindowStyle = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mostrar = new MainWindow();
            mostrar.Show();
            this.Close();
        }
    }
}
