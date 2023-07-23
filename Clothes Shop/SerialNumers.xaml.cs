using MyProject;
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

namespace Clothes_Shop
{
    /// <summary>
    /// Interaction logic for SerialNumers.xaml
    /// </summary>
    public partial class SerialNumers : Window
    {
        private string serial = "A1B2-C3D4-E5F6-G7H8";
        string? enterserial;
        public SerialNumers()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtPass.Password is not null)
            {
                enterserial = txtPass.Password.ToString();
            }
        }

        private void btnserial_Click(object sender, RoutedEventArgs e)
        {
            if (enterserial == serial)
            {
                serialErrorRequired.Visibility = Visibility.Hidden;
                Register registerwindow = new Register();
                registerwindow.Show();
                this.Close();
            }
            else
            {
                serialErrorRequired.Visibility = Visibility.Visible;
            }
        }

        private void BackToLogin(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
