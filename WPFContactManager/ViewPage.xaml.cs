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
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace WPFContactManager
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        SQLCommunications sql = SQLCommunications.Instance;
        public Window2()
        {
            InitializeComponent();
            
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            List<Contact> contacts = new List<Contact>();
            contacts.AddRange(sql.ReadContacts());
            dataView.ItemsSource = contacts;
        }

        private void ShowDetails(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(dataView.SelectedItem.ToString(), "Information",MessageBoxButton.OK);
        }
       

    }
}
