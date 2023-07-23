using DAL;
using DAL.EFCRUD;
using DAL.EFCRUD.LogedService;
using DAL.Extension_Methods;
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

namespace Clothes_Shop.Views
{
    /// <summary>
    /// Interaction logic for CategoryUpdate.xaml
    /// </summary>
    public partial class CategoryUpdate : Window
    {
        Category category;
        string categoryname = "";
        private readonly IDataServiceSoftDelete<Category> servicecategory;
        private readonly ILoggedService<LogedIn> servicelogin;
        public CategoryUpdate(Category category)
        {
            InitializeComponent();
            this.category = category;
            servicecategory = new GenericDataServiceSoftDelete<Category>(new EntityContextFactory());
            servicelogin = new LoggedService(new EntityContextFactory());
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        #region Update Category
        private void Update(object sender, RoutedEventArgs e)
        {
            try
            {
                if (categoryname.Length > 2)
                {
                    var username =servicelogin.GetUserName();
                    category.Name = categoryname;
                    category.UpdateUserName = username;
                    category.UpdateDate = DateTime.Now;
                    var update = servicecategory.Update(category);
                    if (update is null)
                    {
                        MessageBox.Show("لم يتم التعديل");
                    }
                    else
                    {
                        MessageBox.Show("تم التعديل بنجاح");

                    }
                }
                else
                {
                    MessageBox.Show("الرجاء ادخال اسم الفئه اكثر حرفين");
                }
            }
            catch
            {
                throw;
            }

        }
        #endregion
        private void Category_Name(object sender, TextChangedEventArgs e)
        {
            if (txtCategory.Text.Length > 2)
            {
                categoryname = txtCategory.Text.ToString();
            }
        }

        private void Window_Load(object sender, RoutedEventArgs e)
        {
            txtCategory.Focus();
            txtCategory.Text = category.Name;
        }
    }
}
