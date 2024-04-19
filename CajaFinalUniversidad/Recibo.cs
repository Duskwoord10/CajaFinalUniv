using CajaFinalUniversidad.Modelos;
using CajaFinalUniversidad.Servicios;
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
    public partial class Recibo : Form
    {
        API api = new API();

        public Recibo()
        {
            InitializeComponent();
        }

        private void Recibo_Load(object sender, EventArgs e)
        {
            //recibo form 
            var listEstudiante = api.ConsultaFactura();
            var bindingList = new BindingList<Factura_pago>(listEstudiante);
            var source = new BindingSource(bindingList, null);

            decimal totalPendiente  = 0;

            dataGridView1.DataSource = source;




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
