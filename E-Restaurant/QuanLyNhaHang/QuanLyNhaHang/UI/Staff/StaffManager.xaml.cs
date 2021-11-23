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
    /// Interaction logic for StaffManager.xaml
    /// </summary>
    public partial class StaffManager : UserControl
    {
        public StaffManager()
        {
            InitializeComponent();

        }

        public void btnSortName_Click(object sender, RoutedEventArgs e)
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

        public void btnSortSalary_Click(object sender, RoutedEventArgs e)
        {
            if (salarySortIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                salarySortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                salarySortIcon.Foreground = Brushes.Green;
            }
            else
            {
                salarySortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                salarySortIcon.Foreground = Brushes.Red;
            }
        }
        public void btnSortPosition_Click(object sender, RoutedEventArgs e)
        {
            if (positionSortIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom)
            {
                positionSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowTop;
                positionSortIcon.Foreground = Brushes.Green;
            }
            else
            {
                positionSortIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ArrowBottom;
                positionSortIcon.Foreground = Brushes.Red;
            }
        }
    }
}
