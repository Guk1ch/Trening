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
using Trening.DataBase;

namespace Trening.Pages
{
	/// <summary>
	/// Interaction logic for BusketPage.xaml
	/// </summary>
	public partial class BusketPage : Page
	{
		public static User user1 { get; set; }
		public BusketPage(User user)
		{
			InitializeComponent();
			user1 = user;
			
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new ManePage(user1));
		}
	}
}
