﻿using LiveCharts;
using LiveCharts.Wpf;
using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for CartesianChart.xaml
    /// </summary>
    public partial class CartesianChart : UserControl
    {
        bool collIsBusy = false;
        public CartesianChart()
        {
            InitializeComponent();

            try
            {
                SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Profit",
                    Values = new ChartValues<float>(GetYearRevenue())
                }
            };


                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                Formatter = value => value.ToString("N");
                DataContext = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public CartesianChart(int year)
        {
            InitializeComponent();
            try
            {
                SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Profit",
                    Values = new ChartValues<float>(GetSelectedYearRevenue(year))
                }

            };
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                Formatter = value => value.ToString("N");
                DataContext = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private List<float> GetYearRevenue()
        {
            List<float> list = new List<float>();
            try
            {
                for (int month = 1; month < 13; month++)
                {
                    List<BillInfoDTO> reports = BillInfoDAO.Instance.GetListRevenue(month);
                    float profit = 0;
                    foreach (BillInfoDTO report in reports)
                    {

                        profit += (report.Price * report.Count);
                    }
                    list.Add(profit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return list;
        }
        private List<float> GetSelectedYearRevenue(int year)
        {
            List<float> list = new List<float>();
            try
            {
                for (int month = 1; month < 13; month++)
                {
                    List<BillInfoDTO> reports = BillInfoDAO.Instance.GetListRevenue(month, year);
                    float profit = 0;
                    foreach (BillInfoDTO report in reports)
                    {
                        profit += (report.Price * report.Count);
                    }
                    list.Add(profit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return list;
        }

        public SeriesCollection SeriesCollection
        {
            get;
            set;
        }
        public string[] Labels { get; set; }
        public Func<float, string> Formatter { get; set; }
    }
}