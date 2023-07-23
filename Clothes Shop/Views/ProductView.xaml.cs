using Clothes_Shop.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyProject.Views
{
    /// <summary>
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        List<ProductDetailes> productlist;

        private readonly IDataServiceSoftDelete<Products> serviceproduct;
        private readonly ILoggedService<LogedIn> servicelogin;
        public ProductView()
        {
            InitializeComponent();
            serviceproduct = new GenericDataServiceSoftDelete<Products>(new EntityContextFactory());
            servicelogin = new LoggedService(new EntityContextFactory());
            productlist = new List<ProductDetailes>();
        }
        private void Create(object sender, RoutedEventArgs e)
        {
            ProductCreate create = new ProductCreate();
            create.ShowDialog();
            create.Topmost = true;
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            try
            {
                ProductDetailes item = (ProductDetailes)productgrid.SelectedItem;
                if (item is null)
                {
                    MessageBox.Show("برجاء اختيار المنتج");
                }
                else
                {
                    ProductUpdate update = new ProductUpdate(item);
                    update.ShowDialog();
                    update.Topmost = true;
                }
            }
            catch
            {
                throw;
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                ProductDetailes item = (ProductDetailes)productgrid.SelectedItem;                
                if (item is null)
                {
                    MessageBox.Show("برجاء اختيار المنتج");
                }
                else
                {
                    var confirm = MessageBox.Show("هل تريد مسح هذا المنتج ??", "تأكيد المسح", MessageBoxButton.YesNo);
                    if (confirm == MessageBoxResult.Yes)
                    {
                        var olditem = serviceproduct.FindName(item.Name);
                        bool result = false;
                        if (olditem is not null)
                        {
                            result = serviceproduct.SoftDelete(olditem);
                        }
                        if (result is true)
                        {
                            MessageBox.Show("تم المسح");
                            var username = servicelogin.GetUserName();
                            olditem.DeleteUserName = username;
                            serviceproduct.Update(olditem);
                            this.Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("لم تم المسح");
                        }
                    }
                    else
                    {
                        MessageBox.Show("تم ألغاء المسح");
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void Deleted(object sender, RoutedEventArgs e)
        {
            ProductDeletedItem productDeletedItem = new ProductDeletedItem();
            productDeletedItem.ShowDialog();
            productDeletedItem.Topmost = true;

        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            this.Load(sender, e);
        }
        #region Search Product In Database
        private void Search_Item(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return && search.Text.Length > 0)
                {
                    string productname = search.Text.ToString();
                    List<ProductDetailes> result = new List<ProductDetailes>();
                    foreach (var product in productlist)
                    {
                        if (product.Name.StartsWith(productname))
                        {
                            result.Add(product);
                        }
                    }
                    if (result is null)
                    {
                        productgrid.ItemsSource = null;
                        productgrid.DataContext = null;
                        MessageBox.Show("لم يتم ايجاد نتيجه البحث");
                    }
                    else
                    {
                        productgrid.ItemsSource = result;
                        productgrid.DataContext = result;
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
                IEnumerable<Products> bdata = serviceproduct.GetAll();
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
                productgrid.ItemsSource = productlist;
                productgrid.DataContext = productlist;
                search.Focus();
            }
            catch
            {
                throw;
            }
        }

        private void Detailes(object sender, RoutedEventArgs e)
        {
            try
            {
                ProductDetailes item = (ProductDetailes)productgrid.SelectedItem;
                if (item is null)
                {
                    MessageBox.Show("برجاء اختيار المنتج");
                }
                else
                {
                    ProductItemDetailes productItemDetailes = new ProductItemDetailes(item);
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
