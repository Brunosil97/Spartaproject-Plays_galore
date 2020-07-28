using PlayGalore_controller;
using PlayGalore_model.Models;
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

        public List<Play> RetrieveAllPlaysForHome()
        {
            return _playFunctions.RetrieveAllPlays();
        }

        public List<Author> RetrieveAllAuthors()
        {
            return _authorFunctions.RetrieveAllAuthors();
        }

        public List<Theatre> RetrieveAllTheatres()
        {
            return _theatreFunctions.RetrieveAllTheatres();
        }

        public void CreateNewPlay(string title, string bio, string genre, object author, object theatre)
        {
            _playFunctions.CreateAPlay(title, bio, genre, author, theatre);
        }

        public void DeletePlay(int playId)
        {
            _playFunctions.DeleteAPlay(playId);
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

        public void SetSelectedPlay(object selectedItem)
        {
            _playFunctions.SetSelectedPlay(selectedItem);
        }
    }
}
