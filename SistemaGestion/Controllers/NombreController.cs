using Microsoft.AspNetCore.Mvc;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NombreController : Controller
    {
        // Nombre del local
        [HttpGet()]
        public String GetNombre()
        {
            return "Insumos minorista";
        }
    }
}
