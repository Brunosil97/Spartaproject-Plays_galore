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
    /// Interaction logic for ShowAuthor.xaml
    /// </summary>
    public partial class ShowAuthor : Window
    {
        public MainWindow _mainWindow = ((MainWindow)Application.Current.MainWindow);

        public ShowAuthor()
        {
            InitializeComponent();
            PopulateShowPage();
        }

        public void PopulateShowPage()
        {
            var author = _mainWindow._authorFunctions.selectedAuthor;
            if (author != null)
            {
                firstName.Text = author.FirstName;
                lastName.Text = author.LastName;
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var author = _mainWindow._authorFunctions.selectedAuthor;
            if (author != null)
            {
                _mainWindow.UpdateAuthor(author.AuthorId, firstName.Text, lastName.Text);
                this.Close();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var author = _mainWindow._authorFunctions.selectedAuthor;
            if (author != null)
            {
                _mainWindow.DeleteAuthor(author.AuthorId);
                this.Close();
            }
        }
    }
}
