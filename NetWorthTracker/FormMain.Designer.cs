namespace NetWorthTracker
{
    partial class FormMain
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelImportData = new System.Windows.Forms.Panel();
            this.buttonImportCSV = new System.Windows.Forms.Button();
            this.buttonImportData = new System.Windows.Forms.Button();
            this.panelInsertData = new System.Windows.Forms.Panel();
            this.buttonAddDatapoint = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.buttonInsertData = new System.Windows.Forms.Button();
            this.buttonMainDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelImportData.SuspendLayout();
            this.panelInsertData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panelSideMenu.Controls.Add(this.buttonQuit);
            this.panelSideMenu.Controls.Add(this.buttonSettings);
            this.panelSideMenu.Controls.Add(this.panelImportData);
            this.panelSideMenu.Controls.Add(this.buttonImportData);
            this.panelSideMenu.Controls.Add(this.panelInsertData);
            this.panelSideMenu.Controls.Add(this.buttonInsertData);
            this.panelSideMenu.Controls.Add(this.buttonMainDashboard);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 647);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonQuit.Location = new System.Drawing.Point(0, 380);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonQuit.Size = new System.Drawing.Size(250, 40);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSettings.Location = new System.Drawing.Point(0, 340);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(250, 40);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // panelImportData
            // 
            this.panelImportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panelImportData.Controls.Add(this.buttonImportCSV);
            this.panelImportData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImportData.Location = new System.Drawing.Point(0, 300);
            this.panelImportData.Name = "panelImportData";
            this.panelImportData.Size = new System.Drawing.Size(250, 40);
            this.panelImportData.TabIndex = 5;
            // 
            // buttonImportCSV
            // 
            this.buttonImportCSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonImportCSV.FlatAppearance.BorderSize = 0;
            this.buttonImportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportCSV.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportCSV.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonImportCSV.Location = new System.Drawing.Point(0, 0);
            this.buttonImportCSV.Name = "buttonImportCSV";
            this.buttonImportCSV.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonImportCSV.Size = new System.Drawing.Size(250, 40);
            this.buttonImportCSV.TabIndex = 3;
            this.buttonImportCSV.Text = "Import CSV";
            this.buttonImportCSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImportCSV.UseVisualStyleBackColor = true;
            // 
            // buttonImportData
            // 
            this.buttonImportData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonImportData.FlatAppearance.BorderSize = 0;
            this.buttonImportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportData.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportData.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonImportData.Location = new System.Drawing.Point(0, 260);
            this.buttonImportData.Name = "buttonImportData";
            this.buttonImportData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonImportData.Size = new System.Drawing.Size(250, 40);
            this.buttonImportData.TabIndex = 4;
            this.buttonImportData.Text = "Import Data";
            this.buttonImportData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonImportData.UseVisualStyleBackColor = true;
            this.buttonImportData.Click += new System.EventHandler(this.buttonImportData_Click);
            // 
            // panelInsertData
            // 
            this.panelInsertData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panelInsertData.Controls.Add(this.buttonAddDatapoint);
            this.panelInsertData.Controls.Add(this.buttonAddAccount);
            this.panelInsertData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInsertData.Location = new System.Drawing.Point(0, 180);
            this.panelInsertData.Name = "panelInsertData";
            this.panelInsertData.Size = new System.Drawing.Size(250, 80);
            this.panelInsertData.TabIndex = 3;
            // 
            // buttonAddDatapoint
            // 
            this.buttonAddDatapoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddDatapoint.FlatAppearance.BorderSize = 0;
            this.buttonAddDatapoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDatapoint.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDatapoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddDatapoint.Location = new System.Drawing.Point(0, 40);
            this.buttonAddDatapoint.Name = "buttonAddDatapoint";
            this.buttonAddDatapoint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAddDatapoint.Size = new System.Drawing.Size(250, 40);
            this.buttonAddDatapoint.TabIndex = 2;
            this.buttonAddDatapoint.Text = "Add Datapoint";
            this.buttonAddDatapoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddDatapoint.UseVisualStyleBackColor = true;
            this.buttonAddDatapoint.Click += new System.EventHandler(this.buttonAddDatapoint_Click);
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddAccount.FlatAppearance.BorderSize = 0;
            this.buttonAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAccount.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddAccount.Location = new System.Drawing.Point(0, 0);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAddAccount.Size = new System.Drawing.Size(250, 40);
            this.buttonAddAccount.TabIndex = 0;
            this.buttonAddAccount.Text = "Add Account";
            this.buttonAddAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddAccount.UseVisualStyleBackColor = true;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // buttonInsertData
            // 
            this.buttonInsertData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInsertData.FlatAppearance.BorderSize = 0;
            this.buttonInsertData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertData.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertData.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonInsertData.Location = new System.Drawing.Point(0, 140);
            this.buttonInsertData.Name = "buttonInsertData";
            this.buttonInsertData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonInsertData.Size = new System.Drawing.Size(250, 40);
            this.buttonInsertData.TabIndex = 2;
            this.buttonInsertData.Text = "Insert Data";
            this.buttonInsertData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInsertData.UseVisualStyleBackColor = true;
            this.buttonInsertData.Click += new System.EventHandler(this.buttonInsertData_Click);
            // 
            // buttonMainDashboard
            // 
            this.buttonMainDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMainDashboard.FlatAppearance.BorderSize = 0;
            this.buttonMainDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainDashboard.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMainDashboard.Location = new System.Drawing.Point(0, 100);
            this.buttonMainDashboard.Name = "buttonMainDashboard";
            this.buttonMainDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMainDashboard.Size = new System.Drawing.Size(250, 40);
            this.buttonMainDashboard.TabIndex = 1;
            this.buttonMainDashboard.Text = "Main Dashboard";
            this.buttonMainDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMainDashboard.UseVisualStyleBackColor = true;
            this.buttonMainDashboard.Click += new System.EventHandler(this.buttonMainDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(550, 647);
            this.panelChildForm.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelImportData.ResumeLayout(false);
            this.panelInsertData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button buttonMainDashboard;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelImportData;
        private System.Windows.Forms.Button buttonImportCSV;
        private System.Windows.Forms.Button buttonImportData;
        private System.Windows.Forms.Panel panelInsertData;
        private System.Windows.Forms.Button buttonAddDatapoint;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Button buttonInsertData;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonQuit;
    }
}

