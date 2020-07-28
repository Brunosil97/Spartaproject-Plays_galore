using PlayGalore_WPF_view.AddPages;
using PlayGalore_WPF_view.ShowPages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlayGalore_WPF_view.Views
{
    /// <summary>
    /// Interaction logic for TheatreView.xaml
    /// </summary>
    public partial class TheatreView : UserControl
    {
        public MainWindow _mainWindow = ((MainWindow)Application.Current.MainWindow);
        public TheatreView()
        {
            InitializeComponent();
            PopulateTheatreList();
        }

        public void PopulateTheatreList()
        {
            var authors = _mainWindow.RetrieveAllTheatres();
            TheatreContainer.ItemsSource = authors;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddTheatre addTheatre = new AddTheatre();
            addTheatre.Show();
        }

        private void TheatreContainer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(TheatreContainer.SelectedItem != null)
            {
                _mainWindow.SetSelectedTheatre(TheatreContainer.SelectedItem);
                PopulateTheatreList();
            }    
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount >= 2)
            {
                ShowTheatre showTheatre = new ShowTheatre();
                showTheatre.Show();
            }
        }
    }
}
