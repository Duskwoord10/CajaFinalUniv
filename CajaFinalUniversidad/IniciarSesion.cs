using System;
using System.Windows.Forms;
using System.Threading.Tasks; // Necesario para utilizar Task y async
using CajaFinalUniversidad.Servicios;

namespace CajaFinalUniversidad
{
    public partial class IniciarSesion : Form
    {
        private readonly API api; // Instancia de tu clase API para interactuar con la API

        public IniciarSesion()
        {
            InitializeComponent();
            api = new API(); // Inicializar la instancia de la clase API
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario y la contraseña ingresados por el usuario
            string usuario = textBox2.Text;
            string contrasena = txtContrasena.Text;

            try
            {
                // Realizar la autenticación llamando al método de inicio de sesión de la API
                bool autenticado = await Task.Run(() => api.IniciarSesion(usuario, contrasena));

                if (autenticado)
                {
                    // Si la autenticación es exitosa, mostrar el formulario principal (Form2)
                    Form2 form2 = new Form2();
                    form2.Show();

                    // Cerrar el formulario actual de inicio de sesión
                    this.Hide();
                }
                else
                {
                    // Si las credenciales son incorrectas, mostrar un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error durante la autenticación
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
