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

namespace WpfApp5.PageMain
{
    /// <summary>
    /// Логика взаимодействия для Test2Prepod.xaml
    /// </summary>
    public partial class Test2Prepod : Page
    {

        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public Test2Prepod()
        {
            InitializeComponent();
        }



        int b = 0;
        int c = 0;
        public string Text { get; private set; }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (R3.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b++;
                B1.Visibility = Visibility.Hidden;
            }
            else if (R1.IsChecked == false && R2.IsChecked == false && R3.IsChecked == false && R4.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
                MessageBox.Show("Неправильно");
                B1.Visibility = Visibility.Hidden;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (R6.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b++;
                B2.Visibility = Visibility.Hidden;
            }
            else if (R5.IsChecked == false && R6.IsChecked == false && R7.IsChecked == false && R8.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
                MessageBox.Show("Неправильно");
                B2.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (R9.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b++;
                B3.Visibility = Visibility.Hidden;
            }
            else if (R9.IsChecked == false && R10.IsChecked == false && R11.IsChecked == false && R12.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
                MessageBox.Show("Неправильно");
                B3.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (R16.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b++;
                B4.Visibility = Visibility.Hidden;
            }
            else if (R13.IsChecked == false && R14.IsChecked == false && R15.IsChecked == false && R16.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
                MessageBox.Show("Неправильно");
                B4.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (R19.IsChecked == true)
            {
                MessageBox.Show("Правильно");
                b++;
                B5.Visibility = Visibility.Hidden;
            }
            else if (R17.IsChecked == false && R18.IsChecked == false && R19.IsChecked == false && R20.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
                MessageBox.Show("Неправильно");
                B5.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (b == 5) c = 5;
            if (b == 4) c = 4;
            if (b == 3 || b == 2) c = 3;
            if (b == 1 || b == 0) c = 2;
            MessageBox.Show($"Ваша оценка - {c}, количество баллов {b}");
            MW.FrameBody.NavigationService.Navigate(new Enterbody());
            MW.FrameMenu.NavigationService.Navigate(new FastMenuPrepod());
        }
    }
}
