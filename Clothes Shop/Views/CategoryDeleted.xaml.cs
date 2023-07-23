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
    /// Interaction logic for CategoryDeleted.xaml
    /// </summary>
    public partial class CategoryDeleted : Window
    {
        IEnumerable<Category>? bdata;
        private readonly IDataServiceSoftDelete<Category> servicecategory;
        private readonly ILoggedService<LogedIn> servicelogin;
        public CategoryDeleted()
        {
            InitializeComponent();
            servicecategory = new GenericDataServiceSoftDelete<Category>(new EntityContextFactory());
            servicelogin = new LoggedService(new EntityContextFactory());
        }

        #region Search Category Name in Grid
        private void Search_Items(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return && search.Text.Length > 0)
                {
                    string categoryname = search.Text.ToString();
                    List<Category> resultlist = new List<Category>();

                    foreach (Category category in bdata)
                    {
                        if (category.Name.StartsWith(categoryname))
                        {
                            resultlist.Add(category);
                        }
                    }
                    if (resultlist == null)
                    {
                        categoryData.ItemsSource = null;
                        categoryData.DataContext = null;
                        MessageBox.Show("لم يتم ايجاد نتيجه البحث");
                    }
                    else
                    {
                        categoryData.ItemsSource = resultlist;
                        categoryData.DataContext = resultlist;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Restore Item From Soft Deleted
        private void Restore_Item(object sender, RoutedEventArgs e)
        {
            try
            {
                Category item = (Category)categoryData.SelectedItem;
                if (item is null)
                {
                    MessageBox.Show("برجاء اختيار الفئه");
                }
                else
                {
                    var result = servicecategory.RestoreItem(item);
                    this.Load(sender, e);
                    if (result is true)
                    {
                        MessageBox.Show("تم استرجاع الفئه");
                        var username =servicelogin.GetUserName();
                        item.RestoreUserName = username;
                        servicecategory.Update(item);
                    }
                    else
                    {
                        MessageBox.Show("لم يتم استرجاع الفئه");
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
                bdata = servicecategory.GetallSoftDeleted();
                categoryData.ItemsSource = bdata;
                categoryData.DataContext = bdata;
                search.Focus();
            }
            catch
            {
                throw;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Reload_Window(object sender, RoutedEventArgs e)
        {
            this.Load(sender, e);
        }
        #region Show Detailes Of Category
        private void Detailes(object sender, RoutedEventArgs e)
        {
            try
            {
                Category item = (Category)categoryData.SelectedItem;
                if (item == null)
                {
                    MessageBox.Show("برجاء اختيار الفئه");
                }
                else
                {
                    CategoryDeletedItemDetailes categoryItemDetailes = new CategoryDeletedItemDetailes(item);
                    categoryItemDetailes.ShowDialog();
                    categoryItemDetailes.Topmost = true;
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
