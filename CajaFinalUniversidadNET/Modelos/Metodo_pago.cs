using System.ComponentModel.DataAnnotations;

namespace CajaFinalUniversidad.Modelos
{
    public class Metodo_pago
    {
        [Key]
        public int metodo_pago_id { get; set; }

        public string nombre_metodo { get; set; }
    }
}
