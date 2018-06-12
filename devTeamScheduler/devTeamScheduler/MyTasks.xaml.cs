using System.Windows;

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
            var openSelectedTask = new SelectedTask(1);
            openSelectedTask.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var openAssignTasks = new AssignTasks();
            openAssignTasks.Show();
            this.Close();

        }
    }
}
