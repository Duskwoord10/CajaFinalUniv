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

            // Mostrar el formulario de inicio de sesi�n (IniciarSesion)
            using (var iniciarSesionForm = new IniciarSesion())
            {
                // Mostrar el formulario de inicio de sesi�n de manera modal
                if (iniciarSesionForm.ShowDialog() == DialogResult.OK)
                {
                    // Autenticaci�n exitosa, mostrar el formulario principal (MainForm)
                    using (var IniciarSesion = new IniciarSesion())
                    {
                        Application.Run(IniciarSesion);
                    }
                }
                else
                {
                    // El usuario cancel� el inicio de sesi�n, salir de la aplicaci�n
                    MessageBox.Show("Inicio de sesi�n cancelado. La aplicaci�n se cerrar�.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Salir del m�todo Main() y terminar la aplicaci�n
                }
            }
        }
    }
}
