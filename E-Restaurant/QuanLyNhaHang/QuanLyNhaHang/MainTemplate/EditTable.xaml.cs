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
    /// Interaction logic for EditTable.xaml
    /// </summary>
    public partial class EditTable : Window
    {

        public string tableName = "";
        public bool ableToChange = false;
        public EditTable()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string oldname = OldName.Text;
                string newname = txtTable.Text;
                if (TableDAO.Instance.EditTable(oldname, newname))
                {
                    MessageBox.Show("Edit Table Successfully");
                    if (edittable != null)
                        edittable(this, new EventArgs());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add Table Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private event EventHandler edittable;
        public event EventHandler Edittable
        {
            add { edittable += value; }
            remove { edittable -= value; }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}