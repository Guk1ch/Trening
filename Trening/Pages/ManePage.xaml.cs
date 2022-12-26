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
using System.Collections.ObjectModel;

namespace Trening.Pages
{
	/// <summary>
	/// Interaction logic for ManePage.xaml
	/// </summary>
	public partial class ManePage : Page
	{
		public static User profil { get; set; }
		public static ObservableCollection<Product> items { get; set; }
		public ManePage(User user)
		{
			InitializeComponent();
			profil = user;
			items = new ObservableCollection<Product>(BdConnection.connection.Product.ToList());
			DataContext = this;
		}

		private void Busket_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new BusketPage(profil));
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AuthorisPage());
		}

		private void lvItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var isSelected = lvItem.SelectedItem as Product;
			if (isSelected != null)
			{
				NavigationService.Navigate(new ItemPage(isSelected));
			}
		}

		private void tbSerch_SelectionChanged(object sender, RoutedEventArgs e)
		{
			items = new ObservableCollection<Product>(BdConnection.connection.Product.ToList());
			if (tbSerch.Text.Trim().Length != 0)
			{
				items = new ObservableCollection<Product>(BdConnection.connection.Product.Where(a => a.Name.Contains(tbSerch.Text)).ToList());
			}
			lvItem.ItemsSource = items;

		}
	}
}
