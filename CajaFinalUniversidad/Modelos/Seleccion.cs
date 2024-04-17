using CajaFinalUniversidad.Modelos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversidadAPI.Models

{

    public enum Estado { En_curso, Completado }

    public class Seleccion
    {
        [Key]
        public int seleccion_id { get; set; }

        [ForeignKey("Estudiante")]
        public int estudiante_id { get; set; }
        //public Estudiante Estudiante { get; set; }

        public int seleccion_trimestre { get; set; }
        public Estado seleccion_estado { get; set; }
        public decimal seleccion_indice { get; set; }
        public int seleccion_creditos { get; set; }
    }
}
