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

namespace WpfControlsTwoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TabItem item4 = new();
            item4.Header = "Tab 4";
            Button btn4 = new Button();
            btn4.Content = "For tab 4";
            item4.Content = btn4;

            tabCntrl.Items.Add(item4);
        }

        private void ButtonToUp_Click(object sender, RoutedEventArgs e)
        {
            scrollView.ScrollToHome();
        }

        private void LineUpButton_Click(object sender, RoutedEventArgs e)
        {
            scrollView.LineUp();
        }

        private void ButtonToDown_Click(object sender, RoutedEventArgs e)
        {
            scrollView.ScrollToEnd();
        }

        private void LineDownButton_Click(object sender, RoutedEventArgs e)
        {
            scrollView.LineDown();
        }
    }
}
