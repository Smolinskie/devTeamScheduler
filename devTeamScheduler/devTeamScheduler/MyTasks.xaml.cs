using System.Windows;
using System.Windows.Controls;

namespace devTeamScheduler
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class MyTasks : Window
    {
        public MyTasks()
        {
            InitializeComponent();
        }

     

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // add a new SelectedTask page to the tab control base on code from: https://stackoverflow.com/questions/15589298/how-to-add-wpf-page-to-tabcontrol            
            TabItem tabitem = new TabItem();
            tabitem.Header = "Selected Task";
            Frame tabFrame = new Frame();
            var openSelectedTask = new SelectedTaskPage(1);
            tabFrame.Content = openSelectedTask;
            tabitem.Content = tabFrame;
            TabController.Items.Add(tabitem);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var openAssignTasks = new AssignTasks();
            openAssignTasks.Show();
            this.Close();

        }
    }
}
