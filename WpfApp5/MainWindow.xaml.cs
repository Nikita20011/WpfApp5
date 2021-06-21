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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.FrameLogo = FrameLogo;
            FrameLogo.Navigate(new PageMain.Logo());

            ClassFrame.FrameMenu = FrameMenu;
            FrameMenu.Navigate(new PageMain.Menu());

            ClassFrame.FrameBody = FrameBody;
            FrameBody.Navigate(new PageMain.Body());
        }

        

    }
}
