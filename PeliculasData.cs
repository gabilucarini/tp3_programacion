using RatingAPI.Models;

namespace RatingAPI
{
    public class PeliculasData
    {

        public List<PeliculasDto> Peliculas { get; set; }

        public static PeliculasData InstanciaActual { get; } = new PeliculasData();

        public PeliculasData()
        {
            Peliculas = new List<PeliculasDto>()
            {
                new PeliculasDto()
                {
                     Id = 1,
                     Nombre = "El Padrino",
                     Descripcion = "Drama Mafioso sobre una familia italiana",
                     Review = new List<ReviewDto>()
                     {
                         new ReviewDto() {
                             Id = 1,
                             Nombre = "Critico 1",
                             Descripcion = "La primera gran obra maestra de Coppola" },
                          new ReviewDto() {
                             Id = 2,
                             Nombre = "Critica 2",
                             Descripcion = "Cada pelicula mejor que la otra" },
                          new ReviewDto() {
                             Id = 3,
                             Nombre = "Critica 3",
                             Descripcion = "La tercera fue la coronacion de la saga como una de las mejores en su genero" },
                     }
                },
                new PeliculasDto()
                {
                    Id = 2,
                    Nombre = "Matrix",
                    Descripcion = "Ficcion En un mundo distopico controlado por maquinas",
                    Review = new List<ReviewDto>()
                     {
                         new ReviewDto() {
                             Id = 3,
                             Nombre = "Critico 1",
                             Descripcion = "Tendrian que haber frenado en la segunda entrega" },
                          new ReviewDto() {
                             Id = 4,
                             Nombre = "Critico 2",
                             Descripcion = "Cada una mejor que la otra, estelares actuaciones" },
                     }
                },
                new PeliculasDto()
                {
                    Id= 3,
                    Nombre = "Megamente",
                    Descripcion = "The one with that big tower.",
                    Review = new List<ReviewDto>()
                     {
                         new ReviewDto() {
                             Id = 5,
                             Nombre = "Critico 1",
                             Descripcion = "Tendria que haber ganado el oscar a mejor pelicula" },
                          new ReviewDto() {
                             Id = 6,
                             Nombre = "Critico 2",
                             Descripcion = "Un guion que daria envidia hasta a stephen king" },
                     }
                }
            };
        }
    }
}