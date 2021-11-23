using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AccountCard.xaml
    /// </summary>
    public partial class AccountCard : UserControl
    {
        private event EventHandler deleteAccount;
        public event EventHandler DeleteAccount
        {
            add { deleteAccount += value; }
            remove { deleteAccount -= value; }
        }
        public AccountCard()
        {
            InitializeComponent();
        }

        private void resetPasswordButton_MouseEnter(object sender, MouseEventArgs e)
        {
            resetPasswordIcon.Foreground = Brushes.Green;
        }

        private void resetPasswordButton_MouseLeave(object sender, MouseEventArgs e)
        {
            resetPasswordIcon.Foreground = Brushes.White;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Delete account will delete staff. Do you want to countinue?", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning) != MessageBoxResult.OK)
                {
                    return;
                }
                string username = txbUserName.Text;
                int idStaff = AccountDAO.Instance.GetIDStaffByUserName(username);
                //delete staff

                //delete account
                if (AccountDAO.Instance.DeleteAccountByIdStaff(idStaff) && StaffDAO.Instance.DeleteStaff(idStaff))
                {
                    MessageBox.Show("Delete account successful");
                    if (deleteAccount != null)
                    {
                        deleteAccount(this, new EventArgs());
                    }
                }
                else
                    MessageBox.Show("Delete account fail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void SetText(string userName, string name, int position)
        {
            try
            {
                txbUserName.Text = userName;
                txbName.Text = name;
                switch (position)
                {
                    case 0:
                        txbWorkingPosition.Text = "Manager";
                        break;
                    case 1:
                        txbWorkingPosition.Text = "Waiter";
                        break;
                    case 2:
                        txbWorkingPosition.Text = "Chef";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void resetPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string userName = txbUserName.Text;
                string message = "Are you sure you want to reset password of " + userName + "?";
                string title = "Reset Password";
                MessageBoxResult result = MessageBox.Show(message, title, MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.Cancel);
                if (result == MessageBoxResult.OK)
                {
                    if (AccountDAO.Instance.ResetPassword(userName))
                        MessageBox.Show("Reset password success, new password is: 123456", "Suscess", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK);
                    else
                        MessageBox.Show("Reset password fail", "Fail", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}