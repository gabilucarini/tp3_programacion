using System.ComponentModel.DataAnnotations;

namespace RatingAPI.Models
{
        public class ReviewParaCreacionDto


        {
            [Required(ErrorMessage = "Agregá un nombre")]
            [MaxLength(50)]
            public string Nombre { get; set; } = string.Empty;
            [MaxLength(200)]
            public string? Descripcion { get; set; }
        }
}