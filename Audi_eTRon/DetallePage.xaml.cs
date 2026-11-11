using System;
using System.Security.Principal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Audi_eTron
{
    public partial class DetallePage : Page
    {
        // Constructor por defecto
        public DetallePage()
        {
            InitializeComponent();
        }

        // CONSTRUCTOR DINÁMICO: Recibe los datos específicos de cada coche
        public DetallePage(string nombre, string precio, string potencia, string autonomia, string rutaImagen, string descripcion)
        {
            InitializeComponent();

            // Asignamos los textos dinámicamente a la pantalla
            txtNombreCoche.Text = nombre;
            txtPrecioCoche.Text = precio;
            txtPotenciaCoche.Text = potencia;
            txtAutonomiaCoche.Text = autonomia;
            txtDescripcionCoche.Text = descripcion;

            // Cargar la imagen correspondiente
            try
            {
                BitmapImage bitmap = new BitmapImage(new Uri(rutaImagen, UriKind.Absolute));
                imgPrincipal.Source = bitmap;
            }
            catch
            {
                // Si la ruta falla, mantiene la de por defecto
            }
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null && NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else if (NavigationService != null)
            {
                NavigationService.Navigate(new GaleriaPage());
            }
        }

        private void BtnPresupuesto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"¡Solicitud de presupuesto enviada para el {txtNombreCoche.Text}!\n\nUn asesor comercial de Audi se pondrá en contacto contigo.",
                            "Audi Experience", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}