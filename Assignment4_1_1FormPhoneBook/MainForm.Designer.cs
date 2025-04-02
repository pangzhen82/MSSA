namespace testForm
{
    partial class MainForm
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
            btnAddContact = new Button();
            mainView = new DataGridView();
            btnDelContact = new Button();
            lblPhoneBook = new Label();
            btnSearchContact = new Button();
            ((System.ComponentModel.ISupportInitialize)mainView).BeginInit();
            SuspendLayout();
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(66, 409);
            btnAddContact.Margin = new Padding(4, 3, 4, 3);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(159, 46);
            btnAddContact.TabIndex = 0;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // mainView
            // 
            mainView.BackgroundColor = SystemColors.ControlLight;
            mainView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mainView.Location = new Point(66, 62);
            mainView.Name = "mainView";
            mainView.RowHeadersWidth = 51;
            mainView.Size = new Size(944, 320);
            mainView.TabIndex = 1;
            // 
            // btnDelContact
            // 
            btnDelContact.Location = new Point(851, 409);
            btnDelContact.Margin = new Padding(4, 3, 4, 3);
            btnDelContact.Name = "btnDelContact";
            btnDelContact.Size = new Size(159, 46);
            btnDelContact.TabIndex = 2;
            btnDelContact.Text = "Delete Contact";
            btnDelContact.UseVisualStyleBackColor = true;
            btnDelContact.Click += btnDelContact_Click;
            // 
            // lblPhoneBook
            // 
            lblPhoneBook.AutoSize = true;
            lblPhoneBook.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPhoneBook.Location = new Point(66, 19);
            lblPhoneBook.Name = "lblPhoneBook";
            lblPhoneBook.Size = new Size(188, 29);
            lblPhoneBook.TabIndex = 3;
            lblPhoneBook.Text = "My Phone Book";
            // 
            // btnSearchContact
            // 
            btnSearchContact.Location = new Point(250, 409);
            btnSearchContact.Margin = new Padding(4, 3, 4, 3);
            btnSearchContact.Name = "btnSearchContact";
            btnSearchContact.Size = new Size(159, 46);
            btnSearchContact.TabIndex = 4;
            btnSearchContact.Text = "Search Contact";
            btnSearchContact.UseVisualStyleBackColor = true;
            btnSearchContact.Click += btnSearchContact_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1100, 518);
            Controls.Add(btnSearchContact);
            Controls.Add(lblPhoneBook);
            Controls.Add(btnDelContact);
            Controls.Add(mainView);
            Controls.Add(btnAddContact);
            Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "My Phone Book";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)mainView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion





        private Button btnAddContact;
        private DataGridView mainView;
        private Button btnDelContact;
        private Label lblPhoneBook;
        private Button btnSearchContact;
    }
}
