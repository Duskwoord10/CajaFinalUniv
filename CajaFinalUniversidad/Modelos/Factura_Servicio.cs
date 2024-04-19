using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CajaFinalUniversidad.Modelos
{
    public class Factura_Servicio
    {
        [Key]
        public int factura_id { get; set; }

        [ForeignKey("Servicio")]
        public int servicio_id{ get; set; }

        [ForeignKey("Estudiante")]
        public int estudiante_id { get; set; }

        public DateTime factura_fecha { get; set; }

        [ForeignKey("Metodo_pago")]
        public int metodo_pago_id { get; set; }

        public decimal factura_monto { get; set; }

    }
}
