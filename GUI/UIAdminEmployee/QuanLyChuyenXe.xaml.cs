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
    }
}
