﻿using AlKhair.WPF.Pages.List;
using AlKhair.WPF.ViewModels;
using ALKhair.BAL;
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

namespace AlKhair.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNavArea_Click(object sender, RoutedEventArgs e)
        {
            AreaListPage page = new AreaListPage();
            page.DataContext = new AreaViewModel();
            mainFrame.Content = page;
        }
    }
}
