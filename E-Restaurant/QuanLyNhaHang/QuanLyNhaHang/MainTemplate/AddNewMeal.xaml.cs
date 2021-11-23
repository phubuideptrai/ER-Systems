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
using Microsoft.Win32;
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for AddNewMeal.xaml
    /// </summary>
    public partial class AddNewMeal : Window
    {
        public AddNewMeal()
        {
            InitializeComponent();
            LoadCategory();
        }

        List<FoodDTO> SearchFoodByName(string name)
        {
            List<FoodDTO> listFoodDTO = FoodDAO.Instance.SearchFoodByName(name);

            return listFoodDTO;
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        #region events
        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = txtNameMeal.Text;
                string category = cmbCategory.Text;
                int categoryid = (cmbCategory.SelectedItem as CategoryDTO).Id;
                float price = float.Parse(txtPriceMeal.Text);

                if (FoodDAO.Instance.AddMeal(name, categoryid, price))
                {
                    MessageBox.Show("Add New Meal Successfully");

                    if (addMeal != null)
                        addMeal(this, new EventArgs());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add New Meal Failed");
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
        private event EventHandler addMeal;
        public event EventHandler AddMeal
        {
            add { addMeal += value; }
            remove { addMeal -= value; }
        }
        #endregion

        #region Method
        void LoadCategory()
        {
            try
            {
                List<CategoryDTO> listCategory = CategoryDAO.Instance.GetListCategory();
                cmbCategory.ItemsSource = listCategory;
                cmbCategory.DisplayMemberPath = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnlyNumber(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion
    }
}