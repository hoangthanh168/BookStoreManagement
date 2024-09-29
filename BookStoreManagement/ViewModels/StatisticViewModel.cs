using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class StatisticsViewModel : BindableBase
    {
        private DateTime _revenueStartDate;
        private DateTime _revenueEndDate;
        private ObservableCollection<RevenuePerEmployee> _revenuePerEmployee;
        private SeriesCollection _revenueChartSeries;
        private string[] _revenueChartLabels;

        private DateTime _invoiceStartDate;
        private DateTime _invoiceEndDate;
        private Employee _selectedInvoiceEmployee;
        private ObservableCollection<Employee> _employees;
        private ObservableCollection<Invoice> _salesInvoices;
        private SeriesCollection _invoiceChartSeries;
        private string[] _invoiceChartLabels;

        public StatisticsViewModel()
        {
            RevenuePerEmployee = new ObservableCollection<RevenuePerEmployee>();
            SalesInvoices = new ObservableCollection<Invoice>();
            Employees = new ObservableCollection<Employee>();
            RevenueStartDate = DateTime.Now.AddMonths(-1);
            RevenueEndDate = DateTime.Now;
            InvoiceStartDate = DateTime.Now.AddMonths(-1);
            InvoiceEndDate = DateTime.Now;
            RevenueChartSeries = new SeriesCollection();
            InvoiceChartSeries = new SeriesCollection();
            FilterRevenueCommand = new DelegateCommand(FilterRevenue);
            FilterInvoiceCommand = new DelegateCommand(FilterInvoices);
            LoadSampleData();
        }

        public DateTime RevenueStartDate
        {
            get => _revenueStartDate;
            set => SetProperty(ref _revenueStartDate, value);
        }

        public DateTime RevenueEndDate
        {
            get => _revenueEndDate;
            set => SetProperty(ref _revenueEndDate, value);
        }

        public ObservableCollection<RevenuePerEmployee> RevenuePerEmployee
        {
            get => _revenuePerEmployee;
            set => SetProperty(ref _revenuePerEmployee, value);
        }

        public SeriesCollection RevenueChartSeries
        {
            get => _revenueChartSeries;
            set => SetProperty(ref _revenueChartSeries, value);
        }

        public string[] RevenueChartLabels
        {
            get => _revenueChartLabels;
            set => SetProperty(ref _revenueChartLabels, value);
        }

        public Func<double, string> YFormatter => value => value.ToString("N0 VND");

        public DateTime InvoiceStartDate
        {
            get => _invoiceStartDate;
            set => SetProperty(ref _invoiceStartDate, value);
        }

        public DateTime InvoiceEndDate
        {
            get => _invoiceEndDate;
            set => SetProperty(ref _invoiceEndDate, value);
        }

        public Employee SelectedInvoiceEmployee
        {
            get => _selectedInvoiceEmployee;
            set => SetProperty(ref _selectedInvoiceEmployee, value);
        }

        public ObservableCollection<Employee> Employees
        {
            get => _employees;
            set => SetProperty(ref _employees, value);
        }

        public ObservableCollection<Invoice> SalesInvoices
        {
            get => _salesInvoices;
            set => SetProperty(ref _salesInvoices, value);
        }

        public SeriesCollection InvoiceChartSeries
        {
            get => _invoiceChartSeries;
            set => SetProperty(ref _invoiceChartSeries, value);
        }

        public string[] InvoiceChartLabels
        {
            get => _invoiceChartLabels;
            set => SetProperty(ref _invoiceChartLabels, value);
        }

        public ICommand FilterRevenueCommand { get; }
        public ICommand FilterInvoiceCommand { get; }

        private void FilterRevenue()
        {
            var filteredRevenue = RevenuePerEmployee
                .Where(r => r.RevenueDate >= RevenueStartDate && r.RevenueDate <= RevenueEndDate)
                .ToList();

            UpdateRevenueChart(filteredRevenue);
        }

        private void FilterInvoices()
        {
            var filteredInvoices = SalesInvoices
                .Where(i => i.InvoiceDate >= InvoiceStartDate && i.InvoiceDate <= InvoiceEndDate)
                .ToList();

            if (SelectedInvoiceEmployee != null)
            {
                filteredInvoices = filteredInvoices
                    .Where(i => i.Employee.EmployeeID == SelectedInvoiceEmployee.EmployeeID)
                    .ToList();
            }

            UpdateInvoiceChart(filteredInvoices);
        }

        private void UpdateRevenueChart(IEnumerable<RevenuePerEmployee> revenueData)
        {
            RevenueChartSeries.Clear();
            var columnSeries = new ColumnSeries
            {
                Title = "Doanh thu",
                Values = new ChartValues<double>(revenueData.Select(r => r.Revenue))
            };

            RevenueChartSeries.Add(columnSeries);
            RevenueChartLabels = revenueData.Select(r => r.EmployeeName).ToArray();
        }

        private void UpdateInvoiceChart(IEnumerable<Invoice> invoices)
        {
            InvoiceChartSeries.Clear();
            var groupedInvoices = invoices
                .GroupBy(i => i.InvoiceDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalAmount = g.Sum(i => i.AmountPaid)
                })
                .ToList();

            var lineSeries = new LineSeries
            {
                Title = "Tổng tiền",
                Values = new ChartValues<float>(groupedInvoices.Select(g => g.TotalAmount))
            };

            InvoiceChartSeries.Add(lineSeries);
            InvoiceChartLabels = groupedInvoices.Select(g => g.Date.ToString("dd/MM/yyyy")).ToArray();
        }

        private void LoadSampleData()
        {
            Employees.Add(new Employee { EmployeeID = 1, FullName = "Nguyen Van A" });
            Employees.Add(new Employee { EmployeeID = 2, FullName = "Tran Thi B" });

            RevenuePerEmployee.Add(new RevenuePerEmployee
            {
                EmployeeName = "Nguyen Van A",
                Revenue = 1000000,
                RevenueDate = DateTime.Now.AddDays(-10)
            });
            RevenuePerEmployee.Add(new RevenuePerEmployee
            {
                EmployeeName = "Tran Thi B",
                Revenue = 1500000,
                RevenueDate = DateTime.Now.AddDays(-5)
            });

            SalesInvoices.Add(new Invoice
            {
                InvoiceID = 1,
                InvoiceDate = DateTime.Now.AddDays(-10),
                Employee = Employees[0],
                Customer = new Customer { FullName = "Le Thi C" },
                AmountPaid = 500000
            });
            SalesInvoices.Add(new Invoice
            {
                InvoiceID = 2,
                InvoiceDate = DateTime.Now.AddDays(-5),
                Employee = Employees[1],
                Customer = new Customer { FullName = "Pham Van D" },
                AmountPaid = 1000000
            });

            FilterRevenue();
            FilterInvoices();
        }
    }

    public class RevenuePerEmployee
    {
        public string EmployeeName { get; set; }
        public double Revenue { get; set; }
        public DateTime RevenueDate { get; set; }
    }
}
