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

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private event EventHandler changePassword;
        public event EventHandler changePassworD
        {
            add { changePassword += value; }
            remove { changePassword -= value; }
        }
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string username = txtUserNameEmployee.Text;
                string password = txtPasswordEmployee.Password;
                string cfpassword = txtConfirmPassword.Password;
                if (password == cfpassword)
                {
                    if (AccountDAO.Instance.ChangePassword(username, password))
                    {
                        MessageBox.Show("Successfully");

                        if (changePassword != null)
                            changePassword(this, new EventArgs());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Password didn't match!!");
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