namespace LicenseKeyGenerator
{
    partial class frmAbout
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.lblLicenseType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(237, 174);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Key:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "License Type:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(143, 38);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(12, 15);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "?";
            this.lblProductName.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(143, 61);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(12, 15);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "?";
            // 
            // lblProductKey
            // 
            this.lblProductKey.AutoSize = true;
            this.lblProductKey.Location = new System.Drawing.Point(143, 88);
            this.lblProductKey.Name = "lblProductKey";
            this.lblProductKey.Size = new System.Drawing.Size(12, 15);
            this.lblProductKey.TabIndex = 7;
            this.lblProductKey.Text = "?";
            // 
            // lblLicenseType
            // 
            this.lblLicenseType.AutoSize = true;
            this.lblLicenseType.Location = new System.Drawing.Point(143, 115);
            this.lblLicenseType.Name = "lblLicenseType";
            this.lblLicenseType.Size = new System.Drawing.Size(12, 15);
            this.lblLicenseType.TabIndex = 8;
            this.lblLicenseType.Text = "?";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 240);
            this.Controls.Add(this.lblLicenseType);
            this.Controls.Add(this.lblProductKey);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Name = "frmAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblProductName;
        private Label lblProductID;
        private Label lblProductKey;
        private Label lblLicenseType;
    }
}