using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsureItAll_AssignmentTwo
{
    class Driver
    {
        private string title;
        private string surname;
        private string forename;
        private DateTime dob;
        private string email;
        private string employment;
        private string occupation;
        private string maritalStatus;
        private string houseNo;
        private string street;
        private string postcode;
        private string phoneNo;
        private string relationship;
        private int numberOfClaims;
         

        public Driver()
        {// add the rest in
            title = "";
            surname = "";

        }
        public Driver(string title, string surname)
        {
            this.title = title;
            this.surname = surname;
        }


        public Driver(string title, string surname, string forename, DateTime dob, string email, string employment, string occupation, string maritalStatus, string houseNo, string street, string postcode, string relationship, string phoneNo, int numberOfClaims)
        {
            this.title = title;
            this.surname = surname;
            this.forename = forename;
            this.dob = dob;
            this.email = email;
            this.employment = employment;
            this.occupation = occupation;
            this.maritalStatus = maritalStatus;
            this.houseNo = houseNo;
            this.street = street;
            this.postcode = postcode;
            this.phoneNo = phoneNo;
            this.relationship = relationship;
            this.numberOfClaims = numberOfClaims;

        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Employment
        {
            get { return employment; }
            set { employment = value; }
        }

        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public string MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }

        public string HouseNo
        {
            get { return houseNo; }
            set { houseNo = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        public string Relationship
        {
            get { return relationship; }
            set { relationship = value; }
        }
        public int NumberOfClaims
        {
            get { return numberOfClaims; }
            set { numberOfClaims = value; }
        }
    }
}
