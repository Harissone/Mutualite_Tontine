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
    public partial class FrmMembre : Form
    {
        public FrmMembre()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMembre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mutualiterDataSet5.Membres' table. You can move, or remove it, as needed.
            this.membresTableAdapter.Fill(this.mutualiterDataSet5.Membres);

        }

        private void btnRegister_Click(object sender, EventArgs e, string sexe)
        {
            //sexe = txtSex.Text.Trim();
            membresBindingSource.EndEdit();
            this.membresTableAdapter.Insert(int.Parse(txtIdentifier.Text), txtFirstName.Text, txtLastName.Text, int.Parse(txtTelephone.Text), txtSex.Text, txtFonction.Text);
        }
    }
}
