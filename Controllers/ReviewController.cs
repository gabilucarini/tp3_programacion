using RatingAPI.Models;
using RatingAPI;
using Microsoft.AspNetCore.Mvc;


namespace RatingAPI.Controllers
{
    [ApiController]
    [Route("api/Peliculas/{idPelicula}/Review")] 
    public class ReviewController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ReviewDto>> GetReview(int idPelicula)
        {
            var Pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);
            if (Pelicula == null)
                return NotFound();

            return Ok(Pelicula.Review);
        }

        [HttpGet("{idReview}", Name = "GetReview")] 
        public ActionResult<ReviewDto> GetReview(int idPelicula, int idReview)
        {
            var film = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == idPelicula);

            if (film == null)
                return NotFound();

            var Reviews = film.Review.FirstOrDefault(x => x.Id == idReview);

            if (Reviews == null)
                return NotFound();

            return Ok(Reviews);
        }

        [HttpPost]
        public ActionResult<ReviewDto> CrearReview(int idPelicula, ReviewParaCreacionDto Review)
        {
            var Pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(c => c.Id == idPelicula);
            if (Pelicula is null)
            {
                return NotFound();
            }

            var idMaximoReview = PeliculasData.InstanciaActual.Peliculas.SelectMany(c => c.Review).Max(p => p.Id);

            var nuevoReview = new ReviewDto
            {
                Id = ++idMaximoReview,
                Nombre = Review.Nombre,
                Descripcion = Review.Descripcion
            };

            Pelicula.Review.Add(nuevoReview);

            return CreatedAtRoute(
                "GetReview", 
                new 
                {
                    idPelicula,
                    idReview = nuevoReview.Id
                },
                nuevoReview);
        }

        [HttpPut("{idReview}")]
        public ActionResult ActualizarReview(int idPelicula, int idReview, ReviewParaUpdateDto Reviews)
        {
            var Pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(c => c.Id == idPelicula);

            if (Pelicula == null)
                return NotFound();

            var ReviewEnLaBase = Pelicula.Review.FirstOrDefault(p => p.Id == idReview);
            if (ReviewEnLaBase == null)
                return NotFound();

            ReviewEnLaBase.Nombre = Reviews.Nombre;
            ReviewEnLaBase.Descripcion = Reviews.Descripcion;

            return NoContent();
        }


        [HttpDelete("{idReview}")]
        public ActionResult DeleteReviews(int idPelicula, int idReview)
        {
            var Pelicula = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(c => c.Id == idPelicula);
            if (Pelicula is null)
                return NotFound();

            var ReviewAEliminar = Pelicula.Review
                .FirstOrDefault(p => p.Id == idReview);
            if (ReviewAEliminar is null)
                return NotFound();

            Pelicula.Review.Remove(ReviewAEliminar);

            return NoContent();
        }
    }
}
