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
using System.Data;
using System.Data.SqlClient;


namespace WpfApp5.PageMain
{
    /// <summary>
    /// Логика взаимодействия для Body.xaml
    /// </summary>
    public partial class Body : Page
    {

        

        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public Body()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //Вход по БД
            //MW.FrameBody.NavigationService.Navigate(new Enterbody());
            //MW.FrameMenu.NavigationService.Navigate(new FastMenuPrepod());    


            if (logintb.Text.Length > 0) // проверяем введён ли логин     
            {
                if (password.Password.Length > 0) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными         
                    DataTable dt_user = Select("SELECT * FROM [dbo].[Student] WHERE [Name] = '" + logintb.Text + "' AND [password] = '" + password.Password + "'");
                    if (dt_user.Rows.Count > 0) // если такая запись существует       
                    {
                        //MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался 

                        MW.FrameBody.NavigationService.Navigate(new Enterbody());
                        MW.FrameMenu.NavigationService.Navigate(new FastMenu());

                        
                    }
                    DataTable dt_use = Select("SELECT * FROM [dbo].[Teacher] WHERE [Name] = '" + logintb.Text + "' AND [password] = '" + password.Password + "'");
                    if (dt_use.Rows.Count > 0)
                    {
                        MW.FrameBody.NavigationService.Navigate(new Enterbody());
                        MW.FrameMenu.NavigationService.Navigate(new FastMenuPrepod());
                    }
                    else MessageBox.Show("Неверный логин или пароль"); // выводим ошибку  
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку    
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку           
        }

        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении

            string connectionString = @"Data Source=DESKTOP-O406EIH\SQL;Initial Catalog=BDB;Integrated Security=Yes";// подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);// возращаем таблицу с результатом
            
            return dataTable;
        }               
    }
}
