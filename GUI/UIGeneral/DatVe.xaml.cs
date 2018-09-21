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
        public DatVe()
        {
            InitializeComponent();
        }

        private void btnDatVe_Click(object sender, RoutedEventArgs e)
        {
            panelChonTuyen.Visibility = Visibility.Collapsed;
            panelChonGhe.Visibility = Visibility.Visible;
        }

        private void btnBackToStep1_Click(object sender, RoutedEventArgs e)
        {
            panelChonGhe.Visibility = Visibility.Collapsed;
            panelChonTuyen.Visibility = Visibility.Visible;
        }

        private void btnContinueToStep3_Click(object sender, RoutedEventArgs e)
        {
            panelChonGhe.Visibility = Visibility.Collapsed;
            panelThongTinHanhKhach.Visibility = Visibility.Visible;
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
        }

        private void btnBackToStep3_Click(object sender, RoutedEventArgs e)
        {
            panelDatMuaVe.Visibility = Visibility.Collapsed;
            panelThongTinHanhKhach.Visibility = Visibility.Visible;
        }
    }
}
