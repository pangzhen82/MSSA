using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_3StuSys
{
    public partial class FormAddStu : Form
    {
        public FormAddStu()
        {
            InitializeComponent();
        }

        private void FormAddStu_Load(object sender, EventArgs e)
        {
            comboMonth.DataSource = Enum.GetValues(typeof(Month));
            comboGrade.DataSource = Enum.GetValues(typeof(Grade));
            comboMonth.ResetText();
            comboGrade.ResetText();
        }

        private void BtnSubmitAdd_Click(object sender, EventArgs e)
        {
            if (txtLName.Text != string.Empty && txtFName.Text != string.Empty)
            {
                var newStu = new Student(txtFName.Text, txtLName.Text, double.Parse(txtGPA.Text), (Month)comboMonth.SelectedIndex, (Grade)comboGrade.SelectedIndex);

                Data.students.Add(newStu);
                MessageBox.Show("New student recorded!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            comboMonth.ResetText();
            comboGrade.ResetText();
        }

        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFName.Text == string.Empty)
            {
                MessageBox.Show("Error! First name can't be empty!");
                e.Cancel = true;
                txtFName.Clear();
            }
        }

        private void txtLName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLName.Text == string.Empty)
            {
                MessageBox.Show("Error! Last name can't be empty!");
                e.Cancel = true;
                txtLName.Clear();
            }
        }

        private void txtGPA_Validating(object sender, CancelEventArgs e)
        {
            double gpa = 0d;
            if (txtGPA.Text == string.Empty || !double.TryParse(txtGPA.Text, out gpa) || gpa > 4)
            {
                MessageBox.Show("Error! Enter valid GPA!");
                e.Cancel = true;
                txtGPA.Clear();
            }
        }
    }
}
