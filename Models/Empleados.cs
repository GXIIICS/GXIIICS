using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GXIIICS.Models
{
    [Table("conductores")]
    public class Empleados
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nombres { get; set; }
        public string apePaterno { get; set; }
        public string apeMaterno { get; set; }
        public virtual Unidades unidades { get; set; }

    }
}
