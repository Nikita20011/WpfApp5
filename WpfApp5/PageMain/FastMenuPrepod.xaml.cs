﻿using System;
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

        MainWindow MW = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();

        public FastMenuPrepod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Journal());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Test1Prepod());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MW.FrameBody.NavigationService.Navigate(new Test2Prepod());
        }
    }
}