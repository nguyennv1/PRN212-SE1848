using System;
using System.Windows;

namespace RadioButtonControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnGui_Click(object sender, RoutedEventArgs e)
        {
            string binhChon = "";
            if (radRatTot.IsChecked == true)
                binhChon = radRatTot.Content.ToString();
            else if (radTot.IsChecked == true)
                binhChon = radTot.Content.ToString();
            else if (radTamDuoc.IsChecked == true)
                binhChon = radTamDuoc.Content.ToString();
            else if (radKhongTot.IsChecked == true)
                binhChon = radKhongTot.Content.ToString();

            string gioiTinh = "";
            if (radNam.IsChecked == true)
                gioiTinh = radNam.Content.ToString();
            else if (radNu.IsChecked == true)
                gioiTinh = radNu.Content.ToString();

            string infor = "Bạn bình chọn Hệ Thống = " + binhChon + Environment.NewLine;
            infor += "Giới tính của bạn = " + gioiTinh;

            MessageBoxResult ret = MessageBox.Show(infor, "Mời bạn xác nhận",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (ret == MessageBoxResult.Yes)
            {
                // xác nhận
            }
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
