using System.ComponentModel.DataAnnotations;

namespace webOnlyFeiras.Model
{
    public class Marca
    {
        [Key]
        public string Nome { get; set; }
        [Required]
        public Utilizador Representante { get; set; }
        [Required]
        public DateTime DataFundacao { get; set; }
        public string Nacionalidade { get; set; }
        public string Mercado { get; set; }
        [Required]
        public string ImagePathLogotipo { get; set; }
        [Required]
        public string Morada { get; set; }
        [Required]
        public int NIPC { get; set; }
        public bool Verificada { get; set; }
    }
}
