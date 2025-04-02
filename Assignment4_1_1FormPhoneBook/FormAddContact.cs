using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using testForm;

namespace Assignment4_1_1Form
{
    public partial class FormAddContact : Form
    {
        public FormAddContact()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string key = txtFName.Text + " " + txtLName.Text;
            if (DataPhoneBook.myPhoneBook.ContainsKey(key.ToLower()))
            {
                MessageBox.Show($"Record of {key} already exist!");
            }
            else
            {
                DataPhoneBook.myPhoneBook.Add(key.ToLower(), new Person(txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text, txtAddr.Text));
                MessageBox.Show($"Record of {key} added successfully!");
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                
            }
        }

        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFName.Text == string.Empty)
            {
                MessageBox.Show("First name can't be blank!");
                e.Cancel = true;
                txtFName.Clear();
            }
        }

        private void txtLName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLName.Text == string.Empty)
            {
                MessageBox.Show("Last name can't be blank!");
                e.Cancel = true;
                txtLName.Clear();
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text == string.Empty || txtPhone.Text.Length != 12 || txtPhone.Text.Contains("x"))
            {
                MessageBox.Show("Enter valid phone format!");
                e.Cancel = true;
                txtPhone.Text = "xxx-xxx-xxxx";
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text == string.Empty || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Enter valid email address!");
                e.Cancel = true;
                txtEmail.Clear();
            }
        }

        private void ResetForm()
        {
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Text = "xxx-xxx-xxxx";
            txtEmail.Clear();
            txtAddr.Clear();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
