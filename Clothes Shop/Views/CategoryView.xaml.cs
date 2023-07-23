using Clothes_Shop.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyProject.Views
{
    /// <summary>
    /// Interaction logic for CategoryView.xaml
    /// </summary>
    public partial class CategoryView : UserControl
    {
        IEnumerable<Category> bdata;
        private readonly IDataServiceSoftDelete<Category> servicecategory;
        private readonly ILoggedService<LogedIn> servicelogin;
        public CategoryView()
        {
            InitializeComponent();
            servicecategory = new GenericDataServiceSoftDelete<Category>(new EntityContextFactory());
            servicelogin = new LoggedService(new EntityContextFactory());
            bdata= new List<Category>();
        }

        private void Create(object sender, RoutedEventArgs e)
        {
            CategoryCreate create = new CategoryCreate();
            create.ShowDialog();
            create.Topmost = true;
        }

        #region Select Category To Update
        private void Update(object sender, RoutedEventArgs e)
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
                    CategoryUpdate update = new CategoryUpdate(item);
                    update.ShowDialog();
                    update.Topmost = true;
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Soft Delete Of category
        private void Delete(object sender, RoutedEventArgs e)
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
                    var confirm = MessageBox.Show("هل تريد مسح هذه الفئه ??", "تأكيد المسح", MessageBoxButton.YesNo);
                    if (confirm == MessageBoxResult.Yes)
                    {
                        var result = servicecategory.SoftDelete(item);
                        if (result is true)
                        {
                            this.Window_load(sender, e);
                            MessageBox.Show("تم المسح");
                            var username =servicelogin.GetUserName();
                            item.DeleteUserName = username;
                            servicecategory.Update(item);
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
        #endregion
        private void Deleted(object sender, RoutedEventArgs e)
        {
            CategoryDeleted categoryDeleted = new CategoryDeleted();

            categoryDeleted.ShowDialog();
            categoryDeleted.Topmost = true;
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            this.Window_load(sender, e);
        }

        #region Search For Category Name In Grid
        private void Search_Items(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return && search.Text.Length > 0)
                {

                    string categoryname = search.Text.ToString();
                    List<Category> result = new List<Category>();
                    foreach (Category category in bdata)
                    {
                        if (category.Name.StartsWith(categoryname))
                        {
                            result.Add(category);
                        }
                    }
                    if (result == null)
                    {
                        categoryData.ItemsSource = null;
                        categoryData.DataContext = null;
                        MessageBox.Show("لم يتم ايجاد نتيجه البحث");
                    }
                    else
                    {
                        categoryData.ItemsSource = result;
                        categoryData.DataContext = result;
                    }

                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
        private void Window_load(object sender, RoutedEventArgs e)
        {
            try
            {
                bdata = servicecategory.GetAll();
                categoryData.ItemsSource = bdata;
                categoryData.DataContext = bdata;
                search.Focus();
            }
            catch
            {
                throw;
            }
        }
        #region Select Category Item To Show Detailes
        private void Detailes(object sender, RoutedEventArgs e)
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
                    CategoryItemDetailes categoryItemDetailes = new CategoryItemDetailes(item);
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
