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
    /// Interaction logic for SuaLichTrinh.xaml
    /// </summary>
    public partial class SuaLichTrinh : Window
    {
        layTatCaLichTrinh_Result lichTrinh = null;
        public SuaLichTrinh()
        {
            InitializeComponent();
        }

        public SuaLichTrinh(layTatCaLichTrinh_Result lichTrinh)
        {
            InitializeComponent();
            this.lichTrinh = lichTrinh;
            cboBenDi.ItemsSource = layDanhSachBenXe();
            cboBenDen.ItemsSource = layDanhSachBenXe();
            cboLoaiXe.ItemsSource = layDanhSachLoaiXe();
            txtMaLichTrinh.Text = lichTrinh.MaLichTrinh;
            txtQuangDuong.Text = lichTrinh.QuangDuong;
            txtThoiGian.Text = lichTrinh.ThoiGian;

            for (int i = 0; i < layDanhSachBenXe().Count; i++)
            {
                if (layDanhSachBenXe()[i].MaBenXe == lichTrinh.MaBenDen)
                {
                    cboBenDen.SelectedIndex = i;
                }
                if (layDanhSachBenXe()[i].MaBenXe == lichTrinh.MaBenDi)
                {
                    cboBenDi.SelectedIndex = i;
                }
            }

            for (int i = 0; i < layDanhSachLoaiXe().Count; i++)
            {
                if (layDanhSachLoaiXe()[i].TenLoaiXe == lichTrinh.TenLoaiXe)
                {
                    cboLoaiXe.SelectedIndex = i;
                }
            }
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

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
