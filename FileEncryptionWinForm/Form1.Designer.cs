namespace FileEncryptionWinForm
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
            this.buttonEncryption = new System.Windows.Forms.Button();
            this.progressBarEcryption = new System.Windows.Forms.ProgressBar();
            this.currentProgressLabel = new System.Windows.Forms.Label();
            this.EncryptionInfoLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEncryption
            // 
            this.buttonEncryption.Location = new System.Drawing.Point(107, 46);
            this.buttonEncryption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEncryption.Name = "buttonEncryption";
            this.buttonEncryption.Size = new System.Drawing.Size(220, 33);
            this.buttonEncryption.TabIndex = 0;
            this.buttonEncryption.Text = "Шифрування / Дешифрування";
            this.buttonEncryption.UseVisualStyleBackColor = true;
            this.buttonEncryption.Click += new System.EventHandler(this.buttonEncryption_Click);
            // 
            // progressBarEcryption
            // 
            this.progressBarEcryption.Location = new System.Drawing.Point(67, 184);
            this.progressBarEcryption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarEcryption.Name = "progressBarEcryption";
            this.progressBarEcryption.Size = new System.Drawing.Size(298, 18);
            this.progressBarEcryption.TabIndex = 2;
            this.progressBarEcryption.Visible = false;
            // 
            // currentProgressLabel
            // 
            this.currentProgressLabel.AutoSize = true;
            this.currentProgressLabel.Location = new System.Drawing.Point(67, 160);
            this.currentProgressLabel.Name = "currentProgressLabel";
            this.currentProgressLabel.Size = new System.Drawing.Size(0, 15);
            this.currentProgressLabel.TabIndex = 3;
            // 
            // EncryptionInfoLabel
            // 
            this.EncryptionInfoLabel.AutoSize = true;
            this.EncryptionInfoLabel.Location = new System.Drawing.Point(67, 217);
            this.EncryptionInfoLabel.Name = "EncryptionInfoLabel";
            this.EncryptionInfoLabel.Size = new System.Drawing.Size(0, 15);
            this.EncryptionInfoLabel.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(71, 100);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(52, 15);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(71, 118);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(302, 23);
            this.passwordTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 252);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EncryptionInfoLabel);
            this.Controls.Add(this.currentProgressLabel);
            this.Controls.Add(this.progressBarEcryption);
            this.Controls.Add(this.buttonEncryption);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncryption;
        private System.Windows.Forms.Label currentProgressLabel;
        public System.Windows.Forms.ProgressBar progressBarEcryption;
        private System.Windows.Forms.Label EncryptionInfoLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}
