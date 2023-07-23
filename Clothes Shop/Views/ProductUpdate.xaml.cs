using DAL;
using DAL.EFCRUD;
using DAL.EFCRUD.LogedService;
using DAL.Extension_Methods;
using DAL.Models;
using DAL.View_Models;
using Microsoft.Win32;
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
    /// Interaction logic for ProductUpdate.xaml
    /// </summary>
    public partial class ProductUpdate : Window
    {
        string productName = "";
        int productPrice = 0;
        string productDetailes = "";
        Byte[]? productimg;
        int categoryId = 0;
        ProductDetailes _products;
        private readonly IDataServiceSoftDelete<Products> serviceproduct;
        private readonly IDataServiceSoftDelete<Category> servicecategory;
        private readonly ILoggedService<LogedIn> servicelogin;
        public ProductUpdate(ProductDetailes products)
        {
            InitializeComponent();

            _products = products;
            serviceproduct = new GenericDataServiceSoftDelete<Products>(new EntityContextFactory());
            servicecategory = new GenericDataServiceSoftDelete<Category>(new EntityContextFactory());
            servicelogin = new LoggedService(new EntityContextFactory());
        }

        private void Product_Name(object sender, TextChangedEventArgs e)
        {
            if (productname.Text.Length > 2)
            {
                productName = productname.Text.ToString();
            }
        }

        private void Product_Price(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(productprice.Text, out productPrice))
            {
                MessageBox.Show("برجاء ادخال ارقام فقط");
            }
        }

        private void Product_Detailes(object sender, TextChangedEventArgs e)
        {
            if (productdetailes.Text.Length > 2)
            {
                productDetailes = productdetailes.Text.ToString();
            }
        }

        private void Category_Name(object sender, SelectionChangedEventArgs e)
        {
            int.TryParse(categoryname.SelectedValue.ToString(), out categoryId);
        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                List<CategoryNames> list = new List<CategoryNames>();
                IEnumerable<Category> categories = servicecategory.GetAll();
                foreach (Category category in categories)
                {
                    list.Add(new CategoryNames { Id = category.Id, Name = category.Name });
                }
                categoryname.ItemsSource = list;
                categoryname.DisplayMemberPath = "Name";
                categoryname.SelectedValuePath = "Id";
            }
            catch
            {
                throw;
            }
        }

        #region Upload Image To Window For Update
        private void Upload_Image(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = /*"Image jpeg(*.jpg)|*.jpg|Image png(*.png)|*.png"*/ "JPG|*.jpg|PNG|*.png|GIF|*gif";
                dialog.Multiselect = false;
                dialog.RestoreDirectory = true;
                dialog.Title = "برجاء اختيار صوره";
                if (dialog.ShowDialog() is true)
                {
                    productimage.Source = new BitmapImage(new Uri(dialog.FileName));
                    productimage.Stretch = Stretch.Fill;
                    productimage.StretchDirection = StretchDirection.Both;
                    productimg = ImageConverter.converttobyte(productimage.Source as BitmapImage);
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Update Product In dataBase
        private void Update(object sender, RoutedEventArgs e)
        {
            try
            {
                byte[] image;
                if (productimg is null)
                {
                    image = ImageConverter.converttobyte(_products.ProductImg);

                }
                else
                {
                    image = productimg;
                }
                string? username = "";
                username =servicelogin.GetUserName();
                if (image is not null && productName.Length > 2 && productPrice > 0 && productDetailes.Length > 2 && categoryId > 0)
                {
                    var oldproduct = serviceproduct.GetById(_products.Id);
                    oldproduct.ProductImg = image;
                    oldproduct.Name = productName;
                    oldproduct.Price = productPrice;
                    oldproduct.Detailes = productDetailes;
                    oldproduct.CategoryId = categoryId;
                    oldproduct.UpdateUserName = username;
                    oldproduct.UpdateDate= DateTime.Now;
                    var result = serviceproduct.Update(oldproduct);
                    if (result is null)
                    {
                        MessageBox.Show("لم يتم التعديل");
                    }
                    else
                    {
                        MessageBox.Show("تم التعديل");
                    }
                }
                else
                {
                    MessageBox.Show("برجاء ادخال كل الخانات و رفع الصوره");
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                productname.Text = _products.Name;
                productdetailes.Text = _products.Detailes;
                productprice.Text = _products.Price.ToString();
                productimage.Source = _products.ProductImg;
                productname.Focus();
            }
            catch
            {
                throw;
            }
        }

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
