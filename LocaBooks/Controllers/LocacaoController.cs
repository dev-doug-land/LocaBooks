using Microsoft.AspNetCore.Mvc;

namespace LocaBooks.Controllers
{
    public class LocacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
