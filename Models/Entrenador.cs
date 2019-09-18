using System.ComponentModel.DataAnnotations;

namespace Liga_Pokemon.Models
{
    public class Entrenador
    {
        [Required]
        public string Nombre{set; get;}
        [Required]
        public string Origen{set; get;}
        [Required]
        public string Cantidad{set; get;}
    }
}