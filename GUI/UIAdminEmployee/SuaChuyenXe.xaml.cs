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

namespace QuanLyVeXe.GUI.UIAdminEmployee
{
    /// <summary>
    /// Interaction logic for ThemSuaChuyenXe.xaml
    /// </summary>
    public partial class SuaChuyenXe : Window
    {
        public SuaChuyenXe(layDanhSachChuyenXe_Result chuyenXe)
        {
            InitializeComponent();

            txtBenDen.Text = chuyenXe.BenDen;
            txtBenDi.Text = chuyenXe.BenDi;
            txtGiaVe.Text = chuyenXe.GiaVe.ToString();
            txtLoaiXe.Text = chuyenXe.TenLoaiXe;
            txtMaLichTrinh.Text = chuyenXe.MaLichTrinh;
            dtpGioChay.Value = chuyenXe.GioChay;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
         
        }
    }
}
