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
using System.Collections.ObjectModel;
using Trening.DataBase;

namespace Trening.Pages
{
	/// <summary>
	/// Interaction logic for RegPage.xaml
	/// </summary>
	public partial class RegPage : Page
	{
		public static ObservableCollection<User> users { get; set; }
		public RegPage()
		{
			InitializeComponent();
		}

		private void Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}

		private void Reg_Click(object sender, RoutedEventArgs e)
		{
			User newUser = new User();
			newUser.Login = TbLog.Text.Trim();
			newUser.Name = TbName.Text.Trim();
			newUser.Pass = TbPass.Password.Trim();
			
			users = new ObservableCollection<User>(BdConnection.connection.User.ToList());
			var userExists = users.Where(user => user.Login == TbLog.Text.Trim()).FirstOrDefault();
			if (userExists == null)
			{
				BdConnection.connection.User.Add(newUser);
				BdConnection.connection.SaveChanges();
				MessageBox.Show("All done!!");
			}
			else
			{
				MessageBox.Show("Think Better!!");
			}

		}
	}
}
