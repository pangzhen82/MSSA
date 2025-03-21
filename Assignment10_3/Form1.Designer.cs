namespace Assignment10_3
{
    partial class Form1
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
            carGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtVIN = new TextBox();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtPrice = new TextBox();
            txtColor = new TextBox();
            txtYear = new TextBox();
            btnAdd = new Button();
            btnSelect = new Button();
            btnClearAll = new Button();
            btnSubmit = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)carGrid).BeginInit();
            SuspendLayout();
            // 
            // carGrid
            // 
            carGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carGrid.Location = new Point(44, 37);
            carGrid.Name = "carGrid";
            carGrid.RowHeadersWidth = 51;
            carGrid.Size = new Size(856, 286);
            carGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 366);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 1;
            label1.Text = "VIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 421);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 472);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(337, 421);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 6;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(346, 475);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 5;
            label5.Text = "Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(340, 367);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 4;
            label6.Text = "Price";
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(122, 364);
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(193, 27);
            txtVIN.TabIndex = 7;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(122, 419);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(193, 27);
            txtMake.TabIndex = 8;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(122, 473);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(193, 27);
            txtModel.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(412, 367);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 27);
            txtPrice.TabIndex = 10;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(412, 422);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(193, 27);
            txtColor.TabIndex = 11;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(412, 472);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(193, 27);
            txtYear.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(656, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add New Car";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSelect.Location = new Point(656, 422);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(114, 29);
            btnSelect.TabIndex = 14;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearAll.Location = new Point(656, 475);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(114, 29);
            btnClearAll.TabIndex = 15;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubmit.Location = new Point(786, 367);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(114, 29);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(786, 422);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(786, 477);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(974, 565);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(btnClearAll);
            Controls.Add(btnSelect);
            Controls.Add(btnAdd);
            Controls.Add(txtYear);
            Controls.Add(txtColor);
            Controls.Add(txtPrice);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(txtVIN);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(carGrid);
            Name = "Form1";
            Text = "Car Inventory";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)carGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView carGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtVIN;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtPrice;
        private TextBox txtColor;
        private TextBox txtYear;
        private Button btnAdd;
        private Button btnSelect;
        private Button btnClearAll;
        private Button btnSubmit;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
