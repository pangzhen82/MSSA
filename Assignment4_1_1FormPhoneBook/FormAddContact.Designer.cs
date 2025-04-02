namespace Assignment4_1_1Form
{
    partial class FormAddContact
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
            lblFName = new Label();
            lblLName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddr = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddr = new TextBox();
            btnSubmit = new Button();
            btnClr = new Button();
            SuspendLayout();
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFName.Location = new Point(76, 67);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(92, 23);
            lblFName.TabIndex = 0;
            lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLName.Location = new Point(76, 120);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(91, 23);
            lblLName.TabIndex = 1;
            lblLName.Text = "Last Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(40, 172);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(127, 23);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(114, 223);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblAddr
            // 
            lblAddr.AutoSize = true;
            lblAddr.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddr.Location = new Point(93, 277);
            lblAddr.Name = "lblAddr";
            lblAddr.Size = new Size(70, 23);
            lblAddr.TabIndex = 4;
            lblAddr.Text = "Address";
            // 
            // txtFName
            // 
            txtFName.Font = new Font("Microsoft JhengHei", 10.8F);
            txtFName.Location = new Point(183, 64);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(204, 31);
            txtFName.TabIndex = 5;
            txtFName.Validating += txtFName_Validating;
            // 
            // txtLName
            // 
            txtLName.Font = new Font("Microsoft JhengHei", 10.8F);
            txtLName.Location = new Point(183, 116);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(204, 31);
            txtLName.TabIndex = 6;
            txtLName.Validating += txtLName_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Microsoft JhengHei", 10.8F);
            txtPhone.Location = new Point(183, 168);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(204, 31);
            txtPhone.TabIndex = 7;
            txtPhone.Text = "xxx-xxx-xxxx";
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft JhengHei", 10.8F);
            txtEmail.Location = new Point(183, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 31);
            txtEmail.TabIndex = 8;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtAddr
            // 
            txtAddr.Font = new Font("Microsoft JhengHei", 10.8F);
            txtAddr.Location = new Point(183, 285);
            txtAddr.Multiline = true;
            txtAddr.Name = "txtAddr";
            txtAddr.Size = new Size(204, 96);
            txtAddr.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(462, 340);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(108, 39);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Confirm Add";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClr
            // 
            btnClr.Location = new Point(601, 340);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(108, 39);
            btnClr.TabIndex = 11;
            btnClr.Text = "Clear";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // FormAddContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClr);
            Controls.Add(btnSubmit);
            Controls.Add(txtAddr);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(lblAddr);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Name = "FormAddContact";
            Text = "FormAddContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion




        private Label lblFName;
        private Label lblLName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddr;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddr;
        private Button btnSubmit;
        private Button btnClr;
    }
}