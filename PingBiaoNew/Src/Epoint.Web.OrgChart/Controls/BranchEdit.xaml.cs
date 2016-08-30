﻿using System;
using Epoint.Web.OrgChart.Models;
using System.Windows.Controls;
using System.Windows;

namespace Epoint.Web.OrgChart.Controls
{
    public partial class BranchEdit : ChildWindow
    {
        public BranchEdit()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            var branch = this.DataContext as Branch;
            branch.Name = this.name.Text;
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

