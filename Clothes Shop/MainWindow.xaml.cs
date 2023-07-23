using DAL;
using DAL.EFCRUD;
using DAL.EFCRUD.LogedService;
using DAL.Models;
using MyProject;
using MyProject.ViewModels;
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
using System.Windows.Threading;

namespace Clothes_Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        double panelWidth;
        bool hidden;
        private readonly ILoggedService<LogedIn> service;
        public MainWindow( )
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Tick += Timer_Tick;
            panelWidth = sidePanel.Width;

            DataContext = new CategoryViewModels();

            service = new LoggedService(new EntityContextFactory());

        }


        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 5;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width -= 5;
                if (sidePanel.Width <= 35)
                {
                    timer.Stop();
                    hidden = true;
                }
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                WindowStyle = WindowStyle.SingleBorderWindow;
                this.WindowState = WindowState.Maximized;
                BorderThickness = new Thickness(this.WindowState == WindowState.Maximized ? 8 : 0);
                WindowStyle = WindowStyle.None;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                BorderThickness = new Thickness(0);
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();

        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {

            this.WindowState = WindowState.Minimized;
        }
        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            DataContext = new CategoryViewModels();
        }
        #region LogOut
        private void  ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = service.UpdateLoggedOut();
                if (result is not null)
                {
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            DataContext = new ProductViewModels();
        }

        private void SideBar(object sender, RoutedEventArgs e)
        {

        }

        private void Load_Username(object sender, RoutedEventArgs e)
        {
            string UserName = service.GetUserName();
            User.Text = UserName;
        }
    }
}
