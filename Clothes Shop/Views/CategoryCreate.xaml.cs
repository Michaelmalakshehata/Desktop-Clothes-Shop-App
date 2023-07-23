using DAL;
using DAL.EFCRUD;
using DAL.EFCRUD.LogedService;
using DAL.Extension_Methods;
using DAL.Models;
using MyProject.Views;
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

namespace Clothes_Shop.Views
{
    /// <summary>
    /// Interaction logic for CategoryCreate.xaml
    /// </summary>
    public partial class CategoryCreate : Window
    {
        string categoryname = "";
        private readonly ILoggedService<LogedIn> servicelogin;
        private readonly IDataServiceSoftDelete<Category> servicecategory;
        CategoryView view=new CategoryView();
        public CategoryCreate()
        {
            InitializeComponent();
            servicelogin = new LoggedService(new EntityContextFactory());
            servicecategory = new GenericDataServiceSoftDelete<Category>(new EntityContextFactory());
            txtCategory.Focus();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void category(object sender, TextChangedEventArgs e)
        {
            if (txtCategory.Text.Length > 0)
            {
                categoryname = txtCategory.Text.ToString();
            }
        }
        #region create Category in Database
        private void Create(object sender, RoutedEventArgs e)
        {
            try
            {
                
                string username = servicelogin.GetUserName();
                var exist = servicecategory.FindName(categoryname);
                if (exist is null && username.Length > 0 && categoryname.Length > 2)
                {
                    Category category = new Category { Name = categoryname, CreateUserName = username };
                    servicecategory.Create(category);
                    MessageBox.Show("تم الاضافه بنجاح");
                }
                else if (categoryname.Length < 2)
                {
                    MessageBox.Show("الرجاء ادخال اسم الفئه اكثر حرفين");
                }
                else
                {
                    MessageBox.Show("اسم الفئه موجود");
                }
            }
            catch
            {
                throw;
            }

        }
        #endregion
    }
}
