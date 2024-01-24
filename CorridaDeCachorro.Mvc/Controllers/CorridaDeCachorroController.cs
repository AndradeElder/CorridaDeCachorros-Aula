using Microsoft.AspNetCore.Mvc;

namespace CorridaDeCachorros.Mvc.Controllers
{
    public class CorridaDeCachorroController : Controller
    {
        public CorridaDeCachorro CorridaDeCachorro { get; set; }

        public CorridaDeCachorroController(CorridaDeCachorro corridaDeCachorro)
        {
            CorridaDeCachorro = corridaDeCachorro;
        }
        public IActionResult Index()
        {
            return View(CorridaDeCachorro);
        }
    }
}
