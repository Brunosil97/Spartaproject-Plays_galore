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
    /// Interaction logic for AuthorView.xaml
    /// </summary>
    public partial class AuthorView : UserControl
    {
        public MainWindow _mainWindow = ((MainWindow)Application.Current.MainWindow);
        public AuthorView()
        {
            InitializeComponent();
            DisplayRetrievedAuthorsOnScroll();
        }

        public void DisplayRetrievedAuthorsOnScroll()
        {
            var authors = _mainWindow.RetrieveAllAuthors();
            AuthorContainer.ItemsSource = authors;
        }

        public void GetPlayCountForAuthor(int authorId)
        {
            var author = _mainWindow._authorFunctions.selectedAuthor;
            if(author != null)
            {
              
            }
        }
        private void AuthorContainer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AuthorContainer.SelectedItem != null)
            {
                _mainWindow.SetSelectedAuthor(AuthorContainer.SelectedItem);
                DisplayRetrievedAuthorsOnScroll();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.Show();
        }

        private void GridContainer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount >= 2)
            {
                ShowAuthor showAuthor = new ShowAuthor();
                showAuthor.Show();
            }
        }
    }
}
