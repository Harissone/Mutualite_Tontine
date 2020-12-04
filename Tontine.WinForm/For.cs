using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tontine.WinForm
{
    public partial class For : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Mutualiter;Integrated Security=True");
        
        public For()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           try
            {
               
                testBindingSource.EndEdit();
                //this.testTableAdapter.Insert(textBox1.Text, textBox2.Text, pictureBox2.ImageLocation("D:\images\2TCORP\2TCORP.jpg"));
                MessageBox.Show
                   (
                      "Reussite"
                   );
            }
            catch
            {
                MessageBox.Show
                   (
                      "Echec"
                   );
            }

            
        }
        public bool inserts(String user, string password)
        {
            user = textBox1.Text.Trim();
            password = textBox2.Text.Trim();

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = " insert into test (nom, password) values ('"+user+", "+password+"')";
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
        public bool Login(String user, string password)
        {
            user = textBox1.Text.Trim();
            password = textBox2.Text.Trim();

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string query = " select * from test where [nom]= '" + user + "' and [password]= '" + password + "'";
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

        private void For_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mutualiterDataSet2.test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.mutualiterDataSet2.test);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (conn.State == ConnectionState.Closed)
                MessageBox.Show
                    (
                       "BD NOT CONNECTED"
                    );
            if (conn.State == ConnectionState.Open)
                MessageBox.Show
                   (
                      " CONNECTED"
                   );
            
        }
    }
}
