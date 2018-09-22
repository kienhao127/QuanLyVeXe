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

namespace QuanLyVeXe.GUI.UIGeneral
{
    /// <summary>
    /// Interaction logic for DatVe.xaml
    /// </summary>
    public partial class DatVe : Page
    {
        string BenDi = "";
        string BenDen = "";
        DateTime? ngayGioDi = new DateTime?();
        string maChuyenXe = "";
        string maXe = "";
        int tongSoGheDuocChon = 0;
        List<int> danhSachGheDaChon = new List<int>();
        int giaVe = 0;
        int tongTien = 0;
        dangNhap_Result currentUser = null;
        public DatVe()
        {
            InitializeComponent();
            cboDiemKhoiHanh.ItemsSource = layDanhSachBenDiCoChuyen();
            cboDiemKhoiHanh.SelectedIndex = 0;
            currentUser = (dangNhap_Result)App.Current.Properties["currentUser"];
        }

        public List<string> layDanhSachBenDiCoChuyen()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachBenDiCoChuyen().ToList();
            }
        }

        public List<layDanhSachBenDenTuBenDi_Result> layDanhSachBenDenTuBenDi(string benDi)
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachBenDenTuBenDi(benDi).ToList();
            }
        }

        public List<DateTime?> layDanhSachNgayTuBenDiVaBenDen()
        {
            BenDi = cboDiemKhoiHanh.SelectedItem.ToString();
            BenDen = ((layDanhSachBenDenTuBenDi_Result)cboDiemDen.SelectedItem).TenBenXe;
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachNgayTuBenDiVaBenDen(BenDi, BenDen).ToList();
            }
        }

        private void btnDatVe_Click(object sender, RoutedEventArgs e)
        {
            panelChonTuyen.Visibility = Visibility.Collapsed;
            panelChonGhe.Visibility = Visibility.Visible;
            txtThongTinChuyen.Text = BenDi + " - " + BenDen + " - " + ngayGioDi.ToString();
            cboChonTuyenXe.ItemsSource = layDanhSachChuyenXeTuBenDiBenDenGioChay();
            tongSoGheDuocChon = Convert.ToInt32(txtSoLuongVe.Text);
        }

        public List<layDanhSachChuyenXeTuBenDiBenDenGioChay_Result> layDanhSachChuyenXeTuBenDiBenDenGioChay()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachChuyenXeTuBenDiBenDenGioChay(BenDi, BenDen,  (DateTime?) cboNgayKhoiHanh.SelectedItem).ToList();
            }
        }

        private void btnBackToStep1_Click(object sender, RoutedEventArgs e)
        {
            panelChonGhe.Visibility = Visibility.Collapsed;
            panelChonTuyen.Visibility = Visibility.Visible;
            cboChonTuyenXe.ItemsSource = null;
            panelGheNgoi.Children.Clear();
        }

        private void btnContinueToStep3_Click(object sender, RoutedEventArgs e)
        {
            panelChonGhe.Visibility = Visibility.Collapsed;
            panelThongTinHanhKhach.Visibility = Visibility.Visible;
            if (currentUser != null && currentUser.LoaiNguoiDung == 3)
            {
                txtEmail.Text = currentUser.Email;
                txtHoTen.Text = currentUser.HoTen;
                txtSoDT.Text = currentUser.SDT;
            }
        }

        private void btnBackToStep2_Click(object sender, RoutedEventArgs e)
        {
            panelThongTinHanhKhach.Visibility = Visibility.Collapsed;
            panelChonGhe.Visibility = Visibility.Visible;
        }

        private void btnContinueToStep4_Click(object sender, RoutedEventArgs e)
        {
            panelThongTinHanhKhach.Visibility = Visibility.Collapsed;
            panelDatMuaVe.Visibility = Visibility.Visible;
            txtTenTuyen.Text = BenDi + " - " + BenDen;
            txtNgayDi.Text = ngayGioDi.ToString();
            txtDiaDiemLenXe.Text = ((layDanhSachChuyenXeTuBenDiBenDenGioChay_Result)cboChonTuyenXe.SelectedItem).DiemXuatPhat;
            txtHoTenDayDu.Text = txtHoTen.Text;
            txtXacNhanEmail.Text = txtEmail.Text;
            txtSoDienThoai.Text = txtSoDT.Text;
            txtXacNhanTongTien.Text = tongTien.ToString() + "đ";
            txtDanhSachGhe.Text = "";
            txtDanhSachGhe.Text = "";
            for (int i = 0; i < danhSachGheDaChon.Count; i++)
            {
                txtDanhSachGhe.Text += danhSachGheDaChon[i].ToString();
                if (i != danhSachGheDaChon.Count - 1)
                {
                    txtDanhSachGhe.Text += ", ";
                }
            }
        }

        private void btnBackToStep3_Click(object sender, RoutedEventArgs e)
        {
            panelDatMuaVe.Visibility = Visibility.Collapsed;
            panelThongTinHanhKhach.Visibility = Visibility.Visible;
        }

        private void cboDiemKhoiHanh_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboDiemDen.ItemsSource = layDanhSachBenDenTuBenDi(cboDiemKhoiHanh.SelectedItem.ToString());
        }

        private void cboDiemDen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboNgayKhoiHanh.ItemsSource = layDanhSachNgayTuBenDiVaBenDen();
        }

        private void cboNgayKhoiHanh_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ngayGioDi = (DateTime?) cboNgayKhoiHanh.SelectedItem;
        }

        private void cboChonTuyenXe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboChonTuyenXe.ItemsSource != null)
            {
                maXe = ((layDanhSachChuyenXeTuBenDiBenDenGioChay_Result)cboChonTuyenXe.SelectedItem).MaXe;
                maChuyenXe = ((layDanhSachChuyenXeTuBenDiBenDenGioChay_Result)cboChonTuyenXe.SelectedItem).MaChuyenXe;
                giaVe = (int)((layDanhSachChuyenXeTuBenDiBenDenGioChay_Result)cboChonTuyenXe.SelectedItem).GiaVe;
                int? tongSoGhe = layTongSoGhe()[0];
                for (int i = 1; i <= tongSoGhe; i++)
                {
                    bool daDat = false;
                    Button btn = new Button();
                    var margin = btn.Margin;
                    margin.Left = 80;
                    margin.Right = 80;
                    margin.Top = 10;
                    margin.Bottom = 10;
                    btn.Margin = margin;
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Background = Brushes.DeepSkyBlue;
                    btn.BorderBrush = Brushes.DeepSkyBlue;
                    List<layDanhSachGheDaDat_Result> danhSachGheDaDat = layDanhSachGheDaDat();
                    for (int j = 0; j < danhSachGheDaDat.Count; j++)
                    {
                        if (danhSachGheDaDat[j].MaGhe == i)
                        {
                            btn.Background = Brushes.Gray;
                            btn.BorderBrush = Brushes.Gray;
                            btn.IsEnabled = false;
                            panelGheNgoi.Children.Add(btn);
                            daDat = true;
                        }
                    }

                    if (!daDat)
                    {
                        btn.Content = i;
                        btn.Tag = i;
                        btn.Click += Btn_Click;
                        panelGheNgoi.Children.Add(btn);
                    }
                }
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (danhSachGheDaChon.Contains(Convert.ToInt32(btn.Tag)))
            {
                danhSachGheDaChon.Remove(Convert.ToInt32(btn.Tag));
                btn.Background = Brushes.DeepSkyBlue;
                btn.BorderBrush = Brushes.DeepSkyBlue;
            }
            else
            {
                if (danhSachGheDaChon.Count == tongSoGheDuocChon)
                {
                    MessageBox.Show("Bạn đã chọn đủ ghế");
                }
                else
                {
                    danhSachGheDaChon.Add(Convert.ToInt32(btn.Tag));
                    btn.Background = Brushes.Orange;
                    btn.BorderBrush = Brushes.Orange;
                }
            }
            if (danhSachGheDaChon.Count == 0)
            {
                tbDanhSachGhe.Text = "Chưa chọn ghế";
            } else
            {
                tbDanhSachGhe.Text = "";
                for (int i = 0; i < danhSachGheDaChon.Count; i++)
                {
                    tbDanhSachGhe.Text += danhSachGheDaChon[i].ToString();
                    if (i != danhSachGheDaChon.Count - 1)
                    {
                        tbDanhSachGhe.Text += ", ";
                    }
                }
            }
            tongTien = giaVe * danhSachGheDaChon.Count;
            txtTongTien.Text = tongTien.ToString();
        }

        public List<int?> layTongSoGhe()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layTongSoGhe(maXe).ToList();
            }
        }

        public List<layDanhSachGheDaDat_Result> layDanhSachGheDaDat()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachGheDaDat(maChuyenXe).ToList();
            }
        }

        private void btnDatVeFinal_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                ctx.themNguoiDung("user", "Aa123456", txtHoTen.Text, txtEmail.Text, txtSoDT.Text, 3);
            }
        }

        private void btnMuaVe_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                ctx.themNguoiDung("user", "Aa123456", txtHoTen.Text, txtEmail.Text, txtSoDT.Text, 3);
            }
        }
    }
}
