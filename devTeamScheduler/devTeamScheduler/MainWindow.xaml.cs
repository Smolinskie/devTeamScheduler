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
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 

            if (Username.Text == "" )
            {
                System.Windows.Forms.MessageBox.Show("Please enter in a username");
            }

            if (Password.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please enter in a password");
            }
            else
            {

                var win2 = new Window2();
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

