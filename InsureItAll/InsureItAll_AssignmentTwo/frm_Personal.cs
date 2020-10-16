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
    public partial class frm_Personal : Form
    {
        Driver driverData = new Driver(); // new driver object
        List<Driver> DriverList = new List<Driver>();
        List<string> occupation = new List<string>();
        List<string> occPercentagePremium = new List<string>(); // save the values percentage values from occupation csv for calc.
       
        

        public frm_Personal()
        {
            InitializeComponent();

            
            this.ActiveControl = coBoxTitle;

            StreamReader reader = File.OpenText("JobList.csv");
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String[] values = line.Split(',');
                occupation.Add(values[0]);
                occPercentagePremium.Add(values[1]);
                coBoxOccup.Items.Add(values[0]);//add a occupation name to the ListBox
            }
            reader.Close(); //close the csv file


            //
            // when loaded will set please select in the combo boxs 
            //
            //
            coBoxTitle.SelectedIndex = 0;
            coBoxMarital.SelectedIndex = 0;
            coBoxEmp.SelectedIndex = 0;
            coBoxEmp.SelectedIndex = 0;
            coBoxOccup.SelectedIndex = 0;
        }
        

        private void getDriverData(Driver driver) // collects user data from the form
        {
            driver.Title = coBoxTitle.GetItemText(coBoxTitle.SelectedItem);
            driver.Forename = txtBoxFname.Text;
            driver.Surname = txtBoxSname.Text;
            driver.DOB = dateTimePickerDOB.Value;
            driver.Email = txtBoxPhone.Text;
            driver.Employment = coBoxEmp.GetItemText(coBoxEmp.SelectedItem);
            driver.Occupation = coBoxOccup.GetItemText(coBoxOccup.SelectedItem);
            driver.MaritalStatus = coBoxMarital.GetItemText(coBoxMarital.SelectedItem);
            driver.HouseNo = txtBoxHouseNo.Text;
            driver.Street = txtBoxAdStreet.Text;
            driver.Postcode = txtBoxPostcode.Text;
            driver.PhoneNo = txtBoxPhone.Text;

           
        }

        private void btn_CreateDPolicy_Click(object sender, EventArgs e)
        {
            
            double OccPercent = 0;
            if (coBoxEmp.SelectedIndex != 0 && coBoxOccup.SelectedIndex != 0) // stops the program crashing when employment and occ
            {
                int post = coBoxOccup.SelectedIndex;
                OccPercent = double.Parse(occPercentagePremium[post]); // finds the percentage from second col in CSV 
            }
            else
            {
                MessageBox.Show("Please fill Out All Fields");
                return;
            }
      

            // get information from method and passes it to driverData obj
            getDriverData(driverData);
            // addes the driverData obj to DriverList List
            DriverList.Add(driverData);

            Policy.Drivers.Add(driverData); // passes data to the class policy list 

           
            frm_Vehicle vehicleform = new frm_Vehicle(OccPercent); // sends Occ % 
            vehicleform.Show();
            this.Hide();
        }


       

        //
        // //  //  Validation Section Started  // // // // 
        // 

        private void TxtBoxFname_Validating(object sender, CancelEventArgs e)
        {

            Control controlX = (Control)sender;
            if (string.IsNullOrEmpty(controlX.Text))
            {
                MessageBox.Show("Required Data Field");
                e.Cancel = true;
            }
            


        }

        private void TxtBoxHouseNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CoBoxEmp_Leave(object sender, EventArgs e)
        {
            if (coBoxEmp.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select an Appropriate Option");
                coBoxEmp.Focus();

            }
        }

        private void CoBoxTitle_Leave(object sender, EventArgs e)
        {
            if (coBoxTitle.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select an Appropriate Option");
                coBoxTitle.Focus();
            }
        }
        private void CoBoxOccup_Leave(object sender, EventArgs e)
        {

            if (coBoxOccup.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Your Occupation");
                coBoxOccup.Focus();
            }
        }

        private void CoBoxMarital_Leave(object sender, EventArgs e)
        {

            if (coBoxMarital.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select an Appropriate Option");
                coBoxMarital.Focus();
            }
        }

        private void TxtBoxAdStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxSname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

           if(txtBoxPhone.Text.Length < 7)
            {
                txtBoxPhone.BackColor = Color.Red;
            }
           else if(txtBoxPhone.Text.Length > 7)
            {
                txtBoxPhone.BackColor = Color.Green;
            }
        }

        private void CoBoxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxEmp.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select an Appropriate Option");
                coBoxEmp.Focus();
            }
        }

        private void DateTimePickerDOB_Leave(object sender, EventArgs e)
        {
            DateTime DTPicker = dateTimePickerDOB.Value;
            DateTime DT = DateTime.Today;
            if (DTPicker >= DT)
            {
                MessageBox.Show("Error: Birthdate Incorrect, Please select appropriate date of birth");
                dateTimePickerDOB.Focus();
            }
        }

        // only cancels if placed after Val.. Rules
        private void btn_Exit_Click(object sender, EventArgs e) // exits
        {
            btn_Exit.CausesValidation = false;
            AutoValidate = AutoValidate.Disable;
            Close();

            Application.Exit();
        }

    }
}

