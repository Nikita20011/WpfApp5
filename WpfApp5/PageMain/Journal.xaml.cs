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
using WpfApp5;
using System.Data.Entity;



namespace WpfApp5.PageMain
{
    /// <summary>
    /// Логика взаимодействия для Journal.xaml
    /// </summary>
    public partial class Journal : Page
    {
        internal int Evalution;

        public Journal()
        {
            InitializeComponent();
            
            ClassConnect.Ent = new BDBEntities();
            CmdNamegroup2.SelectedValuePath = "ID";
            CmdNamegroup2.DisplayMemberPath = "Name";
            CmdNamegroup2.ItemsSource = ClassConnect.Ent.Groups.ToList();
            DataGridlist1.IsReadOnly = true;
        }
        
              

        private void BtnSearh_Click(object sender, RoutedEventArgs e)
        {
            ClassConnect.Ent = new BDBEntities();
            int SelectedStudent = Convert.ToInt32(CmdNamegroup2.SelectedValue);
            DataGridlist1.ItemsSource = ClassConnect.Ent.Journals.Where(x => x.ID_group == SelectedStudent).ToList();
            DataGridlist1.SelectedIndex = 0;

        }


        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");
            string connectionString = @"Data Source=DESKTOP-O406EIH\SQL;Initial Catalog=BDB;Integrated Security=Yes";// подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);// возращаем таблицу с результатом

            return dataTable;
        }

        private void BtnSearch_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
