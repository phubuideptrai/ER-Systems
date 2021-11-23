using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using QuanLyNhaHang.MainTemplate;
using QuanLyNhaHang.UI.Meal;
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

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for WaiterForm.xaml
    /// </summary>
    public partial class WaiterForm : Window
    {
        int staffID;
        public WaiterForm()
        {
            InitializeComponent();
        }
        public WaiterForm(int id)
        {
            InitializeComponent();
            try
            {
                tblName.Text = StaffDAO.Instance.GetNameById(id);
                InfoButton.Tag = StaffDAO.Instance.GetStaffById(id);
                staffID = id;
                Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region method
        private void Load()
        {
            LoadTable();
            LoadCategory();
            LoadFoodList();
            LoadCbTable();
        }

        private void LoadTable()
        {
            try
            {
                TableDAO.Instance.SetTableStatus();
                wpTable.Children.Clear();
                List<TableDTO> tableList = TableDAO.Instance.GetTableList();
                for (int i = 0; i < tableList.Count; i++)
                {
                    TableDAO.Instance.SetTableStatus();
                }

                foreach (TableDTO item in tableList)
                {
                    Table btn = new Table();

                    btn.SetTest(item.Name, item.Status);
                    btn.btnTable.Tag = item;

                    btn.SetBackGround(item.Status);

                    btn.btnTable.Click += BtnTable_Click;
                    wpTable.Children.Add(btn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadFoodList()
        {
            try
            {
                wpFood.Children.Clear();

                List<FoodDTO> foodList = FoodDAO.Instance.GetListFood();
                foreach (FoodDTO food in foodList)
                {
                    MealButton foodBTN = new MealButton();
                    foodBTN.SetName(food.Name);
                    foodBTN.btnMeal.Tag = food;
                    foodBTN.btnMeal.Click += BtnMeal_Click;
                    wpFood.Children.Add(foodBTN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        void LoadCategory()
        {
            try
            {
                List<CategoryDTO> listCategory = CategoryDAO.Instance.GetListCategory();
                cbCategory.ItemsSource = listCategory;
                cbCategory.DisplayMemberPath = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadFoodListByCategory(int id)
        {
            try
            {
                wpFood.Children.Clear();

                List<FoodDTO> listFoodByCategory = FoodDAO.Instance.GetFoodByCategoryID(id);

                foreach (FoodDTO food in listFoodByCategory)
                {
                    MealButton foodBTN = new MealButton();
                    foodBTN.SetName(food.Name);
                    foodBTN.btnMeal.Tag = food;
                    foodBTN.btnMeal.Click += BtnMeal_Click;
                    wpFood.Children.Add(foodBTN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadMealStatus(int tableID)
        {
            try
            {
                List<BillInfoDTO> listBillInfo = BillInfoDAO.Instance.GetListMenuByTable(tableID);

                spmealstatus.Children.Clear();

                foreach (BillInfoDTO item in listBillInfo)
                {
                    MealStatusCard card = new MealStatusCard();
                    card.Tag = item;
                    card.SetText(item.FoodName, item.Count, item.Description, item.Status);
                    spmealstatus.Children.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadCbTable()
        {
            try
            {
                List<TableDTO> tableList = TableDAO.Instance.GetTableList();
                ucCbTable.cbTable.ItemsSource = tableList;
                ucCbTable.cbTable.DisplayMemberPath = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadDiscount(int tableID)
        {
            try
            {
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(tableID);
                discount.discountTextBox.Text = BillDAO.Instance.GetDiscount(idBill).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void LoadPrice(int tableID)
        {
            try
            {
                float price = 0;
                List<BillInfoDTO> listBillInfo = BillInfoDAO.Instance.GetListMenuByTable(tableID);
                foreach (BillInfoDTO billInfo in listBillInfo)
                {
                    price += billInfo.TotalPrice;
                }
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(tableID);
                int discount = BillDAO.Instance.GetDiscount(idBill);

                float total = price * (100 - discount) / 100;

                Price.Text = total.ToString() + " VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region event
        private void BtnTable_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int tableID = ((sender as Button).Tag as TableDTO).ID;
                spmealstatus.Tag = (sender as Button).Tag;

                LoadMealStatus(tableID);
                LoadDiscount(tableID);
                LoadPrice(tableID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnMeal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int mealID = ((sender as Button).Tag as FoodDTO).Id;
                wpFood.Tag = (sender as Button).Tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TableDTO table = spmealstatus.Tag as TableDTO;
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.iD);
                int idFood = (wpFood.Tag as FoodDTO).Id;
                int count = Int16.Parse(txbQuantity.Text);
                string description = addtionalNoteTextbox.Text;
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), idFood, count, description);
                }
                else
                {
                    int idBillInfo = BillInfoDAO.Instance.GetBillInfo(idBill, idFood);
                    BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count, description);
                }
                LoadMealStatus(table.ID);
                LoadTable();
                LoadPrice(table.ID);
            }
            catch (NullReferenceException nullExcept)
            {
                MessageBox.Show("Please select table", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (FormatException formatExcept)
            {
                MessageBox.Show("Please input quantity", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.ToString(), "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void changeTableBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TableDTO table = spmealstatus.Tag as TableDTO;
                int id1 = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);

                int id2 = (ucCbTable.cbTable.SelectedItem as TableDTO).ID;

                MessageBox.Show(string.Format("Do you want to switch table from {0} to {1}", table.Name, (ucCbTable.cbTable.SelectedItem as TableDTO).Name), "Notify");
                TableDAO.Instance.SwitchTable(table.iD, id2);
                /*TableDAO.Instance.UpdateTableStatus(table.ID);
                TableDAO.Instance.UpdateTableStatus(id2);*/
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void applyDiscountBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TableDTO table = spmealstatus.Tag as TableDTO;
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
                int dis;
                try
                {
                    dis = Int16.Parse(discount.discountTextBox.Text);
                }
                catch
                {
                    dis = 0;
                }
                BillDAO.Instance.UpdateDiscount(idBill, dis);
                LoadPrice(table.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void exportBillBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TableDTO table = spmealstatus.Tag as TableDTO;
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
                int dis;
                int total;
                try
                {
                    dis = Int16.Parse(discount.discountTextBox.Text);
                    total = Int32.Parse(Price.Text.Split(" ")[0]);
                }
                catch
                {
                    dis = 0;
                    total = 0;
                }

                if (idBill != -1)
                {
                    MessageBox.Show("Do you want check out bill for " + table.Name, "Notify");
                    BillTemplate bill = new BillTemplate(table.iD, staffID);
                    bill.Show();
                    BillDAO.Instance.CheckOut(table.ID, total, dis);
                    //update table status
                    //TableDAO.Instance.UpdateTableStatus(table.ID);
                }
                spmealstatus.Children.Clear();
                LoadTable();
                Price.Text = "0 VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void cbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int id = 0;
                ComboBox cb = sender as ComboBox;
                if (cb.SelectedItem == null)
                    return;

                CategoryDTO selected = cb.SelectedItem as CategoryDTO;
                cb.Tag = selected;
                id = selected.Id;

                LoadFoodListByCategory(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StaffDTO staff = (sender as Button).Tag as StaffDTO;
                InfoStaff infoStaff = new InfoStaff(staff.Id);
                infoStaff.btnConfirm.Tag = staff;
                infoStaff.btnConfirm.Click += BtnConfirm_Click;
                infoStaff.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StaffDTO staff = (sender as Button).Tag as StaffDTO;
                tblName.Text = StaffDAO.Instance.GetNameById(staff.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        private void ChangepasswordButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ChangePassword changePassword = new ChangePassword();
                changePassword.txtUserNameEmployee.Text = StaffDAO.Instance.GetUserNameById(staffID);
                changePassword.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}