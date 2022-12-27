using System.ComponentModel.DataAnnotations;

namespace webOnlyFeiras.Model
{
    public class Utilizador
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        public int Nome { get; set; }

        [Required]
        public int Email { get; set; }

        [Required]
        public int DataNascimento { get; set; }
        public int Morada { get; set; }

        public int Contacto { get; set;}

        [Required]
        public int Password { get; set; }

        public int Marca { get; set; }

        public int PathFotografiaPerfil { get; set; }
        
        [Required]
        public int IsOrganizador { get; set; }


    }
}
