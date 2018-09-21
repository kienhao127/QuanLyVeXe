using QuanLyVeXe.GUI.UIGeneral;
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

namespace QuanLyVeXe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new DatVe();
        }

        private void btnLichTrinh_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new LichTrinh();
        }

        private void btnDangKy_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DangKy();
        }

        private void btnDatVe_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DatVe();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DangNhap();
        }
    }
}
