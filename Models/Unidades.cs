using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GXIIICS.Models
{
    [Table("unidades")]
    public class Unidades
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string placa {get; set;}
        public string modelo { get; set; }
        public string cargaMax { get; set; }
        public string estado { get; set; }
    }
}
