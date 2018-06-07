using devTeamScheduler.Models;
using MySql.Data.MySqlClient;
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

namespace devTeamScheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();

/*            Model model = new Model();
            model.Database.CreateIfNotExists();
            User user = new User();
            user.fName = "Daniel";
            user.lName = "Baker";
            user.uName = "dbaker";
            user.email = "danbaker951@gmail.com";
            user.password = "testpswd";

            model.Users.Add(user);
            model.SaveChanges();
            var list = (from u in model.Users select u).ToList();

            foreach (var us in list)
  
    Console.WriteLine(us.fName);
    */
    }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 

            if (usernameTextBox.Text == "" )
            {
                MessageBox.Show("Please enter in a username");
            }

            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter in a password");
            }
            else
            {

                var win2 = new MyTasks();
                win2.Show();
                this.Close();
            }

            }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    } // end of button_click method

    }

