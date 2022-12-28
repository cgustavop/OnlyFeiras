using System.ComponentModel.DataAnnotations;

namespace webOnlyFeiras.Model
{
    public class Banca
    {
        [Key]
        public int BancaId { get; set; }
        [Required]
        public string PathFotografia { get; set; }
        public string Descricao { get; set; }

    }
}
