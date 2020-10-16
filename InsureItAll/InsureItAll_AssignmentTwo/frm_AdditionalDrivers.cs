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
    public partial class frm_AdditionalDrivers : Form
    {
        // new instance of claims 
        Claims policyClaims = new Claims(); // new instance of claims class
        List<string> occupation = new List<string>();
        Driver addNewDriver = new Driver();

        public frm_AdditionalDrivers()
        {
            InitializeComponent();

            StreamReader reader = File.OpenText("JobList.csv");
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String[] values = line.Split(',');
                occupation.Add(values[0]);
                coBoxAdditionalOccup.Items.Add(values[0]);//add a season name to the ListBox
            }
            reader.Close(); //close the csv file

            //sets the comboboxs on the form to Please Select 
            coBoxAddPastClaims.SelectedIndex = 0;
            coBoxAdditionalOccup.SelectedIndex = 0;
            coBoxAdditionalTitle.SelectedIndex = 4;
            coBoxRelation.SelectedIndex = 4;
            coBoxAdditonalEmp.SelectedIndex = 6;
        }

       
        private void getAdDriverData(Driver driver) // collects all form data
        {
            driver.Title = coBoxAdditionalTitle.GetItemText(coBoxAdditionalTitle.SelectedItem);
            driver.Forename = txtBoxAdditionalFname.Text;
            driver.Surname = txtBoxAdditionalSname.Text;
            driver.DOB = dateTimePickerAddDOB.Value;
            driver.Employment = coBoxAdditonalEmp.GetItemText(coBoxAdditonalEmp.SelectedItem);
            driver.Occupation = coBoxAdditionalOccup.GetItemText(coBoxAdditionalOccup.SelectedItem);
            driver.Relationship = coBoxRelation.GetItemText(coBoxRelation.SelectedItem);
            
        }

        private void getClaimsData(Claims claims) // claim method for gathering obj data and to reduce code 
        {
            policyClaims.DateClaim = dTPickerAddClaimsDate.Value;
            policyClaims.ClaimAmount = double.Parse(txtBoxAddClaimsAmount.Text);
        }

        private void btn_AddAnotherDriver_Click(object sender, EventArgs e)
        {   // clear form
            getAdDriverData(addNewDriver); // get the data from form
            Policy.Drivers.Add(addNewDriver); // adds it to policy class array
            int countIndexs = Policy.Drivers.Count(); // checking the amount of driver obj's in the policy.Driver array

            if (countIndexs > 5)
            {
                MessageBox.Show("You can only have a maximum of 5 drivers on your policy");
                btn_AddAnotherDriver.Enabled = false; // stop the user from creating another obj if there already five in the array
            }
            
            // clears the form
            txtBoxAdditionalFname.Text = "";
            txtBoxAdditionalSname.Text = "";
            coBoxAdditionalOccup.SelectedIndex = -1;
            coBoxAdditonalEmp.SelectedIndex = -1;
            coBoxRelation.SelectedIndex = -1;
            coBoxAdditionalTitle.SelectedIndex = -1;

        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            //past claim validation
           
            if (coBoxAddPastClaims.SelectedIndex == 1 && txtBoxAddClaimsAmount.Text != "")
            {
                getClaimsData(policyClaims);
                Claims.Claim.Add(policyClaims);

            }
            else if (coBoxAddPastClaims.SelectedIndex == 2)
            {
                //continue
            }
            else
            {
                MessageBox.Show("Please Enter an Appropriate Claim information ");
                return;
            }

            // append data to driver and exit
            getAdDriverData(addNewDriver);
            Policy.Drivers.Add(addNewDriver);
            this.Close();

        }
        private void Btn_AddDriversClaims_Click(object sender, EventArgs e)
        {
            getClaimsData(policyClaims);
            Claims.Claim.Add(policyClaims);

            int eachDriverClaims = Claims.Claim.Count();
            foreach (Driver driver in Policy.Drivers)
            {
                driver.NumberOfClaims = eachDriverClaims;
            }


            txtBoxAddClaimsAmount.Text = "";
            dTPickerAddClaimsDate.ResetText();
        }

        //
        // //  //  Validation  Section Starts // // // // 
        // 
      

        private void TxtBoxAdditionalFname_Validating(object sender, CancelEventArgs e)
        {
            Control controlX = (Control)sender;
            if (string.IsNullOrEmpty(controlX.Text))
            {
                MessageBox.Show("Required Data Field");
                e.Cancel = true;
            }
        }

        private void Frm_AdditionalDrivers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CoBoxRelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxRelation.SelectedIndex == 0)
            {
                txtBoxRelationOther.Visible = true;
                label6.Visible = true;
            }
            else if (coBoxRelation.SelectedIndex > 0)
            {
                txtBoxRelationOther.Visible = false;
                label6.Visible = false;
            }
        }

        private void coBoxAdditionalTitle_Leave(object sender, EventArgs e)
        {
            if(coBoxAdditionalTitle.SelectedIndex == 4)
            {
                MessageBox.Show("Please Select an Appropriate Option");
                coBoxAdditionalTitle.Focus();
            }

        }

        private void coBoxRelation_Leave(object sender, EventArgs e)
        {
            if (coBoxRelation.SelectedIndex == 4)
            {
                MessageBox.Show("Please Select an Appropriate Option");
                coBoxRelation.Focus();
            }
        }

        private void coBoxAdditionalOccup_Leave(object sender, EventArgs e)
        {
            if (coBoxAdditionalOccup.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Your Occupation");
                coBoxAdditionalOccup.Focus();
            }
        }

        private void coBoxAdditonalEmp_Leave(object sender, EventArgs e)
        {
            if (coBoxAdditonalEmp.SelectedIndex == 6)
            {
                MessageBox.Show("Please Select Your Employment Status");
                coBoxAdditonalEmp.Focus();
            }
        }

        private void CoBoxAddPastClaims_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxAddPastClaims.SelectedIndex == 1)
            {
                txtBoxAddClaimsAmount.Visible = true;
                dTPickerAddClaimsDate.Visible = true;
                label8.Visible = true;
                label10.Visible = true;
                btn_AddDriversClaims.Visible = true;
            }

            else if (coBoxAddPastClaims.SelectedIndex != 1)
            {
                txtBoxAddClaimsAmount.Visible = false;
                dTPickerAddClaimsDate.Visible = false;
                label8.Visible = false;
                label10.Visible = false;
                btn_AddDriversClaims.Visible = false;
            }

        }

        private void TxtBoxAddClaimsAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DateTimePickerAddDOB_Leave(object sender, EventArgs e)
        {

            DateTime DTPicker = dateTimePickerAddDOB.Value;
            DateTime DT = DateTime.Today;
            if (DTPicker >= DT)
            {
                MessageBox.Show("Error: Birthdate Incorrect, Please select appropriate date of birth");
                dateTimePickerAddDOB.Focus();
            }
        }
    }
}
