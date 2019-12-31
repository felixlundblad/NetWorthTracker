namespace NetWorthTracker
{
    partial class FormAddAccount
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(140, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.BackColor = System.Drawing.Color.Transparent;
            this.labelAccountName.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAccountName.Location = new System.Drawing.Point(47, 38);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(87, 20);
            this.labelAccountName.TabIndex = 1;
            this.labelAccountName.Text = "Account Name: ";
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAccount.FlatAppearance.BorderSize = 0;
            this.buttonAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAccount.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddAccount.Location = new System.Drawing.Point(401, 35);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(80, 23);
            this.buttonAddAccount.TabIndex = 2;
            this.buttonAddAccount.Text = "Add Account";
            this.buttonAddAccount.UseVisualStyleBackColor = true;
            this.buttonAddAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(534, 608);
            this.Controls.Add(this.buttonAddAccount);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddAccount";
            this.Text = "FormAddAccount";
            this.Load += new System.EventHandler(this.FormAddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.Button buttonAddAccount;
    }
}