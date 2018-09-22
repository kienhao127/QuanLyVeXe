using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace QuanLyVeXe.GUI.UIAdminEmployee
{
    /// <summary>
    /// Interaction logic for ChucNangNhanVien.xaml
    /// </summary>
    public partial class ChucNangNhanVien : Page
    {
        public ChucNangNhanVien()
        {
            InitializeComponent();
            Main.Content = new QuanLyLichTrinh();
            btnQuanLyLichTrinh.Background = Brushes.DeepSkyBlue;
            dangNhap_Result currentUser = (dangNhap_Result)App.Current.Properties["currentUser"];
            if (currentUser.LoaiNguoiDung == 2)
            {
                btnTaoNguoiDung.Visibility = Visibility.Collapsed;
                btnQuanLyLichTrinh.Visibility = Visibility.Collapsed;
            }
        }

        private void btnQuanLyLichTrinh_Click(object sender, RoutedEventArgs e)
        {
            btnQuanLyLichTrinh.Background = Brushes.DeepSkyBlue;
            btnQuanLyChuyenXe.Background = Brushes.Gray;
            btnThongTinDatVe.Background = Brushes.Gray;
            btnTaoNguoiDung.Background = Brushes.Gray;
            Main.Content = new QuanLyLichTrinh();
        }

        private void btnQuanLyChuyenXe_Click(object sender, RoutedEventArgs e)
        {
            btnQuanLyLichTrinh.Background = Brushes.Gray;
            btnQuanLyChuyenXe.Background = Brushes.DeepSkyBlue;
            btnThongTinDatVe.Background = Brushes.Gray;
            btnTaoNguoiDung.Background = Brushes.Gray;
            Main.Content = new QuanLyChuyenXe();
        }

        private void btnThongTinDatVe_Click(object sender, RoutedEventArgs e)
        {
            btnQuanLyLichTrinh.Background = Brushes.Gray;
            btnQuanLyChuyenXe.Background = Brushes.Gray;
            btnThongTinDatVe.Background = Brushes.DeepSkyBlue;
            btnTaoNguoiDung.Background = Brushes.Gray;
            Main.Content = new ThongTinDatVe();
        }

        private void btnTaoNguoiDung_Click(object sender, RoutedEventArgs e)
        {
            btnQuanLyLichTrinh.Background = Brushes.Gray;
            btnQuanLyChuyenXe.Background = Brushes.Gray;
            btnThongTinDatVe.Background = Brushes.Gray;
            btnTaoNguoiDung.Background = Brushes.DeepSkyBlue;
            Main.Content = new TaoNguoiDung();
        }
    }
}
