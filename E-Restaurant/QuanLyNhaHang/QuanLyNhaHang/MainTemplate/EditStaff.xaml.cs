using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyNhaHang.MainTemplate
{
    /// <summary>
    /// Interaction logic for EditStaff.xaml
    /// </summary>
    public partial class EditStaff : Window
    {
        public EditStaff()
        {
            InitializeComponent();
        }
        public EditStaff(int id)
        {
            InitializeComponent();
            try
            {
                StaffDTO staff = StaffDAO.Instance.GetStaffById(id);
                this.btnConfirm.Tag = staff;
                AccountDTO account = AccountDAO.Instance.GetAccountByIdUser(staff.Id);
                txtNameEmployee.Text = staff.Name;
                txtUserNameEmployee.Text = account.UserName;
                txtEmailEmployee.Text = staff.Email;
                txtPhoneEmployee.Text = staff.Phone;
                txtSalaryEmployee.Text = staff.Salary.ToString();
                cmbPoition.SelectedIndex = staff.Position;

                if (staff.Sex == 1)
                    rdoMale.IsChecked = true;
                else
                    rdoFemale.IsChecked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idStaff = ((sender as Button).Tag as StaffDTO).Id;
                string name = txtNameEmployee.Text;
                string UserName = txtUserNameEmployee.Text;
                string email = txtEmailEmployee.Text;
                string phone = txtPhoneEmployee.Text;
                string salary = txtSalaryEmployee.Text;
                int position = cmbPoition.SelectedIndex;
                int sex = Convert.ToInt32(rdoMale.IsChecked.Value);

                if (name == null || UserName == null || email == null || phone == null || salary == null || position == -1)
                    MessageBox.Show("Please fill out the form first", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    if ((StaffDAO.Instance.CheckPhoneExist(phone) == 0 || StaffDAO.Instance.CheckPhoneExist(phone) == idStaff) && (StaffDAO.Instance.CheckEmailExist(email) == 0 || StaffDAO.Instance.CheckEmailExist(email) == idStaff))
                    {
                        if (AccountDAO.Instance.CheckUsernamelExist(UserName) == 0 || AccountDAO.Instance.CheckUsernamelExist(UserName) == idStaff)
                        {
                            StaffDAO.Instance.EditStaff(name, sex, email, phone, Int32.Parse(salary), position, idStaff);

                            MessageBox.Show("Edit staff successfuly");
                        }
                        else
                            MessageBox.Show("Username is exist");
                    }
                    else
                        MessageBox.Show("Phone or Email is exist");

                    this.Close();
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

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}