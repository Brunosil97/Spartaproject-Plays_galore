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

        public List<Play> GetPlaysForSelectedTheatre(int theatreId)
        {
            return _theatreFunctions.RetrieveAllPlaysForTheatre(theatreId);
        }

        public List<Play> GetPlaysForSelectedAuthor(int authorId)
        {
            return _authorFunctions.RetrievePlaysForAuthor(authorId);
        }

        public void CreateNewPlay(string title, string bio, string genre, object author, object theatre)
        {
            _playFunctions.CreateAPlay(title, bio, genre, author, theatre);
        }

        public void CreateNewAuthor(string lastName, string firstName)
        {
            _authorFunctions.CreateAAuthor(lastName, firstName);
        }

        public void DeletePlay(int playId)
        {
            _playFunctions.DeleteAPlay(playId);
        }

        public void UpdatePlay(int playId, string title, string bio, string genre, object author, object theatre)
        {
            _playFunctions.UpdateAPlay(playId, title, bio, genre, author, theatre);
        }


        public void UpdateAuthor(int authorId, string firstName, string lastName)
        {
            _authorFunctions.UpdateExistingAuthor(authorId, firstName, lastName);
        }

        public void DeleteAuthor(int authorId)
        {
            _authorFunctions.DeleteExistingAuthor(authorId);
        }

        public void CreateNewTheatre(string name, string location, int capacity)
        {
            _theatreFunctions.CreateATheatre(name, location, capacity);
        }

        public void UpdateTheatre(int theatreId, string name, string location, int capacity)
        {
            _theatreFunctions.UpdateExistingTheatre(theatreId, name, location, capacity);
        }
        public void DeleteTheatre(int theatreId)
        {
            _theatreFunctions.DeleteExistingTheatre(theatreId);
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

        public void SetSelectedAuthor(object selectedItem)
        {
            _authorFunctions.SetSelectedAuthor(selectedItem);
        }

        public void SetSelectedTheatre(object selectedItem)
        {
            _theatreFunctions.SetSelectedTheatre(selectedItem);
        }
    }
}
