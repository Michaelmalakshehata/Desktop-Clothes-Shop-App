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
    /// Interaction logic for CategoryDeletedItemDetailes.xaml
    /// </summary>
    public partial class CategoryDeletedItemDetailes : Window
    {
        Category category;
        public CategoryDeletedItemDetailes(Category category)
        {
            InitializeComponent();
            this.category = category;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #region Load Detailes of Deleted Category
        private void Window_Load(object sender, RoutedEventArgs e)
        {
            try
            {
                categoryCode.Text = category.Id.ToString();
                categoryName.Text = category.Name;
                CreateDate.Text = category.CreateDate.ToString();
                CreateUserName.Text = category.CreateUserName;
                UpdateDate.Text = category.UpdateDate.ToString();
                UpdateUserName.Text = category.UpdateUserName;
                DeleteDate.Text = category.DeleteDate.ToString();
                DeleteUserName.Text = category.DeleteUserName;
                RestoreDate.Text = category.RestoreDate.ToString();
                RestoreUserName.Text = category.RestoreUserName;
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
