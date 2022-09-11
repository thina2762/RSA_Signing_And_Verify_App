namespace RSA_Signing_And_Verify_App
{
    partial class Form1
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
            this.cboRSASHA = new System.Windows.Forms.ComboBox();
            this.btnVerifySign = new System.Windows.Forms.Button();
            this.btnGenerateSign = new System.Windows.Forms.Button();
            this.strSignature = new System.Windows.Forms.TextBox();
            this.btnBrowsePublicKey = new System.Windows.Forms.Button();
            this.strPublicKeyLocation = new System.Windows.Forms.TextBox();
            this.btnBrowsePrivateKey = new System.Windows.Forms.Button();
            this.strPrivateKeyLocation = new System.Windows.Forms.TextBox();
            this.strSignatureBaseString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboRSASHA
            // 
            this.cboRSASHA.FormattingEnabled = true;
            this.cboRSASHA.Location = new System.Drawing.Point(676, 77);
            this.cboRSASHA.Name = "cboRSASHA";
            this.cboRSASHA.Size = new System.Drawing.Size(121, 23);
            this.cboRSASHA.TabIndex = 17;
            // 
            // btnVerifySign
            // 
            this.btnVerifySign.Location = new System.Drawing.Point(663, 310);
            this.btnVerifySign.Name = "btnVerifySign";
            this.btnVerifySign.Size = new System.Drawing.Size(134, 38);
            this.btnVerifySign.TabIndex = 16;
            this.btnVerifySign.Text = "Verify Signature";
            this.btnVerifySign.UseVisualStyleBackColor = true;
            // 
            // btnGenerateSign
            // 
            this.btnGenerateSign.Location = new System.Drawing.Point(663, 180);
            this.btnGenerateSign.Name = "btnGenerateSign";
            this.btnGenerateSign.Size = new System.Drawing.Size(134, 43);
            this.btnGenerateSign.TabIndex = 15;
            this.btnGenerateSign.Text = "Generate Signature";
            this.btnGenerateSign.UseVisualStyleBackColor = true;
            // 
            // strSignature
            // 
            this.strSignature.Location = new System.Drawing.Point(4, 288);
            this.strSignature.Multiline = true;
            this.strSignature.Name = "strSignature";
            this.strSignature.Size = new System.Drawing.Size(619, 86);
            this.strSignature.TabIndex = 14;
            this.strSignature.Text = "Place Your Signature Here(If any)";
            // 
            // btnBrowsePublicKey
            // 
            this.btnBrowsePublicKey.Location = new System.Drawing.Point(507, 118);
            this.btnBrowsePublicKey.Name = "btnBrowsePublicKey";
            this.btnBrowsePublicKey.Size = new System.Drawing.Size(116, 23);
            this.btnBrowsePublicKey.TabIndex = 13;
            this.btnBrowsePublicKey.Text = "Browse Public Key";
            this.btnBrowsePublicKey.UseVisualStyleBackColor = true;
            // 
            // strPublicKeyLocation
            // 
            this.strPublicKeyLocation.Enabled = false;
            this.strPublicKeyLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.strPublicKeyLocation.Location = new System.Drawing.Point(4, 118);
            this.strPublicKeyLocation.Name = "strPublicKeyLocation";
            this.strPublicKeyLocation.Size = new System.Drawing.Size(465, 23);
            this.strPublicKeyLocation.TabIndex = 12;
            this.strPublicKeyLocation.Text = "Public Key Location";
            // 
            // btnBrowsePrivateKey
            // 
            this.btnBrowsePrivateKey.Location = new System.Drawing.Point(507, 77);
            this.btnBrowsePrivateKey.Name = "btnBrowsePrivateKey";
            this.btnBrowsePrivateKey.Size = new System.Drawing.Size(116, 23);
            this.btnBrowsePrivateKey.TabIndex = 11;
            this.btnBrowsePrivateKey.Text = "Browse Private Key";
            this.btnBrowsePrivateKey.UseVisualStyleBackColor = true;
            // 
            // strPrivateKeyLocation
            // 
            this.strPrivateKeyLocation.Enabled = false;
            this.strPrivateKeyLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.strPrivateKeyLocation.Location = new System.Drawing.Point(4, 77);
            this.strPrivateKeyLocation.Name = "strPrivateKeyLocation";
            this.strPrivateKeyLocation.Size = new System.Drawing.Size(465, 23);
            this.strPrivateKeyLocation.TabIndex = 10;
            this.strPrivateKeyLocation.Text = "Private Key Location";
            // 
            // strSignatureBaseString
            // 
            this.strSignatureBaseString.Location = new System.Drawing.Point(4, 167);
            this.strSignatureBaseString.Multiline = true;
            this.strSignatureBaseString.Name = "strSignatureBaseString";
            this.strSignatureBaseString.Size = new System.Drawing.Size(619, 82);
            this.strSignatureBaseString.TabIndex = 9;
            this.strSignatureBaseString.Text = "Place Your  Base String Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboRSASHA);
            this.Controls.Add(this.btnVerifySign);
            this.Controls.Add(this.btnGenerateSign);
            this.Controls.Add(this.strSignature);
            this.Controls.Add(this.btnBrowsePublicKey);
            this.Controls.Add(this.strPublicKeyLocation);
            this.Controls.Add(this.btnBrowsePrivateKey);
            this.Controls.Add(this.strPrivateKeyLocation);
            this.Controls.Add(this.strSignatureBaseString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboRSASHA;
        private Button btnVerifySign;
        private Button btnGenerateSign;
        private TextBox strSignature;
        private Button btnBrowsePublicKey;
        private TextBox strPublicKeyLocation;
        private Button btnBrowsePrivateKey;
        private TextBox strPrivateKeyLocation;
        private TextBox strSignatureBaseString;
    }
}