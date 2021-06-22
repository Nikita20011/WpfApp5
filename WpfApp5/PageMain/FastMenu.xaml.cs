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
using WpfApp5.Class;

namespace WpfApp5.PageMain
{
    /// <summary>
    /// Логика взаимодействия для FastMenu.xaml
    /// </summary>
    public partial class FastMenu : Page
    {

        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public FastMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Test1());
            MW.FrameMenu.NavigationService.Navigate(new Menu());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Test2());
            MW.FrameMenu.NavigationService.Navigate(new Menu());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new RussiaN());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Body());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Orfo());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Slovo());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Leks());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Morf());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Sink());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Treb());
        }
    }
}
