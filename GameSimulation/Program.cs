using GameSimulation.Concrete;
using GameSimulation.Entities;
using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Player player1 = new Player();
            player1.Id = 111;
            player1.FirstName = "Green";
            player1.LastName = "Dragon";
            player1.Age = 19;
            player1.Country = "USA";

            Player player2 = new Player();
            player2.Id = 222;
            player2.FirstName = "Alexander";
            player2.LastName = "Duma";
            player2.Age = 19;
            player2.Country = "Germany";

            Game game1 = new Game();
            game1.Id = 1111;
            game1.GameName = "Browl Stars";
            game1.GamePrice = 50;

            Game game2 = new Game();
            game2.Id = 2222;
            game2.GameName = "Boom Beach";
            game2.GamePrice = 150;

            Campain campain1 = new Campain();
            campain1.Id = 1;
            campain1.CampainName = "Sepette %50 indirim.";

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(player2);

            CampainManager campainManager = new CampainManager();
            campainManager.Add(campain1);
            campainManager.Remove(campain1);


            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

        
        }
    }
}
