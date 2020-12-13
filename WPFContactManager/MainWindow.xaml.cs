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
using Microsoft.Win32;
using System.IO;

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

        private void ImportCSV_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Csv files (*.csv)|*.csv|All files(*.*)|*.*";
            List<Contact> fileContact = new List<Contact>();

            if(opf.ShowDialog() == true)
            {
                string[] fileContents = File.ReadAllLines(opf.FileName);

                foreach(string s in fileContents)
                {
                    string[] items = s.Split(',');
                    Contact contact = new Contact(items[0], items[1], items[2], items[3]);
                    fileContact.Add(contact);
                }
            }

            var data = SQLCommunications.Instance;
            foreach(Contact contact in fileContact)
            {
                data.AddContacts(contact);
            }

            MessageBox.Show(opf.FileName, "Added to database", MessageBoxButton.OK);
        }

        private void ExportCSV_Click(object sender, RoutedEventArgs e)
        {

        }

    }


}
