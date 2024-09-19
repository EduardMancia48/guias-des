using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPelicula.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Nombre { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; }
    }
}
