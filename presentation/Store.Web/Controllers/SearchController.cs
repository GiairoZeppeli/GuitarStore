using Microsoft.AspNetCore.Mvc;
using GuitarStore;
namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IGuitarRepository guitarRepository;

        public SearchController(IGuitarRepository guitarRepository)
        {
            this.guitarRepository = guitarRepository;
        }

        public IActionResult Index(string query)
        {
            var guitars = guitarRepository.GeyAllByTitle(query);
            return View(guitars);
        }
    }
}
