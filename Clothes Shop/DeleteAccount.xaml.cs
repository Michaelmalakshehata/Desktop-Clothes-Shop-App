using DAL;
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

namespace Clothes_Shop
{
    /// <summary>
    /// Interaction logic for DeleteAccount.xaml
    /// </summary>
    public partial class DeleteAccount : Window
    {
        private string username = "";
        private string password = "";
        private string answerquestion = "";
        private string? question = "";
        private readonly IServiceRegister<Registers> service;
        private readonly ILoggedService<LogedIn> serviceloged;
        public DeleteAccount()
        {
            InitializeComponent();
            serviceloged = new LoggedService(new EntityContextFactory());
            service = new ServiceRegister(new EntityContextFactory());
        }

        private void BtnDelete(object sender, RoutedEventArgs e)
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
            if (answerquestion.Length > 0)
            {
                answerErrorRequired.Visibility = Visibility.Hidden;
            }
            else
            {
                answerErrorRequired.Visibility = Visibility.Visible;
            }
            try
            {
                var user = service.FindName(username);
                if(user is not null)
                {
                    if(answerquestion==user.Answer && password==user.Password &&question==user.Quistion)
                    {
                        var result = service.HardDelete(user);
                        if(result is true)
                        {
                            serviceloged.DeleteUserName(username);
                            MessageBox.Show("تم مسح الحساب بنجاح");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("لم يتم المسح");
                        }
                    }
                    else
                    {
                        MessageBox.Show("كلمة السر او سؤال الامان خاطئ");
                    }
                }
                else
                {
                    MessageBox.Show("أسم المستخدم غير صحيح");
                }
            }
            catch
            {
                throw;
            }
        }

        private void txtanswer_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtanswer.Text.Length > 2)
            {
                answerquestion = txtanswer.Text.ToString();
            }
        }

        private void cmbquestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            question = cmbquestion.SelectedItem.ToString();
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

        private void txtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtPass.Password.Length > 4)
            {
                password = txtPass.Password.ToString();
            }
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUser.Text.Length > 2)
            {
                username = txtUser.Text.ToString();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
