using System.ComponentModel.DataAnnotations;

namespace webOnlyFeiras.Model
{
    public class Utilizador
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        public string Morada { get; set; } = String.Empty;

        public int Contacto { get; set;}

        [Required]
        public string Password { get; set; }

        public int PathFotografiaPerfil { get; set; }

        [Required]
        public string Role { get; set; } = String.Empty;
    }
}
