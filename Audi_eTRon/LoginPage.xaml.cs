using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Audi_eTron
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string password = txtPassword.Password.Trim();

            // 1. Control de Errores: Campos vacíos
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                lblMensajeError.Text = "⚠️ Por favor, introduce el usuario y la contraseña.";
                panelError.Visibility = Visibility.Visible;
                txtUsuario.Focus();
                return;
            }

            // 2. Control de Credenciales de prueba
            if (user == "Alumno" && password == "1234")
            {
                panelError.Visibility = Visibility.Collapsed;
                MessageBox.Show("¡Bienvenido/a al portal Audi e-tron!", "Acceso Concedido", MessageBoxButton.OK, MessageBoxImage.Information);

                // REDIRECCIÓN: Navega automáticamente a la portada al iniciar sesión
                if (NavigationService != null)
                {
                    NavigationService.Navigate(new InicioPage());
                }
            }
            else
            {
                // 3. Control de Errores: Credenciales incorrectas
                lblMensajeError.Text = "❌ El usuario o la contraseña son incorrectos. (Prueba con Alumno / 1234)";
                panelError.Visibility = Visibility.Visible;
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}