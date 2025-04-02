using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_1_1Form
{
    public partial class FormSearchContact : Form
    { 
        public FormSearchContact()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearchView.Clear();
            if (txtFName.Text != string.Empty && txtLName.Text != string.Empty)
            {
                string key = txtFName.Text + " " + txtLName.Text;
                if (DataPhoneBook.myPhoneBook.ContainsKey(key.ToLower()))
                {
                    Person person = DataPhoneBook.myPhoneBook[key.ToLower()];
                    txtSearchView.AppendText(person.ToString());
                }
                else
                {
                    MessageBox.Show($"Record {key} not found!");
                    Refresh();
                }
            }
            else if(txtFName.Text != string.Empty)
            {
                string fName = txtFName.Text.ToLower();
                List<Person> list = DataPhoneBook.myPhoneBook.Values.ToList();
                foreach (Person person in list)
                {
                    if (person.FirstName.ToLower() == fName)
                    {
                        txtSearchView.AppendText(person.ToString());
                    }
                }
            }
            else if (txtLName.Text != string.Empty)
            {
                string lName = txtLName.Text.ToLower();
                List<Person> list = DataPhoneBook.myPhoneBook.Values.ToList();
                foreach (Person person in list)
                {
                    if (person.LastName.ToLower() == lName)
                    {
                        txtSearchView.AppendText(person.ToString());
                    }
                }
            }
        }

        private void Refresh()
        {
            txtFName.Clear();
            txtLName.Clear();
        }
    }
}
