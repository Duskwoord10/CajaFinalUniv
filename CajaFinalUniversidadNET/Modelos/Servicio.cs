using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CajaFinalUniversidad.Modelos
{
    public class Servicio
    {
        [Key]
        public int servicio_id { get; set; }

        public string servicio_nombre { get; set; }

        public decimal servicio_costo { get; set; }
    }
}
