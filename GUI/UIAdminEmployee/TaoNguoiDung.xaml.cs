﻿using System;
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
    /// Interaction logic for TaoNguoiDung.xaml
    /// </summary>
    public partial class TaoNguoiDung : Page
    {
        public TaoNguoiDung()
        {
            InitializeComponent();
            cboLoaiNguoiDung.ItemsSource = layDanhSachLoaiNguoiDung();
        }

        public List<layDanhSachLoaiNguoiDung_Result> layDanhSachLoaiNguoiDung()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachLoaiNguoiDung().ToList();
            }
        }
    }
}
