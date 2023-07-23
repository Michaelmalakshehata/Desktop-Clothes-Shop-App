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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private string username = "";
        private string password = "";
        private string confirmpassword = "";
        private string answerquestion = "";
        private string? question = "";
        private readonly IServiceRegister<Registers> service;
        private readonly ILoggedService<LogedIn> serviceloged;
        public Register()
        {
            InitializeComponent();
            service = new ServiceRegister(new EntityContextFactory());
            serviceloged = new LoggedService(new EntityContextFactory());

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> listquestion = new List<string>()
            {
                "ما أسم الشهره",
                "ما أسم الفاكهه المفضله لديك",
                "ما أسم مدرستك الثانويه",
                "ما أسم اللون المفضل لديك"
            };


            cmbquestion.ItemsSource = listquestion;
            cmbquestion.SelectedIndex = 0;
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUser.Text is not null)
            {
                username = txtUser.Text.ToString();
            }
        }

        private void txtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtPass.Password is not null)
            {
                password = txtPass.Password.ToString();
            }
        }

        private void txtConfirmPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtConfirmPass.Password is not null)
            {
                confirmpassword = txtConfirmPass.Password.ToString();
            }
        }

        private void cmbquestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            question = cmbquestion.SelectedItem.ToString();
        }

        private void txtanswer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtanswer.Text is not null)
            {
                answerquestion = txtanswer.Text.ToString();
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Registers registers = service.FindName(username);
            if (username.Length > 2)
            {
                userErrorRequired.Visibility = Visibility.Hidden;
            }
            else
            {
                userErrorRequired.Visibility = Visibility.Visible;
            }
            if (registers is null)
            {
                userErrorExist.Visibility = Visibility.Hidden;
            }
            else
            {
                userErrorExist.Visibility = Visibility.Visible;
            }

            if (password.Length > 4)
            {
                passErrorRequired.Visibility = Visibility.Hidden;
            }
            else
            {
                passErrorRequired.Visibility = Visibility.Visible;
            }
            if (confirmpassword == password)
            {
                confpassErrorRequired.Visibility = Visibility.Hidden;
            }
            else
            {
                confpassErrorRequired.Visibility = Visibility.Visible;
            }
            if (answerquestion.Length > 2)
            {
                answerErrorRequired.Visibility = Visibility.Hidden;
            }
            else
            {
                answerErrorRequired.Visibility = Visibility.Visible;

            }
            try
            {
                if (registers is null && username.Length > 2 && password.Length > 4 && confirmpassword == password && question?.Length > 0 && answerquestion.Length > 2)
                {
                    Registers obj = new Registers { Name = username, Password = password, Quistion = question, Answer = answerquestion };
                    var result = service.Create(obj);
                    if (result is not null)
                    {
                        LogedIn objloged = new LogedIn { Name = result.Name, logged = true };
                        var loged = serviceloged.Create(objloged);
                        if (loged is not null)
                        {
                            MainWindow homewindow = new MainWindow();
                            homewindow.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch
            {
                throw;
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
