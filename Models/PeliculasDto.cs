namespace RatingAPI.Models
{
    public class PeliculasDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }

        public ICollection<ReviewDto> Review { get; set; } = new List<ReviewDto>(); 

        public int CantidadReview
        {
            get { return Review.Count; }
        }
    }
}