namespace Assignment3_3StuSys
{
    partial class MainForm
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
            lblPortal = new Label();
            gridStuView = new DataGridView();
            btnAddStu = new Button();
            btnRefresh = new Button();
            btnDelStu = new Button();
            btnSortByID = new Button();
            btnSortByName = new Button();
            btnSortByGPA = new Button();
            grpSort = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)gridStuView).BeginInit();
            grpSort.SuspendLayout();
            SuspendLayout();
            // 
            // lblPortal
            // 
            lblPortal.AutoSize = true;
            lblPortal.BackColor = Color.Transparent;
            lblPortal.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPortal.Location = new Point(81, 50);
            lblPortal.Name = "lblPortal";
            lblPortal.Size = new Size(153, 24);
            lblPortal.TabIndex = 0;
            lblPortal.Text = "Student Record";
            // 
            // gridStuView
            // 
            gridStuView.BackgroundColor = SystemColors.ButtonFace;
            gridStuView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStuView.GridColor = SystemColors.Info;
            gridStuView.Location = new Point(81, 95);
            gridStuView.Name = "gridStuView";
            gridStuView.RowHeadersWidth = 51;
            gridStuView.Size = new Size(691, 301);
            gridStuView.TabIndex = 1;
            // 
            // btnAddStu
            // 
            btnAddStu.BackColor = SystemColors.ButtonFace;
            btnAddStu.Location = new Point(81, 422);
            btnAddStu.Name = "btnAddStu";
            btnAddStu.Size = new Size(142, 36);
            btnAddStu.TabIndex = 2;
            btnAddStu.Text = "Add New Student";
            btnAddStu.UseVisualStyleBackColor = false;
            btnAddStu.Click += btnAddStu_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonFace;
            btnRefresh.Location = new Point(246, 422);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(138, 36);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelStu
            // 
            btnDelStu.BackColor = SystemColors.ButtonFace;
            btnDelStu.Location = new Point(620, 422);
            btnDelStu.Name = "btnDelStu";
            btnDelStu.Size = new Size(152, 36);
            btnDelStu.TabIndex = 4;
            btnDelStu.Text = "Delete Student";
            btnDelStu.UseVisualStyleBackColor = false;
            btnDelStu.Click += btnDelStu_Click;
            // 
            // btnSortByID
            // 
            btnSortByID.BackColor = SystemColors.ButtonFace;
            btnSortByID.ForeColor = SystemColors.ActiveCaptionText;
            btnSortByID.Location = new Point(15, 88);
            btnSortByID.Name = "btnSortByID";
            btnSortByID.Size = new Size(120, 36);
            btnSortByID.TabIndex = 5;
            btnSortByID.Text = "By ID";
            btnSortByID.UseVisualStyleBackColor = false;
            btnSortByID.Click += btnSortByID_Click;
            // 
            // btnSortByName
            // 
            btnSortByName.BackColor = SystemColors.ButtonFace;
            btnSortByName.ForeColor = SystemColors.ActiveCaptionText;
            btnSortByName.Location = new Point(15, 33);
            btnSortByName.Name = "btnSortByName";
            btnSortByName.Size = new Size(120, 36);
            btnSortByName.TabIndex = 6;
            btnSortByName.Text = "By Name";
            btnSortByName.UseVisualStyleBackColor = false;
            btnSortByName.Click += btnSortByName_Click;
            // 
            // btnSortByGPA
            // 
            btnSortByGPA.BackColor = SystemColors.ButtonFace;
            btnSortByGPA.ForeColor = SystemColors.ActiveCaptionText;
            btnSortByGPA.Location = new Point(15, 142);
            btnSortByGPA.Name = "btnSortByGPA";
            btnSortByGPA.Size = new Size(120, 36);
            btnSortByGPA.TabIndex = 7;
            btnSortByGPA.Text = "By GPA";
            btnSortByGPA.UseVisualStyleBackColor = false;
            btnSortByGPA.Click += btnSortByGPA_Click;
            // 
            // grpSort
            // 
            grpSort.BackColor = Color.Transparent;
            grpSort.Controls.Add(btnSortByID);
            grpSort.Controls.Add(btnSortByGPA);
            grpSort.Controls.Add(btnSortByName);
            grpSort.Location = new Point(791, 95);
            grpSort.Name = "grpSort";
            grpSort.Size = new Size(150, 199);
            grpSort.TabIndex = 8;
            grpSort.TabStop = false;
            grpSort.Text = "Sort Students";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Assignment4_2FormStuSys.Properties.Resources.Login_Pic;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1002, 531);
            Controls.Add(grpSort);
            Controls.Add(btnDelStu);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddStu);
            Controls.Add(gridStuView);
            Controls.Add(lblPortal);
            DoubleBuffered = true;
            Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridStuView).EndInit();
            grpSort.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPortal;
        private DataGridView gridStuView;
        private Button btnAddStu;
        private Button btnRefresh;
        private Button btnDelStu;
        private Button btnSortByID;
        private Button btnSortByName;
        private Button btnSortByGPA;
        private GroupBox grpSort;
    }
}