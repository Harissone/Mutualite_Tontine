using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tontine.BO;

namespace Tontine.WinForm
{
    public partial class FrmSignUp : Form
    {
       // private List<User> users;
        public FrmSignUp()
        {
            InitializeComponent();
           // users = new List<User>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {

                    MessageBox.Show(
                    "Please confirm your password",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                }
                else
                {
                    do
                    {
                        userBindingSource.EndEdit();
                        this.userTableAdapter.Insert(txtUsername.Text, txtPassword.Text, txtConfirmPassword.Text);
                    }
                    while (txtPassword.Text == txtConfirmPassword.Text);

                    MessageBox.Show(
                   "Your account has been created successfully",
                   "Confirmation",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                    Form f = new FrmParent();
                    f.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show
                (
                        "Account already exists !",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                );
            }
            
           /* User user = new User
            (
                txtUsername.Text,
                txtPassword.Text,
                txtConfirmPassword.Text
            );
            foreach(User u in users)
            {
                if(user.Username.Equals(u.Username))
                {
                    MessageBox.Show
                    (
                        "Username already exists !",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
            users.Add(user);*/

            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtUsername.Focus();      
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'mutualiterDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.mutualiterDataSet.User);

        }
    }
}
