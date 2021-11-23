﻿using QuanLyNhaHang.DAO;
using Microsoft.VisualBasic;
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

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for CategoryCard.xaml
    /// </summary>
    public partial class CategoryCard : UserControl
    {
        public CategoryCard()
        {
            InitializeComponent();
        }

        private void addButton_MouseEnter(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = Brushes.Green;
        }

        private void addButton_MouseLeave(object sender, MouseEventArgs e)
        {
            editIcon.Foreground = Brushes.White;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }
        public void SetText(int id, string name)
        {
            tbkName.Text = name;
            tbkID.Text = id.ToString();
        }
    }
}
