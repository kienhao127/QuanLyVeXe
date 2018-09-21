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
    /// Interaction logic for LichTrinh.xaml
    /// </summary>
    public partial class LichTrinh : Page
    {
        public LichTrinh()
        {
            InitializeComponent();
            DataContext = layDanhSachLichTrinh();
        }


        public List<layDanhSachLichTrinh_Result> layDanhSachLichTrinh()
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.layDanhSachLichTrinh().ToList();
            }
        }

        private void btnMuaVe_Click(object sender, RoutedEventArgs e)
        {
            DatVe datVe = new DatVe();
            this.NavigationService.Navigate(datVe);
        }
    }


}
