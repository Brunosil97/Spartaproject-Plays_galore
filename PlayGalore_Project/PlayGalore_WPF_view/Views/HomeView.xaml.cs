using PlayGalore_model.Models;
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
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {

        public MainWindow _mainWindow = ((MainWindow)Application.Current.MainWindow);
        private string searchInput = null;
        public HomeView()
        {
            InitializeComponent();
            DisplayRetrievedPlaysOnScroll();
        }
        public void DisplayRetrievedPlaysOnScroll()
        {
           var plays = _mainWindow.RetrieveAllPlaysForHome();
            PlayContainer.ItemsSource = plays;   
        }

        private void PlayContainer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(PlayContainer.SelectedItem != null)
            {
                _mainWindow.SetSelectedPlay(PlayContainer.SelectedItem);
                DisplayRetrievedPlaysOnScroll();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPlay addPlay = new AddPlay();
            addPlay.Show();
            DisplayRetrievedPlaysOnScroll();

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount >= 2)
            {
                ShowPlay showPlay = new ShowPlay();
                showPlay.Show();
                DisplayRetrievedPlaysOnScroll();
            }
        }

        private void searchBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (!string.IsNullOrEmpty(searchBox.Text))
                {
                    PlayContainer.ItemsSource = _mainWindow.ReturnSearchItemsForPlays(searchBox.Text);
                }
                else
                {
                    var plays = _mainWindow.RetrieveAllPlaysForHome();
                    PlayContainer.ItemsSource = plays;
                }
            }
        }
    }
}
