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
    public partial class frm_Vehicle : Form
    {
        Claims policyClaims = new Claims(); // new instance of claims class
        Policy carPolicy = new Policy(); // new instance of policy class    
        List<string> makeandmodel = new List<string>(); // imported csv
        List<string> mmPercentagePremium = new List<string>(); // save the values percentage values from car csv for calc.
        List<String> DriverInfoList = new List<String>(); // this save the added information from driver
        List<Policy> PoliciesProcessed = new List<Policy>();  
        DateTime ageOfDriver = new DateTime();
       

        double OccPercent;
        public frm_Vehicle(double OccPercent)
        {
            //limits the dates in the policy start date - date picker
            DateTimePicker dt = new DateTimePicker();
            dt.MinDate = DateTime.Today;

            InitializeComponent();

            this.OccPercent = OccPercent; // % passed in relation to driver occuplation 

            
            
            foreach (Driver driver in Policy.Drivers) // moving the driver obj from class level list to local list to access data.
            {

                
                DriverInfoList.Add(driver.Forename);
                DriverInfoList.Add(driver.Surname);
                DriverInfoList.Add(driver.Occupation);
                DriverInfoList.Add(driver.Employment);

                ageOfDriver = driver.DOB;

            }
          

            StreamReader reader = File.OpenText("CarInsuranceCategories4.csv"); // read in csv
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                String[] values = line.Split(',');
                makeandmodel.Add(values[0]);
                mmPercentagePremium.Add(values[1]);
                coBoxMM.Items.Add(values[0]);

            }
            reader.Close(); //close the csv file
            

           // setting "please select" in the required fields when loaded.
            coBoxVehUsage.SelectedIndex = 3;
            coBoxVehkept.SelectedIndex = 3;
            coBoxMM.SelectedIndex = 0;
            coBoxPastClaims.SelectedIndex = 0;
        }

        private void btn_NamedDrivers_Click(object sender, EventArgs e)
        {
            frm_AdditionalDrivers addDriver = new frm_AdditionalDrivers();
            addDriver.ShowDialog();

        }

        private void getVehData(Policy policy) // saving data to policy obj
        {

            policy.PolicyForename = DriverInfoList[0];
            policy.PolicySurname = DriverInfoList[1];
            policy.CarName = coBoxMM.GetItemText(coBoxMM.SelectedItem);
            policy.VehicleUsage = coBoxVehUsage.GetItemText(coBoxVehUsage.SelectedItem);
            policy.CarKept = coBoxVehkept.GetItemText(coBoxVehkept.SelectedItem);

        }

        private void getClaimsData(Claims claims) // claim method for gathering obj data and to reduce code 
        {
            policyClaims.DateClaim = dTPickerClaimsDate.Value;
            policyClaims.ClaimAmount = double.Parse(txtBoxClaimsAmount.Text);
        }


        private void premiumDeclined()
        {// method to check age of all drivers in the policy class array
          
            DateTime PdateTime = DTPicker_PStartDate.Value; // gets the start date from the form
            carPolicy.StartDate = PdateTime; // sets the date
            
            
            foreach (Driver driver in Policy.Drivers) // foreach for the age 
              {

                DateTime AgeCal = driver.DOB;
                int age = carPolicy.GetAge(AgeCal, carPolicy.StartDate);  // cal age

                if (age < 21) // checks age
                {
                    MessageBox.Show("Policy declined due to age of the Youngest Driver " + driver.Forename.ToString() + " " +driver.Surname.ToString()); // need to add name of the driver to cancel message
                    MessageBox.Show("A Member of staff will be in touch to discuss your policy options.");
                    carPolicy.AccRejection = "Declined_Held";
                    getVehData(carPolicy);
                    PoliciesProcessed.Add(carPolicy);
                    markedCSV();
                    Application.Exit();
                }
                else if (age > 75)
                {
                    MessageBox.Show("Policy declined due to age of the Oldest Driver " + driver.Forename.ToString() + " " + driver.Surname.ToString());
                    MessageBox.Show("A Member of staff will be in touch to discuss your policy options ");
                    carPolicy.AccRejection = "Declined_Held";
                    getVehData(carPolicy);
                    PoliciesProcessed.Add(carPolicy);
                    markedCSV();
                    Application.Exit();
                    
                }

                // Extended feature - Calc based on number of claims a specific user has entered.

                if (driver.NumberOfClaims > 2)
                {
                    MessageBox.Show("Policy declined - Driver has more than 2 claims " + driver.Forename.ToString() + " " + driver.Surname.ToString());
                    carPolicy.AccRejection = "Declined_claim_Held";

                    //Adding information to specific lists
                    getVehData(carPolicy);
                    PoliciesProcessed.Add(carPolicy);
                    markedCSV();
                    Application.Exit();

                }

            }// end of first foreach loop

            foreach (Claims claim in Claims.Claim) 
               {

                int claimNumber = Claims.Claim.Count(); // counts the number of claim date entries in the list

                if (claimNumber > 3) // if there are more than 3 entries in the list then cancel.
                {
                        MessageBox.Show("Policy Declined - Policy has more than 3 claims"); // shows the user the cancel message.
                        carPolicy.AccRejection = "Declined - More than three Claims"; // marks the policy as Declined
                        getVehData(carPolicy);  // gets the claim data from method
                        PoliciesProcessed.Add(carPolicy); // adds claim obj data to local list
                        markedCSV(); // calls the save information to csv method 
                        Application.Exit(); // exit without calculating policy premium  
                }
               }// end of forloop

        }

        private double calculatePrice()
        {

            //1. starting rate
            double perRate, cost;
            const double STARTRATE = 200.00; // always starts at 200.00
            int post = coBoxMM.SelectedIndex; // get selected index from form
            perRate = double.Parse(mmPercentagePremium[post]); // matches the index selcted with the % needed 


            double div = perRate / 100; // takes 19 makes it 0.19
            double divOcc = OccPercent / 100; // moves percent from 19 to 0.19 for calc.

            // 2. veh type Prem
            cost = STARTRATE * div + STARTRATE;

            // 3. VehKept
            if (coBoxVehkept.SelectedIndex == 0)
            {
                cost = cost * 0.10 + cost;
            }
            else if (coBoxVehkept.SelectedIndex == 1)
            {
                cost = cost * 0.05 + cost;
            }
            else if (coBoxVehkept.SelectedIndex == 2)
            {
                double discount = cost * 0.05;
                cost = cost - discount;
            }

            // 4. Occ Cost
            cost = cost * divOcc + cost;

            // 5. Usage

            if (coBoxVehUsage.SelectedIndex == 1)
            {
                cost = cost * 0.05 + cost;
            }
            else if (coBoxVehUsage.SelectedIndex == 2)
            {
                string extraMiles = txtBoxMiles.Text;
                double convert = Convert.ToDouble(extraMiles);

                double calMiles = convert / 1000;
                double milesCost = calMiles * 20;

                cost = cost + milesCost;
            }

            // 6. Age  + or - price

            foreach (Driver driver in Policy.Drivers)
            {

                DateTime AgeCal = driver.DOB;
                int age = carPolicy.GetAge(AgeCal, carPolicy.StartDate);

                if (age >= 21 && age <= 25)
                {
                    double increase = cost * 0.20;
                    cost = cost + increase;

                }
                else if (age >= 26 && age <= 75)
                {
                    double ageDiscount = cost * 0.10;
                    cost = cost - ageDiscount;
                }

            }

            // Extended - Claims Cals
           

            DateTime now = DateTime.Now; // gets todays date

            foreach (Claims claim in Claims.Claim) 
            {// for each claim in the 
                int calendar_years = now.Year - policyClaims.DateClaim.Year; // calculates the year from the two dates 

                if (calendar_years < 1 && policyClaims.ClaimAmount > 1000) // if the claim is under one year and over 1000 pound then increase by 20%
                {
                    cost = cost * 0.2 + cost;
                }
                else if (calendar_years >= 1 && calendar_years <= 5 && policyClaims.ClaimAmount > 1000)// if the claim is between a year and 5 years and over a 1000 pound then increase by 10%
                {
                    cost = cost * 0.1 + cost;
                }

            }// else any thing under 1000 dont increase, which doesnt need a calculation it.

            carPolicy.Premium = cost;
            return cost;
        }
        private void Btn_AddClaims_Click(object sender, EventArgs e)
        {

            getClaimsData(policyClaims);
            Claims.Claim.Add(policyClaims);

            int eachDriverClaims = Claims.Claim.Count();
            
            foreach (Driver driver in Policy.Drivers)
            {
                driver.NumberOfClaims = eachDriverClaims;
            }


            txtBoxClaimsAmount.Text = "";
            dTPickerClaimsDate.ResetText();

        }

        private void btn_Quote_Click(object sender, EventArgs e)
        {
            
            //past claim validation
            if (coBoxPastClaims.SelectedIndex == 1 && txtBoxClaimsAmount.Text != "")
            {
                getClaimsData(policyClaims);
                Claims.Claim.Add(policyClaims);

            }
            else if (coBoxPastClaims.SelectedIndex == 2)
            {
                //continue
            }
            else
            {
                MessageBox.Show("Please Enter an Appropriate Claim information ");
                return;
            }
        

            // checked age before calculating policy price
            premiumDeclined();
            policyNumber();
         

            // Make and model validation.
            if(coBoxMM.SelectedIndex == 0 && txtBoxMMOther.Text == "")
            {
                MessageBox.Show("Please enter car make and model");
            }

        

            string ModelManually = txtBoxMMOther.Text;
            foreach (Driver driver in Policy.Drivers)
            {
                if (driver.Occupation == "Self Employed")
                {
                    MessageBox.Show("Sorry, We currently can't process your policy. A Member of staff will be in touch to discuss your policy.");
                    carPolicy.AccRejection = "DISCUSS WITH CUSTOMER";
                    markedCSV();
                    Application.Exit();
                }
                
            }// end of for each loop

             if (ModelManually != "") // if any other jobs are entered output message and mark
                {
                    MessageBox.Show("Sorry, We currently can't process your policy. A Member of staff will be in touch to discuss your policy");
                    carPolicy.AccRejection = "DISCUSS WITH CUSTOMER";
                    markedCSV();
                    Application.Exit();
                }
            

            double cost = calculatePrice(); // call calc method
            MessageBox.Show("Thank You For Choosing Easy Car Insurance"+ "\nYour Premium is: " + cost.ToString("C2") + "\nYour Policy Number is: " + carPolicy.PolicyNum);

            // call information from form added to the obj and add it to the local policys array
            getVehData(carPolicy);
            PoliciesProcessed.Add(carPolicy);

        }
       
        private void Btn_ProcessPolicys_Click(object sender, EventArgs e)
        {// process all dailiy policys. 
         // only saves to csv when button is clicked at the end of the day.

            string date = DateTime.Today.ToString("dd-MM-yyyy"); //get today's date
            string filePath = "policies_" + date + ".csv";  //create a name of the new csv file which includes date

            string delimiter = ","; //comma needed to create new csv file

            StringBuilder pol = new StringBuilder();
            StringBuilder mdr = new StringBuilder();
            StringBuilder clms = new StringBuilder();

            foreach (Policy policies in PoliciesProcessed) 
            {
                pol.AppendLine(policies.PolicyNum + " " + delimiter + policies.PolicyForename + " " + delimiter + policies.PolicySurname + " " + delimiter + policies.StartDate + " " +
                    delimiter + policies.CarName + " " + delimiter + policies.CarKept + " " + delimiter + policies.VehicleUsage + " " + delimiter + policies.Premium + " ");//build up a String containing all the data in the List

            }

            foreach (Driver driver in Policy.Drivers)
            {
                mdr.AppendLine(delimiter + " " + driver.Relationship + " " + driver.Title + " " + delimiter + driver.Forename + " " + delimiter + driver.Surname + " " + delimiter + driver.DOB + " " + delimiter + driver.Employment + " " + driver.PhoneNo + " " + delimiter + driver.Occupation
                                + delimiter + driver.Occupation+ " " + delimiter + driver.Email + " " + delimiter + driver.MaritalStatus + " " + delimiter + driver.HouseNo +" " + delimiter + driver.Street + " " + delimiter + driver.Postcode);
            }

            foreach (Claims claim in Claims.Claim)
            {
                clms.AppendLine(delimiter + "Claim info:" + delimiter + " " + claim.DateClaim + " " +  delimiter + claim.ClaimAmount);
            }


            File.AppendAllText(filePath, pol.ToString() + mdr.ToString() + clms.ToString()); //add the new several string to csv
            MessageBox.Show("Orders saved to file");
        }

        private void markedCSV()
        {// method used to save information on declined and discuss policies
            string date = DateTime.Today.ToString("dd-MM-yyyy"); 
            string filePath = "FollowUp_policies_" + date + ".csv";  

            string delimiter = ",";

            StringBuilder pol = new StringBuilder(); // policy details
            StringBuilder md = new StringBuilder(); // full information for main driver.
            StringBuilder sdb = new StringBuilder(); // addtional drivers
            StringBuilder clms = new StringBuilder(); // claims


            foreach (Policy policies in PoliciesProcessed) 
            {
                pol.AppendLine(policies.PolicyNum + " " + delimiter + policies.AccRejection + " " + delimiter + policies.StartDate + " " + delimiter + policies.CarName + " " + delimiter + policies.CarKept + " " +
                              delimiter + policies.VehicleUsage);//builds up a String containing all the data in the policy class 
            }

            foreach (Driver driver in Policy.Drivers) // main driver data
            {
                md.AppendLine(delimiter + delimiter + driver.Title + " " + delimiter + driver.Forename + " " + delimiter + driver.Surname + " " + delimiter + driver.DOB + " " + delimiter + driver.PhoneNo + " " + delimiter + driver.Employment + " " + delimiter + driver.Occupation + " "
                                + delimiter + driver.Email + " " + delimiter + driver.MaritalStatus + " " + delimiter + driver.HouseNo + " " + delimiter + driver.Street + " " + delimiter + driver.Postcode);
            }

            foreach (Driver driver in Policy.Drivers) // additional drivers data
            {
                sdb.AppendLine(delimiter + delimiter + driver.Relationship + " " + delimiter + driver.Title + " " + delimiter + driver.Forename + " " + delimiter +driver.Surname);
            }

            foreach (Claims claim in Claims.Claim)
            {
                clms.AppendLine("Claim info:" + delimiter +  delimiter + " " + claim.DateClaim + " " + delimiter + claim.ClaimAmount);
            }


            File.AppendAllText(filePath, pol.ToString() + md.ToString()+ sdb.ToString()); // builds string from the for each of the list and adds them to csv
           

        }

        private void policyNumber()
        {// generate six digit number for each policy
            string name = DriverInfoList[1].Substring(0, 3);

            // start at 100000 then add one each time
            int number = 100000;
            int nextNum = number + 1; 
            
            string createdNextNum = nextNum.ToString("D6");
            
            string createdPolicyNum = name + createdNextNum;
            carPolicy.PolicyNum = createdPolicyNum;
            
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //
        // //  //  Validation // // // // 
        // 

        private void coBoxMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(coBoxMM.SelectedIndex == 0)
            {
                txtBoxMMOther.Visible = true;
                label2.Visible = true;
            }
            else if(coBoxMM.SelectedIndex > 0 )
            {
                txtBoxMMOther.Visible = false;
                label2.Visible = false;
            }
        }

        private void coBoxVehUsage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(coBoxVehUsage.SelectedIndex == 2)
            {
                txtBoxMiles.Visible = true;
                label5.Visible = true;
            }
            else if(coBoxVehUsage.SelectedIndex != 2)
            {
                txtBoxMiles.Visible = false;
                label5.Visible = false;
            }
        }

        private void DTPicker_PStartDate_Leave(object sender, EventArgs e)
        {
            DateTime DTPicker = DTPicker_PStartDate.Value;
            DateTime DT = DateTime.Today;
           if (DTPicker <= DT)
            {
                MessageBox.Show("Please choose a date greater than today.\n Your Policy Cant start on the same day as creation");
                DTPicker_PStartDate.Focus();
            }
        }

       

        private void CoBoxPastClaims_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (coBoxPastClaims.SelectedIndex == 1)
            {
                txtBoxClaimsAmount.Visible = true;
                dTPickerClaimsDate.Visible = true;
                label7.Visible = true;
                label10.Visible = true;
                btn_AddClaims.Visible = true;
            }
            
            else if (coBoxPastClaims.SelectedIndex != 1 )
            {
                txtBoxClaimsAmount.Visible = false;
                dTPickerClaimsDate.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                btn_AddClaims.Visible = false;
            }
            
                
        }

        private void coBoxVehkept_Leave(object sender, EventArgs e)
        {
            if (coBoxVehkept.SelectedIndex == 3)
            {
                MessageBox.Show("Please Select an Appropriate Option");
                coBoxVehkept.Focus();
            }
        }

        private void coBoxPastClaims_Leave(object sender, EventArgs e)
        {
            if (coBoxPastClaims.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select an Appropriate Option");
                coBoxPastClaims.Focus();
            }

        }

        private void coBoxVehUsage_Leave(object sender, EventArgs e)
        {
            if (coBoxVehUsage.SelectedIndex == 3)
            {
                MessageBox.Show("Please Select an Appropriate Option");
                coBoxVehUsage.Focus();
            }
        }

        private void TxtBoxClaimsAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
