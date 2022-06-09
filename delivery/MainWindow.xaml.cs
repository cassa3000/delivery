﻿using delivery.pages;
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

namespace delivery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ris_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page1());
        }

        private void Sushi_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Sushi());
        }

        private void Rol_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Rol());
        }

        private void Wok_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Wok());
        }

        private void Reg_Log_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
