﻿using System;
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
           
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            Form f = new FrmLogin();
            f.Show();
        }
    }
}
