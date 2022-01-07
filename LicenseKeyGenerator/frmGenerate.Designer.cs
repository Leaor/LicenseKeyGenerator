namespace LicenseKeyGenerator
{
    partial class frmGenerate
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
            this.btnGenerator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLicenseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtProductKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(583, 143);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(75, 23);
            this.btnGenerator.TabIndex = 0;
            this.btnGenerator.Text = "Generate";
            this.btnGenerator.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(109, 16);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(554, 23);
            this.txtProductID.TabIndex = 2;
            this.txtProductID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "License Type:";
            // 
            // cboLicenseType
            // 
            this.cboLicenseType.FormattingEnabled = true;
            this.cboLicenseType.Location = new System.Drawing.Point(119, 45);
            this.cboLicenseType.Name = "cboLicenseType";
            this.cboLicenseType.Size = new System.Drawing.Size(121, 23);
            this.cboLicenseType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Experience Days:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(138, 82);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(100, 23);
            this.txtExperience.TabIndex = 6;
            // 
            // txtProductKey
            // 
            this.txtProductKey.Location = new System.Drawing.Point(119, 111);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.Size = new System.Drawing.Size(554, 23);
            this.txtProductKey.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product Key:";
            // 
            // frmGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 178);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboLicenseType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerator);
            this.Name = "frmGenerate";
            this.Text = "Generate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerator;
        private Label label1;
        private TextBox txtProductID;
        private Label label2;
        private ComboBox cboLicenseType;
        private Label label3;
        private TextBox txtExperience;
        private TextBox txtProductKey;
        private Label label4;
        private Label label5;
    }
}