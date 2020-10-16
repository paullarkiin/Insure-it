using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InsureItAll_AssignmentTwo
{
    public partial class frm_AdminPanel : Form
    {
        public frm_AdminPanel()
        {
            InitializeComponent();
        }

        private void Btn_ShowPolicies_Click(object sender, EventArgs e)
        {
            txtDispPolicies.Clear();

            //get date and convert to string format
            string date = dateTimePickerPolicy.Value.ToString("dd-MM-yyyy");
            string lineOne, lineTwo;

            try
            {
                // Stream reader that opens a csv file with the date selected by user
                StreamReader reader = File.OpenText("FollowUp_policies_" + date + ".csv");

                //add headings to the textBox
                txtDispPolicies.AppendText("PolicyNumber\t\t FollowUp\t\t DOB\t\t Name\t\t Car\t\t Storage\t\t Useage " + "\r\n");

                // While loop to load data from csv into an array and remove the commas 
                while (!reader.EndOfStream)
                {
                    lineOne = reader.ReadLine();//read line of data from csv file
                    lineTwo = ""; //initialise an empty string which will hold the line of data TO BE OUTPUT on the form

                    string[] stringvalues = lineOne.Split(',');//array holds each item from the current row in csv file


                    foreach (string strings in stringvalues)
                    {
                        //use the array data to create one string with spacing between each value
                        lineTwo = lineTwo +strings + "\t\t\t\t";
                    }
                    // Displaying the row from csv file in a new line in the textBox
                    txtDispPolicies.AppendText(lineOne + "\r\n" + "\r\n");
                }
                reader.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No policies processed on that day!");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
