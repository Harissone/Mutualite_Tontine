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
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
            progressBar1.Visible = false;
           
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(25);
            if(progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form f = new FrmLogin();
                f.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
