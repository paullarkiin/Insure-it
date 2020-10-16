using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InsureItAll_AssignmentTwo
{
    public partial class frm_WelcomeScreen : Form
    {
        public frm_WelcomeScreen()
        {
            
            InitializeComponent();
           
        }
       

        private void Btn_Quote_Click(object sender, EventArgs e) // opens driver details form
        {
            frm_Personal fp3 = new frm_Personal();
            fp3.Show(); // shows and hides previous form
            this.Hide();
        }

        private void btn_Admin_Click_1(object sender, EventArgs e) // open loign form for pannel.
        {
            frm_Login fp2 = new frm_Login();
            fp2.ShowDialog(); // show previous screen + login

        }
    }
}
