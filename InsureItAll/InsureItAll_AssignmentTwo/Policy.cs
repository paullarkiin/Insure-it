using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsureItAll_AssignmentTwo
{
    class Policy
    {
       
        private string policySurname;
        private string policyForename;
        private DateTime startDate;
        private double premium;
        private string carName;
        private int carRate;
        private string vehicleUsage;
        private string carKept;
        private string accRejection;
        private string policyNum;
        private static List<Driver> drivers = new List<Driver>();

        public Policy()
        {
            policySurname = "";
            PolicyForename = "";
            premium = 0;
            carName = "";
            carKept = "";
            CarRate = 0;
            policyNum = "";

        }

        public Policy(string policySurname, string policyForename, DateTime startDate, double premium, string carName, string vehicleUsage, string carKept, string policyNum)
        {
            this.policySurname = policySurname;
            this.PolicyForename = policyForename;
            this.startDate = startDate;
            this.Premium = premium;
            this.carName = carName;
            this.VehicleUsage = vehicleUsage;
            this.carKept = carKept;
            this.policyNum = policyNum;

            // will also need to inculde list of addtional drivers for the policy.
        }
        public static List<Driver> Drivers
        {
            get { return drivers; }
            set { drivers = value; }
        }

        public string PolicySurname
        {
            get { return policySurname; }
            set { policySurname = value; }
        }

        public string PolicyForename
        {
            get { return policyForename; }
            set { policyForename = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public double Premium
        {
            get { return premium; }
            set { premium = value; }
        }

        public int CarRate
        {
            get { return carRate; }
            set { carRate = value; }
        }

        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }

        public string VehicleUsage
        {
            get { return vehicleUsage; }
            set { vehicleUsage = value; }
        }

        public string CarKept
        {
            get { return carKept; }
            set { carKept = value; }
        }

        public string AccRejection
        {
            get { return accRejection; }
            set { accRejection = value; }
        }

        public string PolicyNum
        {
            get { return policyNum; }
            set { policyNum = value; }
        }

        public int GetAge(DateTime birthDate, DateTime policyStartDate)
        {
            int age;
            age = policyStartDate.Year - birthDate.Year;
            if (policyStartDate.Month < birthDate.Month || (policyStartDate.Month == birthDate.Month && policyStartDate.Day < birthDate.Day))
                age--;
            return age;
        }
    }
}
