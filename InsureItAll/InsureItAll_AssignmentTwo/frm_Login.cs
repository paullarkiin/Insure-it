using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsureItAll_AssignmentTwo
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            this.ActiveControl = txtBoxUser; // set the cusor to appear in username field
            
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            
            // valiation for login
            if (txtBoxUser.Text == "admin" && txtBoxPass.Text == "password123" )
            {
                frm_AdminPanel frmA = new frm_AdminPanel();
                frmA.ShowDialog(); // opens the admin pannel if username and pass is correct
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Either your username or password is wrong, Please Check and try again!");
                txtBoxUser.Clear();
                txtBoxPass.Clear();
                txtBoxUser.Focus();
            }
        }
    }
}
