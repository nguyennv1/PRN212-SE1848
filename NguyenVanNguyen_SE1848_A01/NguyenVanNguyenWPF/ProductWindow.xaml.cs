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
using Services;

namespace NguyenVanNguyenWPF
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        bool isCompled = false;
        ProductService productService = new ProductService();
        public ProductWindow()
        {
            InitializeComponent();
            isCompled = false;
            productService.GenerateSampleDataset();
            lvProduct.ItemsSource = productService.GetProducts();
            isCompled = true;
        }

        public void btnSaveProduct_Click(object sender, RoutedEventArgs e)
        {
            

        }
        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isCompled == false)
            {
                return;//thao tac tai dl chua xong
            }
            if (e.AddedItems.Count < 0)
                return;
            Product p = e.AddedItems[0] as Product;
            if (p == null)
                return;
            txtId.Text = p.Id.ToString();
            txtName.Text = p.Name;
            txtCategoryId.Text = p.CategoryId.ToString();
            txtUnitPrice.Text = p.UnitPrice.ToString();
            txtUnitsStock.Text = p.UnitsStock.ToString();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isCompled = false;
                int id = int.Parse(txtId.Text);
                Product p = productService.GetProduct(id);
                if (p == null)
                {
                    MessageBox.Show("Khong tim thay san pham");
                    return;
                }
                    
                p.Name = txtName.Text;
                p.CategoryId = int.Parse(txtCategoryId.Text);
                p.UnitPrice = double.Parse(txtUnitPrice.Text);
                p.UnitsStock = int.Parse(txtUnitsStock.Text);
                bool kq = productService.UpdateProduct(p);

                if (kq == true)
                {
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = productService.GetProducts();
                }

                isCompled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi te le tec lec, chi tiet:" + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //luon luon phai xac thuc co muon xoa k.
                MessageBoxResult ret = MessageBox.Show(
                    "Ban co chac chan muon xoa khong?",//noi dung cua so
                    "Xac nhan", //tieu de cua cua so
                    MessageBoxButton.YesNo, //hien thi 2 lua chon yes-no
                    MessageBoxImage.Question);//hien thi bieu tuong can hoi
                if (ret == MessageBoxResult.No) // neu chon khong
                    return; // khong lam gi ca, thoat khoi ham
                isCompled = false; // chua hoan thanh thao tac
                int id = int.Parse(txtId.Text);
                bool kq = productService.DeleteProduct(id);
                if (kq == false) return;
                lvProduct.ItemsSource = null; // xoa nguon du lieu cua listview
                lvProduct.ItemsSource = productService.GetProducts(); // cap nhat lai nguon du lieu
                txtId.Text = "";
                txtName.Text = "";
                txtCategoryId.Text = "";
                txtUnitPrice.Text = "";
                txtUnitsStock.Text = "";
                isCompled = true; // da hoan thanh thao tac
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoa bi loi:" + ex.Message);
            }

        }

        private void btnSaveProduct_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                bool isCompled = false;
                Product p = new Product();
                p.Id = int.Parse(txtId.Text);
                p.Name = txtName.Text;
                p.CategoryId = int.Parse(txtCategoryId.Text);
                p.UnitPrice = double.Parse(txtUnitPrice.Text);
                p.UnitsStock = int.Parse(txtUnitsStock.Text);
                bool result = productService.SaveProduct(p);
                if (result)
                {
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = productService.GetProducts();
                    MessageBox.Show("Successfully");
                }
                isCompled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi te le tec lec, chi tiet:" + ex.Message);
                return;
            }
        }
    }
}
