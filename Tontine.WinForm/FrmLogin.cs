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
    public partial class FrmLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Mutualiter;Integrated Security=True");
        public FrmLogin()
        {
            InitializeComponent();
           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form f = new FrmSignUp();
            f.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var logi = Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if(logi == true)
            {
                Form f = new FrmParent();
                f.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show
               (
                       "Account is not exists !",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
               );
                txtUsername.Clear();
                txtPassword.Clear();
                this.Hide();
            }                     
        }
        public bool Login(string user, string password)
        {
            user = txtUsername.Text.Trim();
            password = txtPassword.Text.Trim();

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = " select * from [User] where [username]= '" + user + "' and [password]= '" + password + "'";
            SqlDataAdapter sdt = new SqlDataAdapter(query, conn);
            DataTable das = new DataTable();
            sdt.Fill(das);
            if (das.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mutualiterDataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.mutualiterDataSet1.User);

        }
    }
}
