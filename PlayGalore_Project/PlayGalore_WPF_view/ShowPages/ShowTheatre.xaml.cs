using PlayGalore_model.Models;
using PlayGalore_WPF_view.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PlayGalore_WPF_view.ShowPages
{
    /// <summary>
    /// Interaction logic for ShowTheatre.xaml
    /// </summary>
    public partial class ShowTheatre : Window
    {
        public MainWindow _mainWindow = ((MainWindow)Application.Current.MainWindow);

        public TheatreView _theatreView { get; set; }
        public ShowTheatre()
        {
            InitializeComponent();
            PopulateShowPage();
            PopulatePlayContainer();
        }

        public void PopulatePlayContainer()
        {
            var theatre = _mainWindow._theatreFunctions.SelectedTheatre;
            var plays = _mainWindow.GetPlaysForSelectedTheatre(theatre.TheatreId);
            TheatrePlaysContainer.ItemsSource = plays;
            
        }

        public void PopulateShowPage()
        {
            var theatre = _mainWindow._theatreFunctions.SelectedTheatre;
            if(theatre != null)
            {
                NameBox.Text = theatre.Name;
                LocationBox.Text = theatre.Location;
                CapacityBox.Text = theatre.Capacity.ToString();
            }
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            var theatre = _mainWindow._theatreFunctions.SelectedTheatre;
            if (theatre != null)
            {
                _mainWindow.DeleteTheatre(theatre.TheatreId);
                _mainWindow.RefreshTheatreView();
                this.Close();
            }
        }

        private void Update_Button(object sender, RoutedEventArgs e)
        {
            var theatre = _mainWindow._theatreFunctions.SelectedTheatre;
            if (theatre != null)
            {
                _mainWindow.UpdateTheatre(theatre.TheatreId, NameBox.Text, LocationBox.Text, Convert.ToInt32(CapacityBox.Text));
                _mainWindow.RefreshTheatreView();
                this.Close();
            }
        }

        private void GridContainer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount >= 2)
            {
                ShowPlay showPlay = new ShowPlay();
                showPlay.Show();
            }    
        }

        private void TheatrePlaysContainer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(TheatrePlaysContainer.SelectedItem != null)
            {
                _mainWindow.SetSelectedPlay(TheatrePlaysContainer.SelectedItem);
                PopulatePlayContainer();
            }
        }
    }
}
