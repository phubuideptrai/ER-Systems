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
    /// Interaction logic for MealStatusCard.xaml
    /// </summary>
    public partial class ChangeMealStatusCard : UserControl
    {
        public ChangeMealStatusCard()
        {
            InitializeComponent();
        }

        public void SetText(string category, string foodname, int count, string des, int status)
        {
            try
            {
                mealName.Text = foodname;
                mealCategory.Text = category;
                mealQuantity.Text = count.ToString();
                additonalNote.Text = des;
                if (status == 1)
                    cbStatus.SelectedIndex = 1;
                else
                    cbStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
