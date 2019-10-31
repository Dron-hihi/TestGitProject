using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using TestShop.DAL;

namespace TestShop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ProductVM> LP = new List<ProductVM>();

        public ApplicationContext appcon;


        public MainWindow()
        {
            InitializeComponent();
            appcon = new ApplicationContext();
            var prods = appcon.Products.ToList();
            LP = prods.Select(x => new ProductVM { Id = x.Id, Name = x.Name, Price = x.Price, Category = x.Category }).ToList();
            LB_Main.ItemsSource = LP;

        }

    }
}
