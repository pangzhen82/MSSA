namespace Assignment10_1
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
            lblCity = new Label();
            lblType = new Label();
            lblTemperature = new Label();
            lblWindLevel = new Label();
            txtCity = new TextBox();
            txtTemperature = new TextBox();
            txtWindLevel = new TextBox();
            btnAddCity = new Button();
            btnJsonSerialize = new Button();
            btnJsonDeserialize = new Button();
            comboWeatherType = new ComboBox();
            btnXmlDeserialize = new Button();
            btnXmlSerialize = new Button();
            SuspendLayout();
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(177, 88);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(41, 20);
            lblCity.TabIndex = 0;
            lblCity.Text = "City: ";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(151, 126);
            lblType.Name = "lblType";
            lblType.Size = new Size(67, 20);
            lblType.TabIndex = 1;
            lblType.Text = "Weather:";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Location = new Point(122, 166);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(96, 20);
            lblTemperature.TabIndex = 2;
            lblTemperature.Text = "Temperature:";
            // 
            // lblWindLevel
            // 
            lblWindLevel.AutoSize = true;
            lblWindLevel.Location = new Point(133, 206);
            lblWindLevel.Name = "lblWindLevel";
            lblWindLevel.Size = new Size(85, 20);
            lblWindLevel.TabIndex = 3;
            lblWindLevel.Text = "Wind Level:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(224, 85);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(167, 27);
            txtCity.TabIndex = 4;
            txtCity.Validating += txtCity_Validating;
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(224, 163);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(167, 27);
            txtTemperature.TabIndex = 5;
            txtTemperature.Validating += txtTemperature_Validating;
            // 
            // txtWindLevel
            // 
            txtWindLevel.Location = new Point(224, 203);
            txtWindLevel.Name = "txtWindLevel";
            txtWindLevel.Size = new Size(167, 27);
            txtWindLevel.TabIndex = 7;
            txtWindLevel.Validating += txtWindLevel_Validating;
            // 
            // btnAddCity
            // 
            btnAddCity.Location = new Point(224, 253);
            btnAddCity.Name = "btnAddCity";
            btnAddCity.Size = new Size(119, 29);
            btnAddCity.TabIndex = 8;
            btnAddCity.Text = "Record City";
            btnAddCity.UseVisualStyleBackColor = true;
            btnAddCity.Click += btnAddCity_Click;
            // 
            // btnJsonSerialize
            // 
            btnJsonSerialize.Location = new Point(429, 88);
            btnJsonSerialize.Name = "btnJsonSerialize";
            btnJsonSerialize.Size = new Size(139, 29);
            btnJsonSerialize.TabIndex = 9;
            btnJsonSerialize.Text = "JSON Serialize";
            btnJsonSerialize.UseVisualStyleBackColor = true;
            btnJsonSerialize.Click += btnJsonSerialize_Click;
            // 
            // btnJsonDeserialize
            // 
            btnJsonDeserialize.Location = new Point(427, 133);
            btnJsonDeserialize.Name = "btnJsonDeserialize";
            btnJsonDeserialize.Size = new Size(139, 29);
            btnJsonDeserialize.TabIndex = 10;
            btnJsonDeserialize.Text = "JSON Deserialize";
            btnJsonDeserialize.UseVisualStyleBackColor = true;
            btnJsonDeserialize.Click += btnJsonDeserialize_Click;
            // 
            // comboWeatherType
            // 
            comboWeatherType.FormattingEnabled = true;
            comboWeatherType.Location = new Point(224, 123);
            comboWeatherType.Name = "comboWeatherType";
            comboWeatherType.Size = new Size(167, 28);
            comboWeatherType.TabIndex = 11;
            // 
            // btnXmlDeserialize
            // 
            btnXmlDeserialize.Location = new Point(425, 225);
            btnXmlDeserialize.Name = "btnXmlDeserialize";
            btnXmlDeserialize.Size = new Size(139, 29);
            btnXmlDeserialize.TabIndex = 13;
            btnXmlDeserialize.Text = "XML Deserialize";
            btnXmlDeserialize.UseVisualStyleBackColor = true;
            btnXmlDeserialize.Click += btnXmlDeserialize_Click;
            // 
            // btnXmlSerialize
            // 
            btnXmlSerialize.Location = new Point(427, 180);
            btnXmlSerialize.Name = "btnXmlSerialize";
            btnXmlSerialize.Size = new Size(139, 29);
            btnXmlSerialize.TabIndex = 12;
            btnXmlSerialize.Text = "XML Serialize";
            btnXmlSerialize.UseVisualStyleBackColor = true;
            btnXmlSerialize.Click += btnXmlSerialize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXmlDeserialize);
            Controls.Add(btnXmlSerialize);
            Controls.Add(comboWeatherType);
            Controls.Add(btnJsonDeserialize);
            Controls.Add(btnJsonSerialize);
            Controls.Add(btnAddCity);
            Controls.Add(txtWindLevel);
            Controls.Add(txtTemperature);
            Controls.Add(txtCity);
            Controls.Add(lblWindLevel);
            Controls.Add(lblTemperature);
            Controls.Add(lblType);
            Controls.Add(lblCity);
            Name = "Form1";
            Text = "Weather";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCity;
        private Label lblType;
        private Label lblTemperature;
        private Label lblWindLevel;
        private TextBox txtCity;
        private TextBox txtTemperature;
        private TextBox txtWindLevel;
        private Button btnAddCity;
        private Button btnJsonSerialize;
        private Button btnJsonDeserialize;
        private ComboBox comboWeatherType;
        private Button btnXmlDeserialize;
        private Button btnXmlSerialize;
    }
}
