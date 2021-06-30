using System.Collections.Generic;
using System.Linq;
using WebApp1.Model;

namespace WebApp1.Repositories
{
    public class MockPlayerRepository : IPlayerRepository
    {
        private readonly List<Player> playerList;

        public MockPlayerRepository()
        {
            playerList = new List<Player>
            {
                new Player { Id = 1, Name = "James", Age = 34 },
                new Player { Id = 2, Name = "Curry", Age = 30 },
                new Player { Id = 3, Name = "Durant", Age = 32 },
            };
        }

        public List<Player> GetAllPlays()
        {
            return playerList;
        }

        public Player GetPlayer(int id)
        {
            return playerList.FirstOrDefault(p => p.Id == id);
        }
    }
}