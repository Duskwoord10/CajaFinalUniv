using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CajaFinalUniversidad.Modelos
{
    public enum Estado_cuenta { Pago, Pendiente}

    public class Cuentas_cobrar
    {
        [Key]
        public int cuenta_cobrar_id { get; set; }

        public Estado_cuenta cuenta_estado { get; set; }

        [ForeignKey("Seleccion")]
        public int seleccion_id { get; set; }

        [ForeignKey("Estudiante")]
        public int estudiante_id { get; set; }

        public decimal cuenta_monto_pendiente { get; set; }

        public decimal cuenta_monto_total { get; set; }

    }
}
