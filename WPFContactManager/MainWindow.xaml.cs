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

namespace WPFContactManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            Window1 wd1 = new Window1();
            wd1.Show();
        }

        private void DeleteContact_Click(object sender, RoutedEventArgs e)
        {
            Window4 wd4 = new Window4();
            wd4.Show();
        }

        private void UpdateContact_Click(object sender, RoutedEventArgs e)
        {
            Window3 wd3 = new Window3();
            wd3.Show();
        }

        private void ViewContact_Click(object sender, RoutedEventArgs e)
        {
            Window2 wd2 = new Window2();
            wd2.Show();
        }

    }


}
