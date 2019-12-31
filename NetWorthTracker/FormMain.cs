using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetWorthTracker
{
    public partial class FormMain : Form
    {
        #region Attributes
        private Form activeForm = null;
        #endregion

        public FormMain()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            hideSubMenu();
        }

        #region Common helper methods
        private void hideSubMenu()
        {
            panelImportData.Visible = false;
            panelInsertData.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else hideSubMenu();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Side panel buttons

        #region Main Dashboard button
        private void buttonMainDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
        }
        #endregion

        #region Insert Data buttons
        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInsertData);
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddAccount());
        }

        private void buttonAddDatapoint_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAddDatapoint());
        }
        #endregion

        #region Import Data buttons
        private void buttonImportData_Click(object sender, EventArgs e)
        {
            showSubMenu(panelImportData);
        }
        #endregion

        #region Quit button
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #endregion

        #region Redundant
        private void Form1_Load(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        #endregion
    }
}
