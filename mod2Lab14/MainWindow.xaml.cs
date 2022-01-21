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

namespace mod2Lab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(
                new Product()
            {
                Name = "Хлеб",
                Price = 85,
                ImagePath = "Data/bread.png",
                Category = Categories.Food
            });
            products.Add(
                new Product()
                {
                    Name = "Пылесос",
                    Price = 2500,
                    ImagePath = "Data/vacuum.png",
                    Category = Categories.Appliances
                });
            products.Add(
                new Product()
                {
                    Name = "Шоколад",
                    Price = 150,
                    ImagePath = "Data/chocolate.png",
                    Category = Categories.Food
                });
            box.ItemsSource = products;
        }

    }
}
