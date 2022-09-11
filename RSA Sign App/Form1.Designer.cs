namespace RSA_Sign_App
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
            this.txtPrivateKeyLocation = new System.Windows.Forms.TextBox();
            this.btnBrowsePrivateKey = new System.Windows.Forms.Button();
            this.btnPublicKey = new System.Windows.Forms.Button();
            this.txtPublicKeyLocation = new System.Windows.Forms.TextBox();
            this.cboRsaSHAkey = new System.Windows.Forms.ComboBox();
            this.txtBaseString = new System.Windows.Forms.TextBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.btnGenerateSign = new System.Windows.Forms.Button();
            this.btnVerifySign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrivateKeyLocation
            // 
            this.txtPrivateKeyLocation.Enabled = false;
            this.txtPrivateKeyLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPrivateKeyLocation.Location = new System.Drawing.Point(31, 57);
            this.txtPrivateKeyLocation.Name = "txtPrivateKeyLocation";
            this.txtPrivateKeyLocation.Size = new System.Drawing.Size(391, 23);
            this.txtPrivateKeyLocation.TabIndex = 0;
            this.txtPrivateKeyLocation.Text = "Private Locations";
            // 
            // btnBrowsePrivateKey
            // 
            this.btnBrowsePrivateKey.Location = new System.Drawing.Point(473, 57);
            this.btnBrowsePrivateKey.Name = "btnBrowsePrivateKey";
            this.btnBrowsePrivateKey.Size = new System.Drawing.Size(125, 23);
            this.btnBrowsePrivateKey.TabIndex = 1;
            this.btnBrowsePrivateKey.Text = "Browse Private Key";
            this.btnBrowsePrivateKey.UseVisualStyleBackColor = true;
            this.btnBrowsePrivateKey.Click += new System.EventHandler(this.btnBrowsePrivateKey_Click);
            // 
            // btnPublicKey
            // 
            this.btnPublicKey.Location = new System.Drawing.Point(473, 108);
            this.btnPublicKey.Name = "btnPublicKey";
            this.btnPublicKey.Size = new System.Drawing.Size(125, 23);
            this.btnPublicKey.TabIndex = 3;
            this.btnPublicKey.Text = "Browse Public Key";
            this.btnPublicKey.UseVisualStyleBackColor = true;
            this.btnPublicKey.Click += new System.EventHandler(this.btnPublicKey_Click);
            // 
            // txtPublicKeyLocation
            // 
            this.txtPublicKeyLocation.Enabled = false;
            this.txtPublicKeyLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPublicKeyLocation.Location = new System.Drawing.Point(31, 108);
            this.txtPublicKeyLocation.Name = "txtPublicKeyLocation";
            this.txtPublicKeyLocation.Size = new System.Drawing.Size(391, 23);
            this.txtPublicKeyLocation.TabIndex = 2;
            this.txtPublicKeyLocation.Text = "Public Locations";
            // 
            // cboRsaSHAkey
            // 
            this.cboRsaSHAkey.FormattingEnabled = true;
            this.cboRsaSHAkey.Location = new System.Drawing.Point(651, 85);
            this.cboRsaSHAkey.Name = "cboRsaSHAkey";
            this.cboRsaSHAkey.Size = new System.Drawing.Size(161, 23);
            this.cboRsaSHAkey.TabIndex = 4;
            // 
            // txtBaseString
            // 
            this.txtBaseString.Location = new System.Drawing.Point(31, 184);
            this.txtBaseString.Multiline = true;
            this.txtBaseString.Name = "txtBaseString";
            this.txtBaseString.Size = new System.Drawing.Size(604, 82);
            this.txtBaseString.TabIndex = 5;
            this.txtBaseString.Text = "Place Your Base String Here";
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(31, 298);
            this.txtSignature.Multiline = true;
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(604, 100);
            this.txtSignature.TabIndex = 6;
            this.txtSignature.Text = "Place Your Signature Here (If any)";
            // 
            // btnGenerateSign
            // 
            this.btnGenerateSign.Location = new System.Drawing.Point(704, 196);
            this.btnGenerateSign.Name = "btnGenerateSign";
            this.btnGenerateSign.Size = new System.Drawing.Size(134, 56);
            this.btnGenerateSign.TabIndex = 7;
            this.btnGenerateSign.Text = "Generate Signature ";
            this.btnGenerateSign.UseVisualStyleBackColor = true;
            // 
            // btnVerifySign
            // 
            this.btnVerifySign.Location = new System.Drawing.Point(704, 326);
            this.btnVerifySign.Name = "btnVerifySign";
            this.btnVerifySign.Size = new System.Drawing.Size(134, 40);
            this.btnVerifySign.TabIndex = 8;
            this.btnVerifySign.Text = "Verify Signature";
            this.btnVerifySign.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.btnVerifySign);
            this.Controls.Add(this.btnGenerateSign);
            this.Controls.Add(this.txtSignature);
            this.Controls.Add(this.txtBaseString);
            this.Controls.Add(this.cboRsaSHAkey);
            this.Controls.Add(this.btnPublicKey);
            this.Controls.Add(this.txtPublicKeyLocation);
            this.Controls.Add(this.btnBrowsePrivateKey);
            this.Controls.Add(this.txtPrivateKeyLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Main_App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPrivateKeyLocation;
        private Button btnBrowsePrivateKey;
        private Button btnPublicKey;
        private TextBox txtPublicKeyLocation;
        private ComboBox cboRsaSHAkey;
        private TextBox txtBaseString;
        private TextBox txtSignature;
        private Button btnGenerateSign;
        private Button btnVerifySign;
    }
}