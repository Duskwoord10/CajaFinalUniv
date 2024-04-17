using CajaFinalUniversidad.Modelos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversidadAPI.Models
{
    public class Asignatura
    {
        [Key]
        public int asignatura_id { get; set; }

        [ForeignKey("Profesor")]
        public int profesor_id { get; set; }
        //public Profesor? Profesor { get; set; }
        public string asignatura_nombre { get; set; }
        public string asignatura_aula {  get; set; }
        public int asignatura_creditos { get; set; }

    }
}
