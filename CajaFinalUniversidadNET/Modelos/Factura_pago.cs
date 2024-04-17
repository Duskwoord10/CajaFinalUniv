using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CajaFinalUniversidad.Modelos
{
    public class Factura_pago
    {
        [Key]
        public int pago_id { get; set; }

        [ForeignKey("Cuentas_cobrar")]
        public int cuenta_cobrar_id { get; set; }

        [ForeignKey("Metodo_pago")]
        public int metodo_pago_id{ get; set; }

        public decimal factura_monto { get; set; }

        public DateOnly fecha_factura { get; set; }
    }
}
