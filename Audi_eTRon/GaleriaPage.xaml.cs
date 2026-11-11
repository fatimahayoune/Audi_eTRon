using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace Audi_eTron
{
    public partial class GaleriaPage : Page
    {
        public GaleriaPage()
        {
            InitializeComponent();

            // Animación Fade-in al cargar la pantalla
            Loaded += (s, e) =>
            {
                DoubleAnimation fade = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.35));
                this.BeginAnimation(OpacityProperty, fade);
            };
        }

        // --- NAVEGACIÓN A PÁGINAS DEDICADAS (MODELOS DESTACADOS) ---
        private void BtnGTRS_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
                NavigationService.Navigate(new DetallePage());
        }

        private void BtnQ4_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
                NavigationService.Navigate(new DetalleQ4Page());
        }

        private void BtnQ8_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService != null)
                NavigationService.Navigate(new DetalleQ8Page());
        }

        // --- INTERACTIVIDAD CON MENSAJES EDITORIALES PARA MODELOS SECUNDARIOS ---
        private void BtnQ6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ficha técnica del Audi Q6 e-tron:\n- Autonomía: 625 km\n- Carga ultra rápida: 270 kW\n- Disponibilidad: Pedidos abiertos en Concesionario Oficial.", "Audi e-tron", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnQ4Sportback_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ficha técnica del Audi Q4 Sportback e-tron:\n- Coeficiente Cx: 0.26\n- Potencia: 286 CV\n- Maletero: 535 Litros.", "Audi e-tron", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnQ8SLine_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ficha técnica del Audi Q8 e-tron S Line:\n- Paquete exterior S Line deportivo\n- Suspensión neumática adaptativa\n- Llantas Audi Sport 21\".", "Audi e-tron", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}