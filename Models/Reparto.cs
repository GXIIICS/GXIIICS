using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GXIIICS.Models
{
    [Table("Entregas")]
    public class Reparto
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idEntrega { get; set; }
        public int cargaTotal { get; set; }
        public string productoSolicitado { get;}
        public virtual Empleados empleado { get; set; }
        public virtual Unidades unidad { get; set; }
    }
}
