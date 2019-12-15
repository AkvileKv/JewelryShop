namespace OnlineShop
{
    partial class Form1iJewelryShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1iJewelryShop));
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SignUpPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(12, 317);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(105, 23);
            this.SignUpButton.TabIndex = 31;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(153, 317);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(105, 23);
            this.LogInButton.TabIndex = 32;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // SignUpPictureBox
            // 
            this.SignUpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SignUpPictureBox.Image")));
            this.SignUpPictureBox.Location = new System.Drawing.Point(12, 12);
            this.SignUpPictureBox.Name = "SignUpPictureBox";
            this.SignUpPictureBox.Size = new System.Drawing.Size(246, 290);
            this.SignUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SignUpPictureBox.TabIndex = 36;
            this.SignUpPictureBox.TabStop = false;
            // 
            // Form1iJewelryShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.SignUpPictureBox);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.SignUpButton);
            this.Name = "Form1iJewelryShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iJewelry Shop";
            ((System.ComponentModel.ISupportInitialize)(this.SignUpPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.PictureBox SignUpPictureBox;
    }
}

