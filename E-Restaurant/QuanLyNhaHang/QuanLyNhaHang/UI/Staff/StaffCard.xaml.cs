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
    /// Interaction logic for EmployeeCard.xaml
    /// </summary>
    public partial class StaffCard : UserControl
    {
        public StaffCard()
        {
            InitializeComponent();
        }

        private void editButton_MouseEnter(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.Green;
        }

        private void editButton_MouseLeave(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.White;
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void SetText(string name, int salary, int position, string mail, string phone)
        {
            try
            {
                nameTxtBox.Text = name;

                salaryTxtBox.Text = salary.ToString() + " VND";

                switch (position)
                {
                    case 0:
                        positionTxtBox.Text = "Manager";
                        break;
                    case 1:
                        positionTxtBox.Text = "Waiter";
                        break;
                    case 2:
                        positionTxtBox.Text = "Chef";
                        break;
                }

                mailTxtBox.Text = mail;
                phoneTxtBox.Text = phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}