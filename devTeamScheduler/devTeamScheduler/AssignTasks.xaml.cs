using devTeamScheduler.Models;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System;

namespace devTeamScheduler
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class AssignTasks : Window
    {
        public AssignTasks()
        {
            InitializeComponent();
            Model model = new Model();

            var users = (from u in model.Users select new { u.UID, name = u.lName + ", " + u.fName }).ToList();

            // set the display and value members for the combo box
            UserDropDown.DisplayMemberPath = "name";
            UserDropDown.SelectedValuePath = "UID";

            // now set the data source
            UserDropDown.ItemsSource = users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Would you like to return to the Main Menu", "Leave current screen", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var returnToMM = new MyTasks();
                returnToMM.Show();
                this.Close();
            }
            else
                return;

        
            /*
        private void CheckFields()
        {

           
            String[] textBoxes = { TaskTextBox.Text, DevBranchTextBox.Text, TaskDescriptionTextBox.Text };

            if (textBoxes.ToString.isNullOrWhiteSpace)
            {
                MessageBox.Show("Hi");
            }

        }
        */

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //create a new instance of model
            Model model = new Model();

            //prompt the user with a message box to confirm they want the changes submitted.
            if (MessageBox.Show("Would you like to submit the following changes to user " + UserDropDown.SelectedItem, "Submit Changes", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                //create a new instance of Task to save the data to the task table                
                Task task = new Task();

                task.taskName = TaskTextBox.Text;
                task.UID = (int)UserDropDown.SelectedValue;
                task.devBranch = DevBranchTextBox.Text;
                task.longDesc = TaskDescriptionTextBox.Text;
                task.dateDue = AssignDueDate.SelectedDate.Value;
                //gets the current date and time the submit was generated
                task.dateCreated = DateTime.Now;
                task.completed = false;

                //add the data to the task table
                model.Tasks.Add(task);
                //save changes 
                model.SaveChanges();
            }
            else
            {
                return;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CheckFields();
        }
    }
}
