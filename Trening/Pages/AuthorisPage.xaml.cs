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
	/// Interaction logic for AuthorisPage.xaml
	/// </summary>
	public partial class AuthorisPage : Page
	{
		public static ObservableCollection<User> users { get; set; }
		public AuthorisPage()
		{
			InitializeComponent();
			users = new ObservableCollection<User>(BdConnection.connection.User.ToList());
		}

		private void Reg_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new RegPage());
		}

		private void Enter_Click(object sender, RoutedEventArgs e)
		{
			users = new ObservableCollection<User>(BdConnection.connection.User.ToList()); 
			var userExists = users.Where(user => user.Login == TbLog.Text.Trim() && user.Pass == TbPass.Password.Trim()).FirstOrDefault();
			if (userExists != null)
			{
				NavigationService.Navigate(new ManePage(userExists));
			}
			else
			{
				MessageBox.Show(" Fuck");
			}
		}
	}
}
