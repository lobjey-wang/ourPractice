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
        public IEnumerable<PlayerInfo> Players { get; set; }
    }

    public class SqlPlayerData
    {
        private HelloWorldDbContext Context { get; set; }

        public SqlPlayerData(HelloWorldDbContext context)
        {
            Context = context;
        }

        public void Add(BasketballPlayer player)
        {
            Context.Add(player);
            Context.SaveChanges();
        }

        public BasketballPlayer Get(int id)
        {
            return Context.BasketballPlayer.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<PlayerInfo> GetAll()
        {
            return Context.BasketballPlayer.Join(Context.BasketballTeam, player => player.TeamId, team => team.Id,
                (player, team) => new PlayerInfo
                {
                    Name = player.Name,
                    TeamName = team.Name
                });
        }
    }
}
