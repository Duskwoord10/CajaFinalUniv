using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaFinalUniversidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Mostrar el formulario de inicio de sesión (Form1) de manera modal
            if (form1.ShowDialog() == DialogResult.OK)
            {
                // Las credenciales fueron ingresadas y el usuario hizo clic en "Iniciar sesión"

                // Obtener los valores de los TextBox del formulario de inicio de sesión (Form1)
                string usuario1 = form1.usuario.Text;
                string contrasena1 = form1.contrasena.Text;

                // Validar las credenciales
                if (usuario1 == "admin" && contrasena1 == "123")
                {
                    // Si las credenciales son válidas, mostrar el formulario principal (Form2)
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    // Si las credenciales son incorrectas, mostrar un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // El usuario cerró el formulario de inicio de sesión (Form1) sin iniciar sesión
                MessageBox.Show("Inicio de sesión cancelado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
