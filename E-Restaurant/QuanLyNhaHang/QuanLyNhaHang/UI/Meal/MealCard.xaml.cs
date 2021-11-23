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
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using QuanLyNhaHang.MainTemplate;

namespace QuanLyNhaHang
{
    /// <summary>
    /// Interaction logic for MenuCard.xaml
    /// </summary>
    public partial class MealCard : UserControl
    {
        private string nameFood;
        public string NameFood
        {
            get { return nameFood; }
            set { nameFood = value; }
        }

        public MealCard()
        {
            InitializeComponent();
        }

        private void addButton_MouseEnter(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.Green;
        }

        private void addButton_MouseLeave(object sender, MouseEventArgs e)
        {
            addIcon.Foreground = Brushes.White;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void deleteButton_MouseEnter(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.Red;
        }

        private void deleteButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deleteIcon.Foreground = Brushes.White;
        }

        public void SetText(string mealName, string mealCategory, float mealPrice, int orderQuantity)
        {
            try
            {
                this.mealName.Text = mealName;
                this.mealCategory.Text = mealCategory;
                this.mealPrice.Text = mealPrice.ToString();
                this.orderQuantity.Text = orderQuantity.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private event EventHandler deleteMeal;
        public event EventHandler DeleteMeal
        {
            add { DeleteMeal += value; }
            remove { DeleteMeal -= value; }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = mealName.Text;
                if (FoodDAO.Instance.DeleteMeal(name))
                {
                    MessageBox.Show("Successfully");
                    if (deleteMeal != null)
                        deleteMeal(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                nameFood = mealName.Text;

                EditMeal editmeal = new EditMeal(mealName.Text);

                editmeal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}