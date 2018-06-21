using System.Linq;
using System.Windows;
using devTeamScheduler.Models;

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
            //intilize a new instance of model.
            Model model = new Model();
            var display = (from t in model.Tasks select new { t.TID, t.shortDesc, t.dateCreated, t.dateDue, t.completed }).ToList();
            userTaskDataGrid.ItemsSource = display;   
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
    
        private void userTaskDataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Model model = new Model();
            //open the task for the sslected task.
            var openSelectedTask = new SelectedTask(1);
            //openSelectedTask.tbTitle.Text =            
            openSelectedTask.Show();
            //this.Close();
        }

        private void DataGridCell_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {

        }
    }
}
