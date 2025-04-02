using Assignment4_1_1Form;

namespace testForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load (object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btnAddContact_Click (object sender, EventArgs e)
        {
            FormAddContact addContact = new FormAddContact();
            this.Hide();
            addContact.ShowDialog();
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            if (DataPhoneBook.myPhoneBook.Count == 0)
            {
                MessageBox.Show("Error! Can't perform search when phone book is empty!");
            }
            else
            {
                FormSearchContact searchContact = new FormSearchContact();
                searchContact.ShowDialog();
            }
        }

        private void btnDelContact_Click(object sender, EventArgs e)
        {
            if (DataPhoneBook.myPhoneBook.Count == 0)
            {
                MessageBox.Show("Phone book is empty!");
            }
            else
            {
                var result = MessageBox.Show("Delete contact?", "Warning", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string fName = mainView[0, mainView.CurrentRow.Index].Value.ToString();
                    string lName = mainView[1, mainView.CurrentRow.Index].Value.ToString();
                    string key = fName.ToLower() + " " + lName.ToLower();
                    //MessageBox.Show($"Key = {key}");
                    DataPhoneBook.myPhoneBook.Remove(key);
                    RefreshView();
                }
            }
        }

        private void RefreshView()
        {
            mainView.DataSource = null;
            List<Person> list = DataPhoneBook.myPhoneBook.Values.ToList();
            mainView.DataSource = list;
        }
    }
}
