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

namespace Client
{
    public partial class MainWindowContentCreator : Window
    {

        ContentCreator thisContentCreator;

        public MainWindowContentCreator(ContentCreator contentCreator)
        {
            thisContentCreator = contentCreator;
            InitializeComponent();
            textBlock_NameUser.Text = thisContentCreator.GivenName + " " + thisContentCreator.LastName;
        }

        private void button_Back_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            this.Close();
            loginWindow.Show();
        }
    }
}
