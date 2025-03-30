namespace Assignment3_3StuSys
{
    partial class FormAddStu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpStuRec = new GroupBox();
            txtGPA = new TextBox();
            lblGPA = new Label();
            lblIDinfo = new Label();
            btnClear = new Button();
            comboGrade = new ComboBox();
            comboMonth = new ComboBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            btnSubmitAdd = new Button();
            lblGrade = new Label();
            lblMonth = new Label();
            lblStuID = new Label();
            lblLName = new Label();
            lblStuFName = new Label();
            grpStuRec.SuspendLayout();
            SuspendLayout();
            // 
            // grpStuRec
            // 
            grpStuRec.BackColor = Color.Transparent;
            grpStuRec.Controls.Add(txtGPA);
            grpStuRec.Controls.Add(lblGPA);
            grpStuRec.Controls.Add(lblIDinfo);
            grpStuRec.Controls.Add(btnClear);
            grpStuRec.Controls.Add(comboGrade);
            grpStuRec.Controls.Add(comboMonth);
            grpStuRec.Controls.Add(txtLName);
            grpStuRec.Controls.Add(txtFName);
            grpStuRec.Controls.Add(btnSubmitAdd);
            grpStuRec.Controls.Add(lblGrade);
            grpStuRec.Controls.Add(lblMonth);
            grpStuRec.Controls.Add(lblStuID);
            grpStuRec.Controls.Add(lblLName);
            grpStuRec.Controls.Add(lblStuFName);
            grpStuRec.Location = new Point(342, 91);
            grpStuRec.Name = "grpStuRec";
            grpStuRec.Size = new Size(498, 404);
            grpStuRec.TabIndex = 0;
            grpStuRec.TabStop = false;
            grpStuRec.Text = "Student Record";
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(231, 175);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(124, 27);
            txtGPA.TabIndex = 14;
            txtGPA.Validating += txtGPA_Validating;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.ForeColor = SystemColors.Desktop;
            lblGPA.Location = new Point(173, 178);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(39, 19);
            lblGPA.TabIndex = 13;
            lblGPA.Text = "GPA";
            // 
            // lblIDinfo
            // 
            lblIDinfo.AutoSize = true;
            lblIDinfo.ForeColor = Color.Red;
            lblIDinfo.Location = new Point(231, 41);
            lblIDinfo.Name = "lblIDinfo";
            lblIDinfo.Size = new Size(173, 19);
            lblIDinfo.TabIndex = 1;
            lblIDinfo.Text = "Automatically Assigned";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(342, 333);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // comboGrade
            // 
            comboGrade.FormattingEnabled = true;
            comboGrade.Location = new Point(231, 273);
            comboGrade.Name = "comboGrade";
            comboGrade.Size = new Size(124, 26);
            comboGrade.TabIndex = 11;
            // 
            // comboMonth
            // 
            comboMonth.FormattingEnabled = true;
            comboMonth.Location = new Point(231, 226);
            comboMonth.Name = "comboMonth";
            comboMonth.Size = new Size(124, 26);
            comboMonth.TabIndex = 10;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(231, 127);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(205, 27);
            txtLName.TabIndex = 9;
            txtLName.Validating += txtLName_Validating;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(231, 82);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(205, 27);
            txtFName.TabIndex = 8;
            txtFName.Validating += txtFName_Validating;
            // 
            // btnSubmitAdd
            // 
            btnSubmitAdd.Location = new Point(231, 333);
            btnSubmitAdd.Name = "btnSubmitAdd";
            btnSubmitAdd.Size = new Size(94, 29);
            btnSubmitAdd.TabIndex = 6;
            btnSubmitAdd.Text = "Submit";
            btnSubmitAdd.UseVisualStyleBackColor = true;
            btnSubmitAdd.Click += BtnSubmitAdd_Click;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(160, 276);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(52, 19);
            lblGrade.TabIndex = 5;
            lblGrade.Text = "Grade";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Location = new Point(61, 229);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(151, 19);
            lblMonth.TabIndex = 4;
            lblMonth.Text = "Month of Admission";
            // 
            // lblStuID
            // 
            lblStuID.AutoSize = true;
            lblStuID.Location = new Point(125, 41);
            lblStuID.Name = "lblStuID";
            lblStuID.Size = new Size(79, 19);
            lblStuID.TabIndex = 3;
            lblStuID.Text = "StudentID";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.ForeColor = SystemColors.Desktop;
            lblLName.Location = new Point(129, 127);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(83, 19);
            lblLName.TabIndex = 2;
            lblLName.Text = "Last Name";
            // 
            // lblStuFName
            // 
            lblStuFName.AutoSize = true;
            lblStuFName.ForeColor = SystemColors.Desktop;
            lblStuFName.Location = new Point(127, 85);
            lblStuFName.Name = "lblStuFName";
            lblStuFName.Size = new Size(85, 19);
            lblStuFName.TabIndex = 1;
            lblStuFName.Text = "First Name";
            // 
            // FormAddStu
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Assignment4_2FormStuSys.Properties.Resources.Login_Pic;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1049, 528);
            Controls.Add(grpStuRec);
            DoubleBuffered = true;
            Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Desktop;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAddStu";
            Text = "Add Student";
            Load += FormAddStu_Load;
            grpStuRec.ResumeLayout(false);
            grpStuRec.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpStuRec;
        private Label lblMonth;
        private Label lblStuID;
        private Label lblLName;
        private Label lblStuFName;
        private ComboBox comboGrade;
        private ComboBox comboMonth;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtGPA;
        private Button btnSubmitAdd;
        private Label lblGrade;
        private Button btnClear;
        private Label lblIDinfo;
        private Label lblGPA;
    }
}