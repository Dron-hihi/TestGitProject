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

namespace TestShop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ProductVM> LP = new List<ProductVM>();
        
        public MainWindow()
        {
            LP.Add(new ProductVM { Id = 1, Name = "Hreny", Price = 123, Category = "qwerty" });
            InitializeComponent();
        }
        
    }
}
