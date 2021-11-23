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
    /// Interaction logic for MenuManager.xaml
    /// </summary>
    public partial class MealManager : UserControl
    {

        public MealManager()
        {
            InitializeComponent();

        }

        private void btnSortPrice_Click(object sender, RoutedEventArgs e)
        {
            if (priceSortIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                priceSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                priceSortIcon.Foreground = Brushes.Green;
            }
            else
            {
                priceSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                priceSortIcon.Foreground = Brushes.Red;
            }
        }

        private void btnSortCategory_Click(object sender, RoutedEventArgs e)
        { 
            if (categorySortIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                categorySortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                categorySortIcon.Foreground = Brushes.Green;
            }
            else
            {
                categorySortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                categorySortIcon.Foreground = Brushes.Red;
            }
        }

        private void btnSortName_Click(object sender, RoutedEventArgs e)
        {
            if (nameSortIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                nameSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                nameSortIcon.Foreground = Brushes.Green;
            }
            else
            {
                nameSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                nameSortIcon.Foreground = Brushes.Red;
            }
        }

        private void btnSortQuantity_Click(object sender, RoutedEventArgs e)
        {
            if (quantitySortIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                quantitySortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                quantitySortIcon.Foreground = Brushes.Green;
            }
            else
            {
                quantitySortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                quantitySortIcon.Foreground = Brushes.Red;
            }
        }
    }
}
