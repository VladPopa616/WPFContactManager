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

namespace WPFContactManager
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        SQLCommunications sql = SQLCommunications.Instance;
        public Window4()
        {
            InitializeComponent();
        }

        private void DeleteContactConfirm(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact(int.Parse(DelTextBox.Text));
            sql.DeleteContacts(contact);

            MessageBox.Show(contact.ID.ToString(), "Contact has been deleted Success!",MessageBoxButton.OK);
            
        }


    }
}
