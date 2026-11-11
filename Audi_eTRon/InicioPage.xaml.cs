using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Audi_eTron
{
    public partial class InicioPage : Page
    {
        public InicioPage()
        {
            InitializeComponent();
        }

        // Botones del GT RS
        private void BtnVerGTRS_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
                NavigationService.Navigate(new DetallePage()); // Ficha del GT RS
        }

        private void BtnReservarPrueba_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("⚡ Solicitud de prueba de conducción registrada.\nNos pondremos en contacto para coordinar la fecha.", "Audi Experience", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Botón Q4 e-tron
        private void BtnVerQ4_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
                NavigationService.Navigate(new DetalleQ4Page()); // Ficha del Q4
        }

        // Botón Q8 e-tron
        private void BtnVerQ8_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
                NavigationService.Navigate(new DetalleQ8Page()); // Ficha del Q8
        }

        // Botón Promoción PLAN MOVES
        private void BtnSolicitarPromocion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("📋 Tramitación de ayuda Plan MOVES III iniciada.\nDescuento de hasta 7.000€ aplicable en tu compra.", "Promoción Audi e-tron", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}