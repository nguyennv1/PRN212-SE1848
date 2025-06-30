using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TreeViewWpfApp.models;

namespace TreeViewWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Category> categories = SampleDataset.GenerateDataset();
        public MainWindow()
        {
            InitializeComponent();
            DisplayDataIntoTreeView();
        }
        private void DisplayDataIntoTreeView()
        {
            //xoa du lieu cu di
            tvCategory.Items.Clear();
            //tao nut goc
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hang Quang Dong";
            tvCategory.Items.Add(root);

            //vong lap 1: nap kho hang len cay
            foreach (KeyValuePair<int, Category> item in categories)
            {
                Category cate = item.Value;
                //tao category node
                TreeViewItem cate_Node = new TreeViewItem();
                cate_Node.Header = cate;
                root.Items.Add(cate_Node);
                // vong lap 2: nap san pham cua thu muc len cay
                foreach(KeyValuePair<int,Product> subItem in cate.Products)
                {
                    Product p = subItem.Value;
                    //tao product node
                    TreeViewItem p_Node = new TreeViewItem();
                    p_Node.Header = p;
                    //dua p_Node vao len cate_Node;
                    cate_Node.Items.Add(p_Node);
                }
            }

        }
    }
}