using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversidadAPI.Models;

namespace CajaFinalUniversidad.Modelos
{
    public class Estudiante
    {
        [Key]
        public  int estudiante_id { get; set; }

        public  string estudiante_nombre { get; set; }

        public string estudiante_apellido { get; set; }

        [ForeignKey("Carrera")]
        public  int carrera_id { get; set; }
        //public Carrera Carrera { get; set; }

        public decimal estudiante_indice { get; set; }

        public  string estudiante_telefono { get; set; }

        public  string estudiante_correo { get; set; }

        [ForeignKey("Cuenta")]
        public  int cuenta_id { get; set; }
        //public Cuenta Cuenta { get; set; }

        public  string estudiante_nacionalidad { get; set; }

        public  int estudiante_trimestre { get; set; }

        [ForeignKey("Tipo_documento")]
        public int tipo_documento_id { get; set; }
        //public Tipo_documento Tipo_documento { get; set; }

        public string estudiante_documento {  get; set; }

        public DateOnly estudiante_fecha_ingreso { get; set; }

        public bool estudiante_activo { get; set; }

    }
}
