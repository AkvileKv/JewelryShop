namespace OnlineShop
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.LogInGroupBox = new System.Windows.Forms.GroupBox();
            this.BackButton1 = new System.Windows.Forms.Button();
            this.LogInLogInButton = new System.Windows.Forms.Button();
            this.PasswordLogInTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLogInLabel = new System.Windows.Forms.Label();
            this.UserNameLogInTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLogInLabel = new System.Windows.Forms.Label();
            this.LogInPictureBox = new System.Windows.Forms.PictureBox();
            this.LogInGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogInPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInGroupBox
            // 
            this.LogInGroupBox.Controls.Add(this.BackButton1);
            this.LogInGroupBox.Controls.Add(this.LogInLogInButton);
            this.LogInGroupBox.Controls.Add(this.PasswordLogInTextBox);
            this.LogInGroupBox.Controls.Add(this.PasswordLogInLabel);
            this.LogInGroupBox.Controls.Add(this.UserNameLogInTextBox);
            this.LogInGroupBox.Controls.Add(this.UserNameLogInLabel);
            this.LogInGroupBox.Location = new System.Drawing.Point(12, 255);
            this.LogInGroupBox.Name = "LogInGroupBox";
            this.LogInGroupBox.Size = new System.Drawing.Size(246, 183);
            this.LogInGroupBox.TabIndex = 35;
            this.LogInGroupBox.TabStop = false;
            this.LogInGroupBox.Text = "Log In";
            // 
            // BackButton1
            // 
            this.BackButton1.Location = new System.Drawing.Point(6, 125);
            this.BackButton1.Name = "BackButton1";
            this.BackButton1.Size = new System.Drawing.Size(105, 23);
            this.BackButton1.TabIndex = 44;
            this.BackButton1.Text = "Back";
            this.BackButton1.UseVisualStyleBackColor = true;
            this.BackButton1.Click += new System.EventHandler(this.BackButton1_Click);
            // 
            // LogInLogInButton
            // 
            this.LogInLogInButton.Location = new System.Drawing.Point(135, 125);
            this.LogInLogInButton.Name = "LogInLogInButton";
            this.LogInLogInButton.Size = new System.Drawing.Size(105, 23);
            this.LogInLogInButton.TabIndex = 34;
            this.LogInLogInButton.Text = "Log In";
            this.LogInLogInButton.UseVisualStyleBackColor = true;
            this.LogInLogInButton.Click += new System.EventHandler(this.LogInLogInButton_Click);
            // 
            // PasswordLogInTextBox
            // 
            this.PasswordLogInTextBox.Location = new System.Drawing.Point(92, 73);
            this.PasswordLogInTextBox.Name = "PasswordLogInTextBox";
            this.PasswordLogInTextBox.Size = new System.Drawing.Size(135, 20);
            this.PasswordLogInTextBox.TabIndex = 43;
            // 
            // PasswordLogInLabel
            // 
            this.PasswordLogInLabel.AutoSize = true;
            this.PasswordLogInLabel.Location = new System.Drawing.Point(17, 76);
            this.PasswordLogInLabel.Name = "PasswordLogInLabel";
            this.PasswordLogInLabel.Size = new System.Drawing.Size(59, 13);
            this.PasswordLogInLabel.TabIndex = 37;
            this.PasswordLogInLabel.Text = "Password: ";
            // 
            // UserNameLogInTextBox
            // 
            this.UserNameLogInTextBox.Location = new System.Drawing.Point(92, 37);
            this.UserNameLogInTextBox.Name = "UserNameLogInTextBox";
            this.UserNameLogInTextBox.Size = new System.Drawing.Size(135, 20);
            this.UserNameLogInTextBox.TabIndex = 35;
            this.UserNameLogInTextBox.TextChanged += new System.EventHandler(this.UserNameLogInTextBox_TextChanged);
            // 
            // UserNameLogInLabel
            // 
            this.UserNameLogInLabel.AutoSize = true;
            this.UserNameLogInLabel.Location = new System.Drawing.Point(13, 40);
            this.UserNameLogInLabel.Name = "UserNameLogInLabel";
            this.UserNameLogInLabel.Size = new System.Drawing.Size(66, 13);
            this.UserNameLogInLabel.TabIndex = 34;
            this.UserNameLogInLabel.Text = "User Name: ";
            // 
            // LogInPictureBox
            // 
            this.LogInPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogInPictureBox.Image")));
            this.LogInPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogInPictureBox.Name = "LogInPictureBox";
            this.LogInPictureBox.Size = new System.Drawing.Size(246, 228);
            this.LogInPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogInPictureBox.TabIndex = 36;
            this.LogInPictureBox.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.LogInPictureBox);
            this.Controls.Add(this.LogInGroupBox);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.LogInGroupBox.ResumeLayout(false);
            this.LogInGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogInPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LogInGroupBox;
        private System.Windows.Forms.Button LogInLogInButton;
        private System.Windows.Forms.TextBox PasswordLogInTextBox;
        private System.Windows.Forms.Label PasswordLogInLabel;
        private System.Windows.Forms.TextBox UserNameLogInTextBox;
        private System.Windows.Forms.Label UserNameLogInLabel;
        private System.Windows.Forms.PictureBox LogInPictureBox;
        private System.Windows.Forms.Button BackButton1;
    }
}