using System;
using System.Windows.Forms;

namespace CajaFinalUniversidad
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el formulario de inicio de sesión (IniciarSesion)
            using (var iniciarSesionForm = new IniciarSesion())
            {
                // Mostrar el formulario de inicio de sesión de manera modal
                if (iniciarSesionForm.ShowDialog() == DialogResult.OK)
                {
                    // Autenticación exitosa, mostrar el formulario principal (MainForm)
                    using (var IniciarSesion = new IniciarSesion())
                    {
                        Application.Run(IniciarSesion);
                    }
                }
                else
                {
                    // El usuario canceló el inicio de sesión, salir de la aplicación
                    MessageBox.Show("Inicio de sesión cancelado. La aplicación se cerrará.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Salir del método Main() y terminar la aplicación
                }
            }
        }
    }
}
