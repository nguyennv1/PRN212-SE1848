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
using System.Windows.Shapes;
using BusinessObject;
using static System.Collections.Specialized.BitVector32;

namespace NguyenVanNguyenWPF
{
    /// <summary>
    /// Interaction logic for VieworderWindow.xaml
    /// </summary>
    public partial class VieworderWindow : Window
    {
        private Customers currentCustomer;

        public VieworderWindow(Customers customer)
        {
            InitializeComponent();
            currentCustomer = customer;

        }

    }
}
