using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFContactManager
{
    class Contact
    {
        public int ID { get; set; }
        public string fn { get; set; }
        public string ln { get; set; }
        public string email { get; set; }

        public string phone { get; set; }

        public Contact(object id, object fname, object lname, object email, object phone)
        {
            this.ID = int.Parse(id.ToString());
            this.fn = fname.ToString();
            this.ln = lname.ToString();
            this.email = email.ToString();
            this.phone = phone.ToString();
        }

        public override string ToString()
        {
            return ID + "," + fn + "," + ln + "," + email + "," + phone;
        }
    }
}
