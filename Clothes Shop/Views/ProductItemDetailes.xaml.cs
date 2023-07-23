using DAL;
using DAL.EFCRUD;
using DAL.Models;
using DAL.View_Models;
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
    /// Interaction logic for ProductItemDetailes.xaml
    /// </summary>
    public partial class ProductItemDetailes : Window
    {
        private readonly IDataServiceSoftDelete<Category> servicecategory;

        ProductDetailes productDetailes;
        public ProductItemDetailes(ProductDetailes productDetailes)
        {
            InitializeComponent();
            this.productDetailes = productDetailes;
            servicecategory = new GenericDataServiceSoftDelete<Category>(new EntityContextFactory());

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #region Load Detailes Of Product
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Category category = servicecategory.GetById(productDetailes.CategoryId);
                ProductCode.Text = productDetailes.Id.ToString();
                ProductName.Text = productDetailes.Name;
                ProductDetailes.Text = productDetailes.Detailes;
                ProductPrice.Text = productDetailes.Price.ToString();
                productimage.Source = productDetailes.ProductImg;
                CategoryCode.Text = category.Name.ToString();
                CreateDate.Text = productDetailes.CreateDate.ToString();
                CreateUserName.Text = productDetailes.CreateUserName;
                UpdateDate.Text = productDetailes.UpdateDate.ToString();
                UpdateUserName.Text = productDetailes.UpdateUserName;
                DeleteDate.Text = productDetailes.DeleteDate.ToString();
                DeleteUserName.Text = productDetailes.DeleteUserName;
                RestoreDate.Text = productDetailes.RestoreDate.ToString();
                RestoreUserName.Text = productDetailes.RestoreUserName;
            }
            catch
            {
                throw;
            }
        }
        #endregion
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
