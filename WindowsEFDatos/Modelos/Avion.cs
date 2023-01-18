using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Modelos
{
    [Table("Avion")]

    public class Avion
    {

        [Key]
        public int IdAvion { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Denominacion { get; set; }

        public int Capacidad { get; set; }


        public int IdLineaAerea { get; set; }

        [ForeignKey("IdLineaAerea")]
        public LineaAerea LineaAerea { get; set; }

        
    }
}

