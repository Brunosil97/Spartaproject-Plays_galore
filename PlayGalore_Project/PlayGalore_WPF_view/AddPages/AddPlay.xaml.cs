using Microsoft.EntityFrameworkCore.Internal;
using PlayGalore_WPF_view.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PlayGalore_WPF_view.AddPages
{
    /// <summary>
    /// Interaction logic for AddPlay.xaml
    /// </summary>
    public partial class AddPlay : Window
    {
        public MainWindow _mainWindow = ((MainWindow)Application.Current.MainWindow);
        
        public HomeView _homeView { get; set; }
        public AddPlay()
        {
            var homeWindow = this.DataContext;
            InitializeComponent();
            PopulateAuthorCombo();
            PopulateTheatreCombo();
        }

        public void PopulateAuthorCombo()
        {
            AuthorCombo.ItemsSource = _mainWindow.RetrieveAllAuthors();
        }

        public void PopulateTheatreCombo()
        {
            TheatreCombo.ItemsSource = _mainWindow.RetrieveAllTheatres();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if(AuthorCombo.SelectedItem != null)
            {
                _mainWindow.CreateNewPlay(TitleBox.Text, BioBox.Text, GenreBox.Text, AuthorCombo.SelectedItem, TheatreCombo.SelectedItem);
                _mainWindow.RefeshHomeView();
                this.Close();
                

            }
        }
    }
}
