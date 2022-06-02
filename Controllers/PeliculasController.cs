using RatingAPI.Models;
using RatingAPI;
using Microsoft.AspNetCore.Mvc;

namespace RatingAPI.Controllers
{
    [ApiController]
    [Route("api/Peliculas")]
    public class PeliculasController : ControllerBase 
    {

        [HttpGet] 
        public ActionResult<IEnumerable<PeliculasDto>> GetPeliculas() 
        {
            return Ok(PeliculasData.InstanciaActual.Peliculas);
        }

        [HttpGet("{id}")]
        public ActionResult<PeliculasDto> GetReview(int id)
        {
            var ciudadARetornar = PeliculasData.InstanciaActual.Peliculas.FirstOrDefault(x => x.Id == id);
            if (ciudadARetornar == null)
                return NotFound();
            return Ok(ciudadARetornar);
        }
    }
}
