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
using WpfApp5.PageMain;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp5.PageMain
{
    /// <summary>
    /// Логика взаимодействия для Test1.xaml
    /// </summary>
    public partial class Test1 : Page
    {

        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
     
        public Test1()
        {
            ClassConnect.Ent = new BDBEntities();
            InitializeComponent();
            CmbGr1.SelectedValuePath = "ID";
            CmbGr1.DisplayMemberPath = "Name";
            CmbGr1.ItemsSource = ClassConnect.Ent.Groups.ToList();
            CmbSt1.SelectedValuePath = "ID";
            CmbSt1.DisplayMemberPath = "Name";
            CmbSt1.ItemsSource = ClassConnect.Ent.Students.ToList();



        }

        

        int b = 0;
        int c = 0;
        public string Text { get; private set; }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (R2.IsChecked == true)
            {               
                b++;
                B1.Visibility = Visibility.Hidden;
            }
            else if (R1.IsChecked == false && R2.IsChecked == false && R3.IsChecked == false && R4.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
                B1.Visibility = Visibility.Hidden;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (R8.IsChecked == true)
            {
                b++;
                B2.Visibility = Visibility.Hidden;
            }
            else if (R5.IsChecked == false && R6.IsChecked == false && R7.IsChecked == false && R8.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
                B2.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (R9.IsChecked == true)
            {
                b++;
                B3.Visibility = Visibility.Hidden;
            }
            else if (R9.IsChecked == false && R10.IsChecked == false && R11.IsChecked == false && R12.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
                B3.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (R13.IsChecked == true)
            {
                b++;
                B4.Visibility = Visibility.Hidden;
            }
            else if (R13.IsChecked == false && R14.IsChecked == false && R15.IsChecked == false && R16.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
                B4.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (R17.IsChecked == true)
            {
                b++;
                B5.Visibility = Visibility.Hidden;
            }
            else if (R17.IsChecked == false && R18.IsChecked == false && R19.IsChecked == false && R20.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else
            {
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

            
            string mes = "";
            if (string.IsNullOrWhiteSpace(CmbGr1.Text))
                mes += "Выберете название группы\n";
            if (string.IsNullOrWhiteSpace(CmbSt1.Text))
                mes += "Введите ФИО\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Journal journal1 = new Journal()
            {
                //Evaluation = c,
                //Student = CmbSt1.SelectedItem as Student,
                //Group = CmbGr1.SelectedItem as Group,
                //Test = 1,

            };

            //ClassConnect.Ent.Journals.Add(journal);
            ClassConnect.Ent.SaveChanges();
            MessageBox.Show("Оценка добавлена");
            MW.FrameBody.NavigationService.Navigate(new Enterbody());
            MW.FrameMenu.NavigationService.Navigate(new FastMenu());
        }       
        private void CmbGr1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedStudent = Convert.ToInt32(CmbGr1.SelectedValue);
            CmbSt1.ItemsSource = ClassConnect.Ent.Students.Where(x => x.ID_group == SelectedStudent).ToList();
        }

        






    }






}

