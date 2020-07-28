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
    /// Interaction logic for AddTheatre.xaml
    /// </summary>
    public partial class AddTheatre : Window
    {
        public MainWindow _mainWindow = ((MainWindow)Application.Current.MainWindow);
        public AddTheatre()
        {
            InitializeComponent();
        }

        private void Save_Button(object sender, RoutedEventArgs e)
        {
            _mainWindow.CreateNewTheatre(NameBox.Text, LocationBox.Text, Convert.ToInt32(CapacityBox.Text));
            this.Close();
        }
    }
}
