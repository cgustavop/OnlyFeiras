using System.ComponentModel.DataAnnotations;

namespace webOnlyFeiras.Model
{
    public class Carrinho
    {
        [Key]
        public Utilizador Utilizador { get; set; }
        public List<Produtos> Produtos { get; set; }
        public List<CodigoPromocional> CodigosPromocionais { get; set; }
    }

    public class Produtos
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public DateTime AdicionadoEm { get; set; }
    }
}
