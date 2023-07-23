using DAL;
using DAL.EFCRUD;
using DAL.EFCRUD.LogedService;
using DAL.Extension_Methods;
using DAL.Models;
using DAL.View_Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ProductCreate.xaml
    /// </summary>
    public partial class ProductCreate : Window
    {
        string productName = "";
        int productPrice=0 ;
        string productDetailes = "";
        Byte[]? productimg;
        int categoryId = 0;
        private readonly IDataServiceSoftDelete<Products> serviceproduct;
        private readonly IDataServiceSoftDelete<Category> servicecategory;
        private readonly ILoggedService<LogedIn> servicelogin;
        public ProductCreate()
        {
            
            InitializeComponent();
            serviceproduct = new GenericDataServiceSoftDelete<Products>(new EntityContextFactory());
            servicecategory = new GenericDataServiceSoftDelete<Category>(new EntityContextFactory());
            servicelogin = new LoggedService(new EntityContextFactory());
            productname.Focus();
           
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }

     #region Create Product In Database
        private void Create(object sender, RoutedEventArgs e)
        {
            try
            {
                Products exist = serviceproduct.FindName(productName);
                var  username =servicelogin.GetUserName();
                if (exist is null && productimg is not null && productName.Length > 2 && productPrice > 0 && productDetailes.Length > 2 && username.Length > 0 && categoryId > 0)
                {
                    Products product = new Products { ProductImg = productimg, Name = productName, Price = productPrice, Detailes = productDetailes, CreateUserName = username, CategoryId = categoryId };
                    var result = serviceproduct.Create(product);
                    if (result is null)
                    {

                        MessageBox.Show("لم يتم الاضافه");
                    }
                    else
                    {
                        MessageBox.Show("تم الاضافه");
                    }
                }
                else if (exist is not null)
                {
                    MessageBox.Show("اسم المنتج موجود");

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
        private void Product_Name(object sender, TextChangedEventArgs e)
        {
            if(productname.Text.Length>2)
            {
                productName=productname.Text.ToString();
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
        #region Upload Image To Window WPF
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

        private void Category_Name(object sender, SelectionChangedEventArgs e)
        {
            int.TryParse(categoryname.SelectedValue.ToString(), out categoryId);
        }
        #region Load ComboBox  Category ID And Names Source 
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
                categoryname.SelectedIndex = 0;
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }

}
