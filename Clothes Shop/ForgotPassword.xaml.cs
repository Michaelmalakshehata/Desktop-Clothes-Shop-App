using DAL;
using DAL.EFCRUD;
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
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Window
    {
        private string username = "";
        private string password = "";
        private string confirmpassword = "";
        private string answerquestion = "";
        private string? question = "";
        private readonly IServiceRegister<Registers> service;
        public ForgotPassword()
        {
            InitializeComponent();
            service = new ServiceRegister(new EntityContextFactory());

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
            if (txtUser.Text.Length>2)
            {
                username = txtUser.Text.ToString();
            }
        }

        private void txtPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtPass.Password.Length> 4)
            {
                password = txtPass.Password.ToString();
            }
        }

        private void txtConfirmPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txtConfirmPass.Password.Length>4)
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
            if (txtanswer.Text.Length>2)
            {
                answerquestion = txtanswer.Text.ToString();
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (username.Length > 0)
            {
                userErrorRequired.Visibility = Visibility.Hidden;
            }
            else 
            {
                userErrorRequired.Visibility = Visibility.Visible;
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
                if (username.Length > 2 && password.Length > 4 && confirmpassword == password && question?.Length > 0 && answerquestion.Length > 2)
                {
                    Registers oldobj = service.FindName(username);
                    if (oldobj is null || oldobj.Answer != answerquestion || oldobj.Quistion != question)
                    {
                      MessageBox.Show("سؤال ألامان أو أسم المستخدم غير صحيح");
                    }
                    else
                    {
                        oldobj.Password = password;
                        var result = service.Update(oldobj);
                        if (result is not null)
                        {
                            this.Close();
                            MessageBox.Show("تم تحديث كلمة السر");                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("رجاء أدخال كل الخانات صحيحه");
                }
            }
            catch
            {
                throw;
            }
        }  
    }
}
