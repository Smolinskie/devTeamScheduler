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
using System.Windows.Shapes;
using devTeamScheduler.Models;

namespace devTeamScheduler
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class SelectedTask : Window
    {
        // private members
        private Model model;
        private devTeamScheduler.Models.Task task;
        private List<Entry> entries;

        // constructor
        public SelectedTask(int TID)
        {
            InitializeComponent();

            // initialize the model
            model = new Model();

            // retrieve this task from the database
            var getTask = (from t in model.Tasks where t.TID == TID select t).ToList();

            // make sure there is exactly one task. If not, exit the function
            if (getTask.Count != 1) {
                MessageBox.Show("Invalid Task ID, cannot open this task!", "Invalid ID");
                Button_Click(null, null);
            }

            // otherwise, get the task and store it in the Task member object
            this.task = getTask.First();

            // set the view values from the task object
            tbTaskID.Text = task.TID.ToString();
            dpDateCreated.Text = task.dateCreated.ToShortDateString();
            tbTitle.Text = task.shortDesc;
            tbBranch.Text = task.devBranch;
            dpDueDate.Text = task.dateDue.ToShortDateString();
            tbDescription.Text = task.longDesc;

            // load the employees combo box and set it to the assigned employee
            LoadEmployees();
            cbEmployee.SelectedValue = task.UID;

            // load the entries for this task
            LoadEntries();
        }

        // private methods

        /// <summary>
        /// Performs when the cancel button is clicked. Exits this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var returnToMM = new MyTasks();
            returnToMM.Show();
            this.Close();
        }

        /// <summary>
        /// Loads the employee list into the combo box
        /// </summary>
        private void LoadEmployees() {
            // first get all the employees / users from the database
            var emps = (from e in model.Users select new { e.UID, name=e.lName + ", " + e.fName }).ToList();

            // set the display and value members for the combo box
            cbEmployee.DisplayMemberPath = "name";
            cbEmployee.SelectedValuePath = "UID";

            // now set the data source
            cbEmployee.ItemsSource = emps;
        }

        /// <summary>
        /// Loads entries for this task and populates the grid
        /// </summary>
        private void LoadEntries() {
            // first get the entries which have this task ID from the database. 
            entries = (from e in model.Entries where e.TID == task.TID select e).ToList();

            // set the grid data source as this list
            dgEntries.ItemsSource = entries;

            // set up the display for the grid
            dgEntries.CanUserAddRows = false;
            /*
            dgEntries.Columns[0].Visibility = Visibility.Hidden;
            dgEntries.Columns[1].Visibility = Visibility.Hidden;
            dgEntries.Columns[2].Visibility = Visibility.Hidden;
            dgEntries.Columns[3].Width = DataGridLength.Auto;
            dgEntries.Columns[4].Width = DataGridLength.SizeToCells;
            dgEntries.Columns[5].Width = DataGridLength.SizeToCells;*/
        }
    }
}
