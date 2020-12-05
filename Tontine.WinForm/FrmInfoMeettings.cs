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
    public partial class FrmInfoMeettings : Form
    {
        public FrmInfoMeettings()
        {
            InitializeComponent();
        }

        private void FrmInfoMeettings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mutualiterDataSet3.Reunion' table. You can move, or remove it, as needed.
            this.reunionTableAdapter.Fill(this.mutualiterDataSet3.Reunion);


        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Form f = new FrmMetting();
            f.Show();
            this.Hide();
        }

        private void btnEditMeeting_Click(object sender, EventArgs e)
        {
            reunionBindingSource.EndEdit();
            this.reunionTableAdapter.Update(dataGridView1.);
        }
    }
}
