using Clothes_Shop;
using DAL;
using DAL.EFCRUD;
using DAL.EFCRUD.LogedService;
using DAL.EFCRUD.RegisterService;
using DAL.Models;
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

namespace MyProject
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       private string username="";
      private  string password="";
      private readonly ILoggedService<LogedIn> service;
       private readonly IServiceRegister<Registers> serviceregister;
        public Login()
        {
            InitializeComponent();
            service = new LoggedService(new EntityContextFactory());
            serviceregister= new ServiceRegister(new EntityContextFactory());
            try
            {
                string result = service.GetUserName();
                if(result.Length>2)
                {
                    MainWindow home = new MainWindow();
                    home.Show();
                    this.Close();
                }
            }
            catch
            {
                throw;
            }
          
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtUser.Text is not null)
            {
                username=txtUser.Text.ToString();
            }
            
        }

        private void txtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            
            if (txtPass.Password is not null)
            {
                password = txtPass.Password.ToString();
            }
        }

        private  void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (username.Length > 0)
            {
                userErrorRequired.Visibility = Visibility.Hidden;
            }
            else
            {
                userErrorRequired.Visibility = Visibility.Visible;
            }

            if (password.Length > 0)
            {
                passErrorRequired.Visibility = Visibility.Hidden;
            }
            else
            {
                passErrorRequired.Visibility = Visibility.Visible;
            }
            //code log in database
            try
            {
                Registers registers = serviceregister.FindName(username);
                if(registers is null)
                {
                    MessageBox.Show("اسم المستخدم غير صحيح");
                }
                else if (username == registers.Name && password == registers.Password)
                {
                    LogedIn obj = service.UpdateLoggedIn(username);
                    if (obj is not null)
                    {
                        MainWindow homewindow = new MainWindow();
                        homewindow.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("كلمة السر غير صحيحه");
                }
            }
            catch
            {
                throw;
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            SerialNumers serialwindow = new SerialNumers();
            serialwindow.Show();
            this.Close();
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            ForgotPassword forgotPasswordwindow = new ForgotPassword();
            forgotPasswordwindow.ShowDialog();
            forgotPasswordwindow.Topmost = true;
        }

        private void Delete_Account(object sender, MouseButtonEventArgs e)
        {
            DeleteAccount deleteAccountWindow = new DeleteAccount();
            deleteAccountWindow.ShowDialog();
            deleteAccountWindow.Topmost = true;
        }
    }
}
