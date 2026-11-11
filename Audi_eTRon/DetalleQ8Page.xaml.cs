using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Audi_eTron
{
    public partial class DetalleQ8Page : Page
    {
        public DetalleQ8Page()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null && NavigationService.CanGoBack)
                NavigationService.GoBack();
            else if (NavigationService != null)
                NavigationService.Navigate(new GaleriaPage());
        }

        private void BtnPresupuesto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¡Solicitud de presupuesto enviada para el Audi Q8 e-tron!\nUn asesor te contactará.", "Audi e-tron", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}