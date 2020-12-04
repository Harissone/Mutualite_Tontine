using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tontine.WinForm
{
    public partial class FrmMetting : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Mutualiter;Integrated Security=True");
        public FrmMetting()
        {
            InitializeComponent();
        }
        public void inserts(int identifier, string nameMetting, int tauxContribution, int numberOfMember, string dates, string description)
        {
            identifier = int.Parse(txtIdentifier.Text.Trim());
            nameMetting = txtMetting.Text.Trim();
            tauxContribution = int.Parse(txtMinimumContribution.Text.Trim());
            numberOfMember = int.Parse(txtNbreMember.Text.Trim());
            dates = txtDate.Text.Trim();
            description = richTextBoxDescription.Text.Trim();

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = " insert into Reunion (id_reun, nom_reun, taux_col, nbre_mem, description, date_reun ) values ('" + identifier + "," + nameMetting + ", " + tauxContribution + "," + numberOfMember + ", " + dates + ", " + description + "')";
            /*SqlDataAdapter sdt = new SqlDataAdapter(query, conn);
            DataTable das = new DataTable();
            sdt.Fill(das);
            if (das.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }*/


        }

        private void FrmMetting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mutualiterDataSet3.Reunion' table. You can move, or remove it, as needed.
            this.reunionTableAdapter.Fill(this.mutualiterDataSet3.Reunion);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                reunionBindingSource.EndEdit();
                this.reunionTableAdapter.Insert(int.Parse(txtIdentifier.Text), txtMetting.Text, int.Parse(txtMinimumContribution.Text), int.Parse(txtNbreMember.Text), txtDate.Text, richTextBoxDescription.Text);
                MessageBox.Show
               (
                   "Metting has been create succesfully",
                   "Information",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
               );

                txtIdentifier.Clear();
                txtDate.Clear();
                txtMetting.Clear();
                txtMinimumContribution.Clear();
                txtNbreMember.Clear();
                richTextBoxDescription.Clear();
                txtIdentifier.Focus();
            }
            catch
            {
                MessageBox.Show
                (
                    "Identifier already exist",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            
        }
    }
}
