
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversidadAPI.Models;

namespace CajaFinalUniversidad.Modelos
{
    public class Profesor
    {
        [Key]
        public int profesor_id { get; set; }

        public string profesor_nombres { get; set; }

        public string profesor_apellidos { get; set; }

        [ForeignKey("Tipo_documento")]
        public int tipo_documento_id { get; set; }
        //public Tipo_documento Tipo_documento { get; set; }

        public string profesor_documento { get; set; }

        [ForeignKey("Cuenta")]
        public int id_cuenta { get; set; }
        //public Cuenta Cuenta { get; set; }
    }
}
