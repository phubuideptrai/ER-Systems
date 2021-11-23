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
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;

namespace QuanLyNhaHang.MainTemplate
{
    /// <summary>
    /// Interaction logic for AddNewTable.xaml
    /// </summary>
    public partial class AddNewTable : Window
    {
        public AddNewTable()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = txtNameTable.Text.Trim();
                if (name == null || name == "")
                {
                    MessageBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (TableDAO.Instance.AddTable(name))
                {
                    MessageBox.Show("Add New Table Successfully");
                }
                else
                {
                    MessageBox.Show("Add New Table Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}