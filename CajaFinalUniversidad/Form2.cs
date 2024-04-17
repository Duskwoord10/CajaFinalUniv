using CajaFinalUniversidad.Servicios;
using CajaFinalUniversidad.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UniversidadAPI.Models;

namespace CajaFinalUniversidad
{
    public partial class Form2 : Form
    {
        API api=new API();
        public Form2()
        {
            InitializeComponent();
        }

        private void Asignaturas1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            // Configurar el estilo del borde del formulario para que no sea redimensionable
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Borde fijo, no redimensionable

            // Establecer el tamaño máximo del formulario (opcional)
            this.MaximumSize = new System.Drawing.Size(1000, 1000); // Tamaño máximo del formulario (ancho, alto)

            // Mostrar solo la fecha actual en el formato "dd/MM/yyyy"
            label3.Text = DateTime.Now.ToString("dd/MM/yyyy");
            var listEstudiante = api.ConsultaEstudiante();
            var bindingList = new BindingList<Estudiante>(listEstudiante);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tabla griewvield 

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbCosto_Click(object sender, EventArgs e)
        {

        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            //boton pagar 
            decimal MontoTotal =0;
            
            
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                MontoTotal += Convert.ToDecimal(row.Cells["seleccion_creditos"].Value)* 4220;
                Cuentas_cobrar cuentas_Cobrar = new Cuentas_cobrar()
                {
                    cuenta_estado = Estado_cuenta.Pendiente,
                    seleccion_id = Convert.ToInt16(row.Cells["seleccion_id"].Value) ,
                    estudiante_id = Convert.ToInt16(row.Cells["estudiante_id"].Value),
                    cuenta_monto_pendiente =MontoTotal,
                    cuenta_monto_total = MontoTotal,
                };
                api.CrearCuentaPorCobrar(cuentas_Cobrar);
                
            }
           
        }

       

       

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            //btn consultar

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            var id = Convert.ToInt16(selectedRow.Cells["estudiante_id"].Value);
           
            var listSeleccion = api.ConsultaSeleccion(id);
            var bindingList = new BindingList<Seleccion>(listSeleccion);
            var source = new BindingSource(bindingList, null);
            dataGridView2.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
