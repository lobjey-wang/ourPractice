using Microsoft.AspNetCore.Mvc;
using WebApp1.Repositories;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlayerRepository playerRepository;

        public HomeController(IPlayerRepository playerRep)
        {
            playerRepository = playerRep;
        }

        public string Index()
        {
            return "Hello world";
        }

        public JsonResult Detail(int id)
        {
            var player = playerRepository.GetPlayer(id);

            return Json(player);
        }
    }
}