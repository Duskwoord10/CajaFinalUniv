using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CajaFinalUniversidad.Modelos
{
    public class Cuenta
    {
        [Key]
        public int cuenta_id { get; set; }

        public string cuenta_nombre { get; set; }

        public string cuenta_clave { get; set; }

        [ForeignKey("Rol")]
        public int rol_id { get; set; }
        //public Rol Rol { get; set; }

    }
}
