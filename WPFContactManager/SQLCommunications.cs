using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPFContactManager
{
    class SQLCommunications
    {
        private const string CON_STRING = @"data source=localhost\SQLEXPRESS2;database = Contact;Trusted_Connection=True";

        private SQLCommunications()
        {

        }

        static readonly SQLCommunications instance = new SQLCommunications();

        public static SQLCommunications Instance
        {
            get
            {
                return instance;
            }
        }


        public void AddContacts(Contact contact)
        {
            using (var con = new SqlConnection(CON_STRING))
            {
                var query = "insert into FirstName, LastName, Email, Phonenumber values(@FirstName, @LastName, @desc)";
                using (SqlCommand cm = new SqlCommand(query, con))
                {
                    con.Open();

                    cm.Parameters.AddWithValue("@FirstName", contact.fn);
                    cm.Parameters.AddWithValue("@LastName", contact.ln);
                    cm.Parameters.AddWithValue("@Email", contact.email);
                    cm.Parameters.AddWithValue("@PhoneNumber", contact.phone);

                    cm.ExecuteNonQuery();
                }

            }


        }
        public List<Contact> ReadContacts(Contact contact)
        {
            List<Contact> contacts = new List<Contact>();
            using (var con = new SqlConnection(CON_STRING))
            {
                var query = "select * from contact";

                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object Id = reader["Id"];
                            object FName = reader["fn"];
                            object LName = reader["ln"];
                            object Email = reader["email"];
                            object Phone = reader["phone"];

                            contacts.Add(new Contact(Id, FName, LName, Email, Phone));
                        }
                    }
                }
            }
            return contacts;
        }

        public void UpdateContacts(Contact contact)
        {
            using (var con = new SqlConnection(CON_STRING))
            {
                var query = "UPDATE Contact SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone";
                using (var cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@FirstName", contact.fn);
                    cmd.Parameters.AddWithValue("@LastName", contact.ln);
                    cmd.Parameters.AddWithValue("@Email", contact.email);
                    cmd.Parameters.AddWithValue("@Phone", contact.phone);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteContacts(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                using (var con = new SqlConnection(CON_STRING))
                {
                    var query = "delete from contacts where FirstName=@FirstName and LastName=@LastName and Email=@Email and Phone=@Phone";
                    using (var cmd = new SqlCommand(query, con))
                    {


                        cmd.Parameters.AddWithValue("@FirstName", contact.fn);
                        cmd.Parameters.AddWithValue("@LastName", contact.ln);
                        cmd.Parameters.AddWithValue("@Email", contact.email);
                        cmd.Parameters.AddWithValue("@Phone", contact.phone);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
