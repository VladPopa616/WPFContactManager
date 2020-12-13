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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        SQLCommunications sql = SQLCommunications.Instance;
        public Window2()
        {
            InitializeComponent();
            ShowContacts();
        }

        private void ShowContacts()
        {
            Contact contact = new Contact(FirstNameBox.Text, LastNameBox.Text, EmailBox.Text, PhoneBox.Text);
            FirstNameBox.Text = contact.fn;
            LastNameBox.Text = contact.ln;
            EmailBox.Text = contact.email;
            PhoneBox.Text = contact.phone;

            sql.ReadContacts(contact);
        }
       

    }
}
