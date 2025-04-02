namespace Assignment4_1_1Form
{
    partial class FormSearchContact
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
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtSearchView = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFName.Location = new Point(50, 87);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(103, 23);
            lblFName.TabIndex = 0;
            lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLName.Location = new Point(52, 157);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(101, 23);
            lblLName.TabIndex = 1;
            lblLName.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFName.Location = new Point(174, 83);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(186, 31);
            txtFName.TabIndex = 2;
            // 
            // txtLName
            // 
            txtLName.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLName.Location = new Point(174, 153);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(186, 31);
            txtLName.TabIndex = 3;
            // 
            // txtSearchView
            // 
            txtSearchView.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchView.Location = new Point(463, 83);
            txtSearchView.Multiline = true;
            txtSearchView.Name = "txtSearchView";
            txtSearchView.Size = new Size(233, 296);
            txtSearchView.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(195, 327);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 48);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FormSearchContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchView);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Name = "FormSearchContact";
            Text = "FormSearchContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblFName;
        private Label lblLName;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtSearchView;
        private Button btnSearch;
    }
}