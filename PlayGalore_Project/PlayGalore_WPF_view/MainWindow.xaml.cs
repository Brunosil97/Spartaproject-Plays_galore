﻿using PlayGalore_controller;
using PlayGalore_WPF_view.Views;
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

namespace PlayGalore_WPF_view
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public PlayController _playFunctions = new PlayController();

        public TheatreController _theatreFunctions = new TheatreController();

        public AuthorController _authorFunctions = new AuthorController();
   
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new HomeView();
        }

        private void HomeView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new HomeView();
        }

        private void AuthorView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new AuthorView();
        }

        private void TheatreView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new TheatreView();
        }
    }
}
