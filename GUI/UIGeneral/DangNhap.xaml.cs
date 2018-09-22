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
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Page
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            //List<dangNhap_Result> user = dangNhap(txtEmail.Text, txtPassword.Password);
            List<dangNhap_Result> user = dangNhap("hao@gmail.com", "123456");
            if (user.Count == 1)
            {
                App.Current.Properties["currentUser"] = user[0];
                MainWindow main = (MainWindow) Window.GetWindow(this);
                main.borderDangNhap.Visibility = Visibility.Collapsed;
                main.borderDangKy.Visibility = Visibility.Collapsed;
                main.txtFullname.Visibility = Visibility.Visible;
                main.txtFullname.Text = user[0].HoTen;
                main.txtHello.Visibility = Visibility.Visible;
                main.btnThoat.Visibility = Visibility.Visible;
                NavigationService.Navigate(new DatVe());
            }

        }

        public List<dangNhap_Result> dangNhap(string email, string password)
        {
            using (var ctx = new DB_BANVEXEEntities())
            {
                return ctx.dangNhap(email, password).ToList();
            }
        }
    }
}
