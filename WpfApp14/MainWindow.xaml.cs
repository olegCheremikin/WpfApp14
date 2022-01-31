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
using System.Collections.ObjectModel;

namespace WpfApp14
{

    public partial class MainWindow : Window
    {

        public ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>
                {
                    new Product { NameProduct = "Молоко", PriceProduct = 55, ImageProduct = @"Data\milk.png", CategoryProduct = Categories.Food },
                    new Product { NameProduct = "Колбаса", PriceProduct = 620, ImageProduct = @"Data\kolbsa.png", CategoryProduct = Categories.Food },
                    new Product { NameProduct = "Телефон", PriceProduct = 12999, ImageProduct = @"Data\mobile.png", CategoryProduct = Categories.Appliances },
                    new Product { NameProduct = "Микроволновка", PriceProduct = 9999, ImageProduct = @"Data\micro.png", CategoryProduct = Categories.Appliances }
                };

            listBox.ItemsSource = products;
        }
    }

}
