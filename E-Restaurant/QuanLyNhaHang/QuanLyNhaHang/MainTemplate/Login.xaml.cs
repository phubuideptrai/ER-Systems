using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txbPassword.Visibility = Visibility.Collapsed;
        }

        #region Method
        private void DisablePasswordBox()
        {
            passwordBox.Visibility = Visibility.Collapsed;
        }
        private void DisablePasswordTextBox()
        {
            txbPassword.Visibility = Visibility.Collapsed;
        }
        private void EnablePasswordBox()
        {
            passwordBox.Visibility = Visibility.Visible;
        }
        private void EnablePasswordTextBox()
        {
            txbPassword.Visibility = Visibility.Visible;
        }
        private void UnmaskPassword()
        {
            txbPassword.Text = passwordBox.Password;
        }
        private void UpdatePassword()
        {
            passwordBox.Password = txbPassword.Text;
        }
        private void ShowPassword()
        {
            UnmaskPassword();
            DisablePasswordBox();
            EnablePasswordTextBox();
            passwordShow.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;
        }
        private void HidePassword()
        {
            UpdatePassword();
            EnablePasswordBox();
            DisablePasswordTextBox();
            passwordShow.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;
        }
        bool Login(string username, string password) { return AccountDAO.Instance.Login(username, password); }
        int GetPosition(string username) { return AccountDAO.Instance.GetPositionByUserName(username); }
        int GetId(string username) { return AccountDAO.Instance.GetIDStaffByUserName(username); }
        #endregion

        #region Event
        private void passwordShow_Click(object sender, RoutedEventArgs e)
        {
            if (passwordShow.Kind == MaterialDesignThemes.Wpf.PackIconKind.EyeOff)
            {
                ShowPassword();
            }
            else
                HidePassword();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            UnmaskPassword();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string userName = usernameContainer.Text;
                string password;
                if (txbPassword.Text != null)
                    password = txbPassword.Text;
                else
                    return;

                if (Login(userName, password))
                {
                    int position = GetPosition(userName);
                    int id = GetId(userName);
                    switch (position)
                    {
                        case 0:
                            ManagerForm managerForm = new ManagerForm(id);
                            this.Hide();

                            managerForm.ShowDialog();
                            this.Show();
                            break;
                        case 1:
                            WaiterForm waiterForm = new WaiterForm(id);
                            this.Hide();

                            waiterForm.ShowDialog();
                            this.Show();
                            break;
                        case 2:
                            ChefForm chefForm = new ChefForm(id);
                            this.Hide();

                            chefForm.ShowDialog();
                            this.Show();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion
    }
}