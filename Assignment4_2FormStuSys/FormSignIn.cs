using Microsoft.VisualBasic.ApplicationServices;

namespace Assignment3_3StuSys
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string user, pw;
            if (txtUser.Text.Length != 0)
            {
                user = txtUser.Text;
                if (Data.credentials.ContainsKey(user))
                {
                    Data.credentials.TryGetValue(user, out pw);
                    if (pw == txtPW.Text)
                    {
                        MessageBox.Show("Login Successfully! Welcome to Teacher's portal!");
                        MainForm mainForm = new MainForm();
                        this.Hide();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password! Please try again!");
                        txtPW.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("User not registered! Click Register now!");
                    txtPW.Clear();
                }
            }
            else
            {
                MessageBox.Show("Error! User Name can't be empty!");
                txtUser.Clear();
                txtPW.Clear();
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user, pw;
            if (txtUser.Text.Length != 0)
            {
                user = txtUser.Text;
                if (Data.credentials.ContainsKey(user))
                {
                    MessageBox.Show("User already exist!");
                    txtUser.Clear();
                    txtPW.Clear();
                }
                else
                {
                    pw = txtPW.Text;
                    if (pw.Length == 0)
                    {
                        MessageBox.Show("Error! Password can't be empty!");
                        txtUser.Clear();
                        txtPW.Clear();
                    }
                    else
                    {
                        Data.credentials.Add(user, pw);  // add the user and pw to new creditial list
                        MessageBox.Show("User register successfully!\nSign in with your password!");
                        txtPW.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error! User Name can't be empty!");
                txtUser.Clear();
                txtPW.Clear();
            }
        }
    }
}
