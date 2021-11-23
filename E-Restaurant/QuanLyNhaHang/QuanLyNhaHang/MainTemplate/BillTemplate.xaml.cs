using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Data.SqlClient;
namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for BillTemplate.xaml
    /// </summary>
    public partial class BillTemplate : Window
    {
        public BillTemplate()
        {

            InitializeComponent();

        }
        public BillTemplate(int id, int ID)
        {
            InitializeComponent();

            staffID.Text = "Staff ID: " + ID.ToString();
            ShowBill(id);
        }
        private void ShowBill(int id)
        {
            try
            {
                float subTotal = 0;
                int discount = 0;
                float total = 0;
                List<BillInfoDTO> listBill = BillInfoDAO.Instance.GetListMenuByTable(id);
                foreach (BillInfoDTO bill in listBill)
                {
                    subTotal += bill.TotalPrice;
                }
                gridBill.ItemsSource = listBill;
                GetDateCheckIn(id);
                GetDateCheckOut();
                GetUncheckedBillIDByTable(id);
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(id);
                discount = BillDAO.Instance.GetDiscount(idBill);
                subTotalTxb.Text = "Subtotal: " + subTotal.ToString() + " VND";
                discountTxb.Text = "Discount: " + discount.ToString() + "%";
                total = subTotal * (100 - discount) / 100;
                totalTxb.Text = "Total: " + total.ToString() + " VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void GetUncheckedBillIDByTable(int id)
        {
            try
            {
                int billID = BillDAO.Instance.GetUncheckBillIDByTableID(id);
                invoiceID.Text = "Invoice number " + billID.ToString();
                invoice.Text = "Invoice #" + billID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void GetDateCheckOut()
        {
            try
            {
                string dateCheckOut = BillDAO.Instance.GetDateCheckOut();
                dateCheckOutTxb.Text = dateCheckOut;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void GetDateCheckIn(int id)
        {
            try
            {
                string dateCheckIn = BillDAO.Instance.GetDateCheckInByTable(id);
                dateCheckinTxb.Text = dateCheckIn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        private void exportBillBtn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(billGrd, "invoice");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
        private void gridBill_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            try
            {
                string headername = e.Column.Header.ToString();

                //update column details when generating
                if (headername == "FoodName")
                {
                    e.Column.Header = "Name";
                    e.Column.DisplayIndex = 0;
                }
                else if (headername == "Price")
                {
                    e.Column.DisplayIndex = 1;
                }
                else if (headername == "Count")
                {
                    e.Column.Header = "Quantity";
                    e.Column.DisplayIndex = 2;
                }
                else if (headername == "TotalPrice")
                {
                    e.Column.Header = "Total Price";
                    e.Column.DisplayIndex = 3;
                }
                else e.Column.Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}