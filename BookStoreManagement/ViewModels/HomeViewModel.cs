using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using BookStoreManagement.Mvvm;
using BookStoreManagement.Models;
using LiveCharts;
using LiveCharts.Wpf;

namespace BookStoreManagement.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        // Summary Properties
        private int _soldProductsCount;
        public int SoldProductsCount
        {
            get => _soldProductsCount;
            set => SetProperty(ref _soldProductsCount, value);
        }

        private float _totalRevenue;
        public float TotalRevenue
        {
            get => _totalRevenue;
            set => SetProperty(ref _totalRevenue, value);
        }

        private int _totalCustomers;
        public int TotalCustomers
        {
            get => _totalCustomers;
            set => SetProperty(ref _totalCustomers, value);
        }

        // Revenue Chart Properties
        private SeriesCollection _revenueSeries;
        public SeriesCollection RevenueSeries
        {
            get => _revenueSeries;
            set => SetProperty(ref _revenueSeries, value);
        }

        private string[] _revenueLabels;
        public string[] RevenueLabels
        {
            get => _revenueLabels;
            set => SetProperty(ref _revenueLabels, value);
        }

        public Func<double, string> RevenueFormatter { get; set; }

        private string _selectedRevenuePeriod;
        public string SelectedRevenuePeriod
        {
            get => _selectedRevenuePeriod;
            set
            {
                if (SetProperty(ref _selectedRevenuePeriod, value))
                {
                    LoadRevenueData();
                }
            }
        }

        // Top Products Chart Properties
        private SeriesCollection _topProductsSeries;
        public SeriesCollection TopProductsSeries
        {
            get => _topProductsSeries;
            set => SetProperty(ref _topProductsSeries, value);
        }

        private string[] _productLabels;
        public string[] ProductLabels
        {
            get => _productLabels;
            set => SetProperty(ref _productLabels, value);
        }

        public Func<double, string> ProductFormatter { get; set; }

        private string _selectedTopProductsPeriod;
        public string SelectedTopProductsPeriod
        {
            get => _selectedTopProductsPeriod;
            set
            {
                if (SetProperty(ref _selectedTopProductsPeriod, value))
                {
                    LoadTopProductsData();
                }
            }
        }

        // Constructor
        public HomeViewModel()
        {
            // Initialize periods
            SelectedRevenuePeriod = "Hôm nay";
            SelectedTopProductsPeriod = "Từ trước đến nay";

            // Initialize formatters
            RevenueFormatter = value => value.ToString("N0") + " đ";
            ProductFormatter = value => value.ToString("N0");

            // Load initial data
            LoadSummaryData();
            LoadRevenueData();
            LoadTopProductsData();
        }

        // Load summary data
        private void LoadSummaryData()
        {
            // Replace with actual data fetching logic
            SoldProductsCount = 100;
            TotalRevenue = 2000000; // In your currency units
            TotalCustomers = 50;
        }

        // Load revenue data based on the selected period
        private void LoadRevenueData()
        {
            // Create new collections
            var newRevenueSeries = new SeriesCollection();
            var labels = new List<string>();
            var values = new ChartValues<double>();

            if (SelectedRevenuePeriod == "Hôm nay")
            {
                labels.AddRange(new[] { "08:00", "10:00", "12:00", "14:00", "16:00", "18:00" });
                values.AddRange(new double[] { 100000, 200000, 150000, 300000, 250000, 400000 });
            }
            else if (SelectedRevenuePeriod == "Hôm qua")
            {
                labels.AddRange(new[] { "08:00", "10:00", "12:00", "14:00", "16:00", "18:00" });
                values.AddRange(new double[] { 80000, 180000, 120000, 280000, 230000, 370000 });
            }
            else if (SelectedRevenuePeriod == "Tuần này")
            {
                labels.AddRange(new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" });
                values.AddRange(new double[] { 1000000, 1500000, 1200000, 1800000, 2000000, 2200000, 2500000 });
            }
            else if (SelectedRevenuePeriod == "Tháng này")
            {
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                labels = Enumerable.Range(1, daysInMonth).Select(d => d.ToString()).ToList();
                values.AddRange(Enumerable.Range(1, daysInMonth).Select(i => (double)(i * 100000)));
            }

            newRevenueSeries.Add(new LineSeries
            {
                Title = "Doanh thu",
                Values = values
            });

            RevenueSeries = newRevenueSeries;
            RevenueLabels = labels.ToArray();

            // Notify property changes
            OnPropertyChanged(nameof(RevenueSeries));
            OnPropertyChanged(nameof(RevenueLabels));
        }

        // Load top products data based on the selected period
        private void LoadTopProductsData()
        {
            // Create new collections
            var newTopProductsSeries = new SeriesCollection();
            var labels = new List<string>();
            var values = new ChartValues<int>();

            if (SelectedTopProductsPeriod == "Từ trước đến nay")
            {
                labels.AddRange(new[] { "Book A", "Book B", "Book C", "Book D", "Book E" });
                values.AddRange(new int[] { 500, 450, 400, 350, 300 });
            }
            else if (SelectedTopProductsPeriod == "Hôm nay")
            {
                labels.AddRange(new[] { "Book A", "Book B", "Book C", "Book D", "Book E" });
                values.AddRange(new int[] { 50, 45, 40, 35, 30 });
            }
            else if (SelectedTopProductsPeriod == "Tuần này")
            {
                labels.AddRange(new[] { "Book A", "Book B", "Book C", "Book D", "Book E" });
                values.AddRange(new int[] { 150, 145, 140, 135, 130 });
            }
            else if (SelectedTopProductsPeriod == "Tháng này")
            {
                labels.AddRange(new[] { "Book A", "Book B", "Book C", "Book D", "Book E" });
                values.AddRange(new int[] { 300, 295, 290, 285, 280 });
            }

            newTopProductsSeries.Add(new ColumnSeries
            {
                Title = "Số lượng",
                Values = values
            });

            TopProductsSeries = newTopProductsSeries;
            ProductLabels = labels.ToArray();

            // Notify property changes
            OnPropertyChanged(nameof(TopProductsSeries));
            OnPropertyChanged(nameof(ProductLabels));
        }
    }
}
