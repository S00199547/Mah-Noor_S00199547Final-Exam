using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mah_Noor_S00199547Final_Exam
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Game> AllGames;

		public List<Game> Xbox { get; private set; }
		public List<Game> PS { get; private set; }
		public List<Game> Swith { get; private set; }

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			GameData db = new GameData();//Database 

			var query = from Game in db.GamesInfo
						select Game;
			
			lbxGames.ItemsSource = query.ToList(); 

		}

		//SElection change handler 
		private void lbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Game selectedGame = lbxGames.SelectedItem as Game;

			if (selectedGame != null)
			{
				imagegane.Source = new BitmapImage(new Uri(selectedGame.Gameimage, UriKind.Relative));
				tblkgames.Text = $"{selectedGame.Price:C},{selectedGame.Platfrom},{selectedGame.Description}";
			}
		}

		private void rball_Checked(object sender, RoutedEventArgs e)
		{
			if (rball.IsChecked == true)
			{
				lbxGames.ItemsSource = AllGames; 
			}
			else
			{
				if (rbxbox.IsChecked== true)
				{
					AllGames = Xbox;
				}
				else if (rbps.IsChecked == true)
				{
					AllGames = PS;
				}

				else if (rbswitch.IsChecked== true)
				{
					AllGames = Swith;
				}

				lbxGames.ItemsSource = AllGames;


			}

		}
	}
}
