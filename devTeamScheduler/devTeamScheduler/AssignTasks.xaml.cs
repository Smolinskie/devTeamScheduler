using devTeamScheduler.Models;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace devTeamScheduler
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class AssignTasks: Window
    {
        public AssignTasks()
        {
            InitializeComponent();
            Model model = new Model();

            foreach (var item in model.Users)
            {
                UserDropDown.Items.Add(item.fName + " " + item.lName);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Would you like to return to the Main Menu", "Leave current screen", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var returnToMM = new MyTasks();
                returnToMM.Show();
                this.Close();
            }else
                return;
               
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //create a new instance of model
            Model model = new Model();

            if (MessageBox.Show("Would you like to submit the following changes to user" + UserDropDown.SelectedItem,"Submit Changes",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                //prompt the user with a message box to confirm they want the changes submitted.

                model.Database.CreateIfNotExists();
                Entry entry = new Entry();
                entry.taskName = TaskTextBox.Text;
                //save the changes to the task database
                model.SaveChanges();

            }
            else
            {
                return;
            }
       

      
           

           
            
        }
    }
}
