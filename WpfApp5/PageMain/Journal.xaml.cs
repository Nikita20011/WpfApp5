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
        public Journal()
        {
            InitializeComponent();

            CmdNamegroup2.SelectedValuePath = "ID";
            CmdNamegroup2.DisplayMemberPath = "Name";
            CmdNamegroup2.ItemsSource = ClassConnect.Ent.Groups.ToList();
            DataGridlist1.IsReadOnly = true;
        }
       

        private void BtnSearh_Click(object sender, RoutedEventArgs e)
        {
            int SelectedStudents = Convert.ToInt32(CmdNamegroup2.SelectedValue);
            DataGridlist1.ItemsSource = ClassConnect.Ent.Journals.Where(x => x.ID_group == SelectedStudents).ToList();
            DataGridlist1.SelectedIndex = 0;
        }

        
    }
}
