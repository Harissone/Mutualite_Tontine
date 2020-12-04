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
    public partial class FrmEvent : Form
    {
        public FrmEvent()
        {
            InitializeComponent();
        }

        private void FrmEvent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mutualiterDataSet4.Evenement' table. You can move, or remove it, as needed.
            this.evenementTableAdapter.Fill(this.mutualiterDataSet4.Evenement);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            evenementBindingSource.EndEdit();
            this.evenementTableAdapter.Insert(int.Parse(txtIdentifier.Text), txtEventName.Text, txtLocation.Text, txtContribution.Text, int.Parse(txtTotalContribution.Text), txtDateEvenement.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
