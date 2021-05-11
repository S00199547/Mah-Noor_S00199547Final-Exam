using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mah_Noor_S00199547Final_Exam
{
	public class Game
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int MetacriticScore { get; set; }
		public string Description { get; set; }
		public string Platfrom { get; set; }
		public decimal Price { get; set; }

		public string Gameimage { get; set; }


		public Game()
		{

		}
		public Game(string name, int metacriticScore,string description, string platform ,decimal price, string gameimage = "")
		{
			Name = name;
			MetacriticScore = metacriticScore;
			Description = description;
			Platfrom = platform;
			Price = price;
			Gameimage = gameimage;

		}
		public override string ToString()
		{
			return Name;
		}
		public void DecreasePrice(double decrease)
		{
			Price *= (decimal)(1 - decrease);
		}


	}
	public class GameData :DbContext
	{
		public GameData():base(@"C:\DATA3\GAMESINFO.MDF") {}

			public DbSet<Game>GamesInfo { get; set; }

			
	}

}
