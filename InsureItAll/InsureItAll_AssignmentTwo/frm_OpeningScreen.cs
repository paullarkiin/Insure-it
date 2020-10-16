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
    public partial class frm_OpeningScreen : Form
    {
       
        public frm_OpeningScreen()
        {
            InitializeComponent();
            
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 718)
            {
                timer1.Stop();
                frm_WelcomeScreen fws = new frm_WelcomeScreen();
                fws.Show();
                this.Hide();
            }
        }
    }
}
