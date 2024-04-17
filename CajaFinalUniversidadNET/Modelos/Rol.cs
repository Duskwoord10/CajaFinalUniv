using System.ComponentModel.DataAnnotations;

namespace CajaFinalUniversidad.Modelos
{
    public class Rol
    {
        [Key]
        public int rol_id { get; set; }

        public string rol_nombre{ get; set; }
    }
}
