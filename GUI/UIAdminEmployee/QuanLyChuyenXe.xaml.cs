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

namespace QuanLyVeXe.GUI.UIAdminEmployee
{
    /// <summary>
    /// Interaction logic for QuanLyChuyenXe.xaml
    /// </summary>
    public partial class QuanLyChuyenXe : Page
    {
        public QuanLyChuyenXe()
        {
            InitializeComponent();
            DataContext = layTatCaLichTrinh();
        }

        public List<layTatCaLichTrinh_Result> layTatCaLichTrinh()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layTatCaLichTrinh().ToList();
            }
        }

        private void btnXemChuyenXe_Click(object sender, RoutedEventArgs e)
        {
            chuyenXeDataGrid.ItemsSource = null;
            chuyenXeDataGrid.ItemsSource = layDanhSachChuyenXe();
            panelDanhSachChuyenXe.Visibility = Visibility.Visible;
            panelThemChuyenXe.Visibility = Visibility.Visible;
            if (layDanhSachChuyenXe().Count == 0)
            {
                txtKhongCoChuyenXe.Visibility = Visibility.Visible;
            }
            else
            {
                txtKhongCoChuyenXe.Visibility = Visibility.Collapsed;
            }

            layTatCaLichTrinh_Result lichTrinh = (layTatCaLichTrinh_Result)lichTrinhDataGrid.SelectedItem;
            txtMaLichTrinh.Text = lichTrinh.MaLichTrinh;
            txtLoaiXe.Text = lichTrinh.TenLoaiXe;
            txtBenDi.Text = lichTrinh.BenDi;
            txtBenDen.Text = lichTrinh.BenDen;
        }

        public List<layDanhSachChuyenXe_Result> layDanhSachChuyenXe()
        {
            layTatCaLichTrinh_Result lichTrinh = (layTatCaLichTrinh_Result)lichTrinhDataGrid.SelectedItem;
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachChuyenXe(lichTrinh.MaBenDi, lichTrinh.MaBenDen).ToList();
            }
        }

        private void btnThemChuyenXe_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            layDanhSachChuyenXe_Result chuyenXe = (layDanhSachChuyenXe_Result)chuyenXeDataGrid.SelectedItem;
            SuaChuyenXe suaChuyenXe = new SuaChuyenXe(chuyenXe);
            suaChuyenXe.ShowDialog();
        }
    }
}
