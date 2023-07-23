using DAL;
using DAL.EFCRUD;
using DAL.EFCRUD.LogedService;
using DAL.Extension_Methods;
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
    /// Interaction logic for ProductDeletedItem.xaml
    /// </summary>
    public partial class ProductDeletedItem : Window
    {
        List<ProductDetailes> productlist;
        private readonly IDataServiceSoftDelete<Products> serviceproduct;
        private readonly ILoggedService<LogedIn> servicelogin;
        public ProductDeletedItem()
        {
            InitializeComponent();
            serviceproduct = new GenericDataServiceSoftDelete<Products>(new EntityContextFactory());
            servicelogin = new LoggedService(new EntityContextFactory());
            productlist = new List<ProductDetailes>();

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        #region Restore Deleted Product From Soft Delete
        private void Restore_Item(object sender, RoutedEventArgs e)
        {
            try
            {
                ProductDetailes item = (ProductDetailes)productGrid.SelectedItem;
                if (item is null)
                {
                    MessageBox.Show("برجاء اختيار المنتج");
                }
                else
                {
                    Products olditem = serviceproduct.FindDeletedItem(item.Name);
                    bool result = false;
                    if (olditem is not null)
                    {
                        result = serviceproduct.RestoreItem(olditem);
                    }
                    if (result is true)
                    {
                        MessageBox.Show("تم استرجاع المنتج");
                       var username =servicelogin.GetUserName();
                        olditem.RestoreUserName = username;
                        serviceproduct.Update(olditem);
                        this.Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("لم يتم استرجاع المنتج");
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
        private void Load(object sender, RoutedEventArgs e)
        {
            try
            {
                IEnumerable<Products> bdata = serviceproduct.GetallSoftDeleted();
                productlist = new List<ProductDetailes>();
                foreach (Products product in bdata)
                {
                    BitmapImage img = ImageConverter.ConvertToImage(product.ProductImg);
                    productlist.Add(new ProductDetailes
                    { 
                        Id = product.Id, 
                        Name = product.Name,
                        Price = product.Price,
                        Detailes = product.Detailes, 
                        ProductImg = img,
                        CategoryId = product.CategoryId,
                        CreateDate = product.CreateDate,
                        CreateUserName = product.CreateUserName,
                        UpdateDate = product.UpdateDate,
                        UpdateUserName = product.UpdateUserName,
                        DeleteDate = product.DeleteDate,
                        DeleteUserName = product.DeleteUserName,
                        RestoreDate = product.RestoreDate,
                        RestoreUserName = product.RestoreUserName
                    });
                }
                productGrid.ItemsSource = productlist;
                productGrid.DataContext = productlist;
                search.Focus();
            }
            catch
            {
                throw;
            }
        }
        #region Search For Product In Deleted Product
        private void Search_Items(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return && search.Text.Length > 0)
                {
                    string productname = search.Text.ToString();
                    List<ProductDetailes> result = new List<ProductDetailes>();
                    foreach (ProductDetailes product in productlist)
                    {
                        if (product.Name.StartsWith(productname))
                        {
                            result.Add(product);
                        }
                    }
                    if (result is null)
                    {
                        productGrid.ItemsSource = null;
                        productGrid.DataContext = null;
                        MessageBox.Show("لم يتم ايجاد نتيجه البحث");
                    }
                    else
                    {
                        productGrid.ItemsSource = result;
                        productGrid.DataContext = result;
                    }

                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
        private void Reload_Window(object sender, RoutedEventArgs e)
        {
            this.Load(sender, e);
        }

        private void Detailes(object sender, RoutedEventArgs e)
        {
            try
            {
                ProductDetailes item = (ProductDetailes)productGrid.SelectedItem;
                if (item is null)
                {
                    MessageBox.Show("برجاء اختيار المنتج");
                }
                else
                {
                    ProductDeletedItemDetailes productItemDetailes = new ProductDeletedItemDetailes(item);
                    productItemDetailes.ShowDialog();
                    productItemDetailes.Topmost = true;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
