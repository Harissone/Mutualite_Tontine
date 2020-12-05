using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tontine.WinForm
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelMettingMenu.Visible = false;
            panelEventMenu.Visible = false;
            panelSettingMenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelEventMenu.Visible == true)
                panelEventMenu.Visible = false;
            if (panelMettingMenu.Visible == true)
                panelMettingMenu.Visible = false;
            if (panelSettingMenu.Visible == true)
                panelSettingMenu.Visible = false;
        }


        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMetting_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMettingMenu);
        }

        private void btnCreateMetting_Click(object sender, EventArgs e)
        {
            //..
            //Our code
            //..
            Form f = new FrmMetting();
            f.Show();
            hideSubMenu();
        }

        private void btnCreateMetting_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmMetting());   
            hideSubMenu();
        }

        private void btnInfoMetting_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmInfoMeettings());
            hideSubMenu();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEvent());
           
            hideSubMenu();
        }

        private void btnInfosEvent_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAppSetting_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAboutApp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEventMenu);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSettingMenu);
        }
        

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
