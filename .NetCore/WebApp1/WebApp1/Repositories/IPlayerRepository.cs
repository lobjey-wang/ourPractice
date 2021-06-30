using System.Collections.Generic;
using WebApp1.Model;

namespace WebApp1.Repositories
{
    public interface IPlayerRepository
    {
        List<Player> GetAllPlays();

        Player GetPlayer(int id);
    }
}