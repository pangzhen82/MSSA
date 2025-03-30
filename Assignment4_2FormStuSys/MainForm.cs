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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void RefreshView()
        {
            gridStuView.DataSource = null;
            gridStuView.DataSource = Data.students;
            gridStuView.Columns[0].Width = 100;
            gridStuView.Columns[1].Width = 150;
            gridStuView.Columns[2].Width = 150;
            gridStuView.Columns[3].Width = 100;
            gridStuView.Columns[4].Width = 230;
            gridStuView.Columns[5].Width = 100;
        }

       
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddStu formAddStu = new FormAddStu();
            formAddStu.ShowDialog();
        }

        private void btnDelStu_Click(object sender, EventArgs e)
        {
            if (Data.students.Count == 0)
            {
                MessageBox.Show("Error! No more student record!");
            }
            else
            {
                var result = MessageBox.Show("Student will be perminently deleted!\n\tContinue?", "Warning!", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    Data.students.RemoveAt(gridStuView.CurrentRow.Index);
                    RefreshView();
                }
            }
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            if (Data.students.Count == 0)
            {
                MessageBox.Show("Error! No more student record!");
            }
            else
            {
                Data.students.Sort();
                RefreshView();
            }
        }

        private void btnSortByID_Click(object sender, EventArgs e)
        {
            if (Data.students.Count == 0)
            {
                MessageBox.Show("Error! No more student record!");
            }
            else
            {
                Data.students.Sort(new StudentIDComparar());
                RefreshView();
            }
        }

        private void btnSortByGPA_Click(object sender, EventArgs e)
        {
            if (Data.students.Count == 0)
            {
                MessageBox.Show("Error! No more student record!");
            }
            else
            {
                Data.students.Sort(new StudentGPAComparar());
                FileRecord.RecordTopStudentinFile("Top_GPA_Student.txt");
                RefreshView();
            }
        }
    }
}
