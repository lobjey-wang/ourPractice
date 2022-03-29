using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private HelloWorldDbContext Context { get; set; }

        public HomeController(HelloWorldDbContext context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var playersData = new SqlPlayerData(Context);

            var model = new HomePageViewModel
            {
                Players = playersData.GetAll()
            };

            return new ObjectResult(model);
        }
    }

    public class HomePageViewModel
    {
        public IEnumerable<Player> Players { get; set; }
    }

    public class SqlPlayerData
    {
        private HelloWorldDbContext Context { get; set; }

        public SqlPlayerData(HelloWorldDbContext context)
        {
            Context = context;
        }

        public void Add(Player player)
        {
            Context.Add(player);
            Context.SaveChanges();
        }

        public Player Get(int id)
        {
            return Context.Player.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Player> GetAll()
        {
            return Context.Player.ToList();
        }
    }
}
