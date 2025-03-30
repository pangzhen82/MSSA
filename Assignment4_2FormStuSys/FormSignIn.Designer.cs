namespace Assignment3_3StuSys
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            grpLogin = new GroupBox();
            btnRegister = new Button();
            btnSignIn = new Button();
            txtPW = new TextBox();
            txtUser = new TextBox();
            lblPW = new Label();
            lblUser = new Label();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Lucida Sans", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(280, 134);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(615, 33);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to student maintenance portal!";
            // 
            // grpLogin
            // 
            grpLogin.BackColor = Color.Transparent;
            grpLogin.Controls.Add(btnRegister);
            grpLogin.Controls.Add(btnSignIn);
            grpLogin.Controls.Add(txtPW);
            grpLogin.Controls.Add(txtUser);
            grpLogin.Controls.Add(lblPW);
            grpLogin.Controls.Add(lblUser);
            grpLogin.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpLogin.Location = new Point(346, 211);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(471, 249);
            grpLogin.TabIndex = 1;
            grpLogin.TabStop = false;
            grpLogin.Text = "Teacher Login";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(286, 176);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(116, 37);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(168, 176);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(100, 37);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPW
            // 
            txtPW.Location = new Point(168, 113);
            txtPW.Name = "txtPW";
            txtPW.PasswordChar = '*';
            txtPW.Size = new Size(234, 29);
            txtPW.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(168, 57);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(234, 29);
            txtUser.TabIndex = 4;
            // 
            // lblPW
            // 
            lblPW.AutoSize = true;
            lblPW.Location = new Point(50, 116);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(88, 20);
            lblPW.TabIndex = 3;
            lblPW.Text = "Password: ";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(36, 60);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(101, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "User Name: ";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Assignment4_2FormStuSys.Properties.Resources.Login_Pic;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 615);
            Controls.Add(grpLogin);
            Controls.Add(lblWelcome);
            DoubleBuffered = true;
            Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "formLogin";
            Text = "Welcome";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private GroupBox grpLogin;
        private Button btnRegister;
        private Button btnSignIn;
        private TextBox txtPW;
        private TextBox txtUser;
        private Label lblPW;
        private Label lblUser;
    }
}
