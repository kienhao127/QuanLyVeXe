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
    /// Interaction logic for QuanLyLichTrinh.xaml
    /// </summary>
    public partial class QuanLyLichTrinh : Page
    {
        public QuanLyLichTrinh()
        {
            InitializeComponent();
            DataContext = layTatCaLichTrinh();
            cboBenDi.ItemsSource = layDanhSachBenXe();
            cboBenDen.ItemsSource = layDanhSachBenXe();
            cboLoaiXe.ItemsSource = layDanhSachLoaiXe();
            panelAddOrEdit.Visibility = Visibility.Visible;
        }

        public List<layDanhSachLoaiXe_Result> layDanhSachLoaiXe()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachLoaiXe().ToList();
            }
        }

        public List<layDanhSachBenXe_Result> layDanhSachBenXe()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachBenXe().ToList();
            }
        }

        public List<layTatCaLichTrinh_Result> layTatCaLichTrinh()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layTatCaLichTrinh().ToList();
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (txtMaLichTrinh.Text != "" && txtQuangDuong.Text != "" && txtThoiGian.Text != "")
            {
                using (var ctx = new DB_BANVEXEEntities())
                {
                    int result = ctx.themLichTrinh(txtMaLichTrinh.Text, txtThoiGian.Text, txtQuangDuong.Text, ((layDanhSachBenXe_Result)cboBenDi.SelectedItem).MaBenXe, ((layDanhSachBenXe_Result)cboBenDen.SelectedItem).MaBenXe, ((layDanhSachLoaiXe_Result)cboLoaiXe.SelectedItem).MaLoaiXe);
                    if (result != 0)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
        }

        private void btnShowAdd_Click(object sender, RoutedEventArgs e)
        {
            panelAddOrEdit.Visibility = Visibility.Visible;
            btnThem.Content = "Thêm";
        }

        private void btnSuaLichTrinh_Click(object sender, RoutedEventArgs e)
        {
            SuaLichTrinh suaLichTrinh = new SuaLichTrinh((layTatCaLichTrinh_Result)lichTrinhDataGrid.SelectedItem);
            suaLichTrinh.ShowDialog();
        }
    }
}
