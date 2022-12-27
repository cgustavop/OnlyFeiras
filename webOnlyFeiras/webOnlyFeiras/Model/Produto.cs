using System.ComponentModel.DataAnnotations;

namespace webOnlyFeiras.Model
{
    public class Produto
    {
        public enum TipoDeProduto
        {
            Artigo,
            Serviço
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set;}
        public Decimal Preco { get; set; }
        [Required]
        public TipoDeProduto Tipo { get; set; }
        public int Stock { get; set; }

    }
}
