﻿using System;
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var returnToMM = new LoginScreen();
            returnToMM.Show();
            this.Close();
        }

        
    }
}
