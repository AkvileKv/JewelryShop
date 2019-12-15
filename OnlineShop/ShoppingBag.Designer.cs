namespace OnlineShop
{
    partial class ShoppingBagForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingBagForm));
            this.YourShoppinBagGroupBox = new System.Windows.Forms.GroupBox();
            this.ShoppingBagListBox = new System.Windows.Forms.ListBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.ConformButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SignUpPictureBox = new System.Windows.Forms.PictureBox();
            this.BackToItemListButton = new System.Windows.Forms.Button();
            this.YourShoppinBagGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // YourShoppinBagGroupBox
            // 
            this.YourShoppinBagGroupBox.Controls.Add(this.RemoveButton);
            this.YourShoppinBagGroupBox.Controls.Add(this.ConformButton);
            this.YourShoppinBagGroupBox.Controls.Add(this.TotalTextBox);
            this.YourShoppinBagGroupBox.Controls.Add(this.TotalLabel);
            this.YourShoppinBagGroupBox.Controls.Add(this.ShoppingBagListBox);
            this.YourShoppinBagGroupBox.Location = new System.Drawing.Point(12, 101);
            this.YourShoppinBagGroupBox.Name = "YourShoppinBagGroupBox";
            this.YourShoppinBagGroupBox.Size = new System.Drawing.Size(247, 315);
            this.YourShoppinBagGroupBox.TabIndex = 0;
            this.YourShoppinBagGroupBox.TabStop = false;
            this.YourShoppinBagGroupBox.Text = "Your Shopping Bag";
            // 
            // ShoppingBagListBox
            // 
            this.ShoppingBagListBox.FormattingEnabled = true;
            this.ShoppingBagListBox.Location = new System.Drawing.Point(6, 16);
            this.ShoppingBagListBox.Name = "ShoppingBagListBox";
            this.ShoppingBagListBox.Size = new System.Drawing.Size(235, 238);
            this.ShoppingBagListBox.TabIndex = 33;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(126, 263);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(37, 13);
            this.TotalLabel.TabIndex = 35;
            this.TotalLabel.Text = "Total: ";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(169, 260);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(72, 20);
            this.TotalTextBox.TabIndex = 36;
            // 
            // ConformButton
            // 
            this.ConformButton.Location = new System.Drawing.Point(136, 286);
            this.ConformButton.Name = "ConformButton";
            this.ConformButton.Size = new System.Drawing.Size(105, 23);
            this.ConformButton.TabIndex = 37;
            this.ConformButton.Text = "Confirm";
            this.ConformButton.UseVisualStyleBackColor = true;
            this.ConformButton.Click += new System.EventHandler(this.ConformButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(6, 286);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(105, 23);
            this.RemoveButton.TabIndex = 38;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // SignUpPictureBox
            // 
            this.SignUpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SignUpPictureBox.Image")));
            this.SignUpPictureBox.Location = new System.Drawing.Point(12, 12);
            this.SignUpPictureBox.Name = "SignUpPictureBox";
            this.SignUpPictureBox.Size = new System.Drawing.Size(246, 83);
            this.SignUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SignUpPictureBox.TabIndex = 36;
            this.SignUpPictureBox.TabStop = false;
            // 
            // BackToItemListButton
            // 
            this.BackToItemListButton.Location = new System.Drawing.Point(18, 422);
            this.BackToItemListButton.Name = "BackToItemListButton";
            this.BackToItemListButton.Size = new System.Drawing.Size(105, 23);
            this.BackToItemListButton.TabIndex = 39;
            this.BackToItemListButton.Text = "Continue Shopping";
            this.BackToItemListButton.UseVisualStyleBackColor = true;
            this.BackToItemListButton.Click += new System.EventHandler(this.BackToItemListButton_Click);
            // 
            // ShoppingBagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.BackToItemListButton);
            this.Controls.Add(this.SignUpPictureBox);
            this.Controls.Add(this.YourShoppinBagGroupBox);
            this.Name = "ShoppingBagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Bag";
            this.YourShoppinBagGroupBox.ResumeLayout(false);
            this.YourShoppinBagGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox YourShoppinBagGroupBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.ListBox ShoppingBagListBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ConformButton;
        private System.Windows.Forms.PictureBox SignUpPictureBox;
        private System.Windows.Forms.Button BackToItemListButton;
    }
}