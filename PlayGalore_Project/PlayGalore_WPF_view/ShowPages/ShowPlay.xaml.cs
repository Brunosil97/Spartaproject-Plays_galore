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
        }

        public void PopulateShowItems()
        {
            if(_mainWindow._playFunctions.selectedPlay != null)
            {

            }
        }
    }
}
