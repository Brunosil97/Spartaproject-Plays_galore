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

namespace PlayGalore_WPF_view.ShowPages
{
    /// <summary>
    /// Interaction logic for ShowPlay.xaml
    /// </summary>
    public partial class ShowPlay : Window
    {
        public MainWindow _mainWindow = ((MainWindow)Application.Current.MainWindow);
        public ShowPlay()
        {
            InitializeComponent();
            PopulateShowItems();
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

        public void PopulateShowItems()
        {
            var play = _mainWindow._playFunctions.selectedPlay;
            if (play != null)
            {
                TitleBox.Text = play.Title;
                BioBox.Text = play.Bio;
                GenreBox.Text = play.Genre;
                AuthorCombo.SelectedItem = play.Author;
                TheatreCombo.SelectedItem = play.Theatre;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var play = _mainWindow._playFunctions.selectedPlay;
            if (play != null)
            {
                _mainWindow.DeletePlay(play.PlayId);
                _mainWindow.RefeshHomeView();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var play = _mainWindow._playFunctions.selectedPlay;
            if (play != null)
            {
                _mainWindow.UpdatePlay(play.PlayId, TitleBox.Text, BioBox.Text, GenreBox.Text, AuthorCombo.SelectedItem, TheatreCombo.SelectedItem);
                _mainWindow.RefeshHomeView();
                this.Close();
            }
        }
    }
}
