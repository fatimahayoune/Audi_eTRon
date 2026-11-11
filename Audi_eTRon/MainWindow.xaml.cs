using System.Windows;

namespace Audi_eTron
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Carga por defecto la pantalla de inicio
            MainFrame.Navigate(new InicioPage());
        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InicioPage());
        }

        private void BtnGaleria_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new GaleriaPage());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }
    }
}