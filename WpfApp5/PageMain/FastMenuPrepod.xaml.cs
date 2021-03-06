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
    /// Логика взаимодействия для FastMenuPrepod.xaml
    /// </summary>
    public partial class FastMenuPrepod : Page
    {

        //MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public FastMenuPrepod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Journal());

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Test1Prepod());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Test2Prepod());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new RussiaN());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Orfo());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Leks());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Slovo());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Morf());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Sink());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Treb());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new Body());
            ClassFrame.FrameMenu.Navigate(new Clear());
        }
    }
}
