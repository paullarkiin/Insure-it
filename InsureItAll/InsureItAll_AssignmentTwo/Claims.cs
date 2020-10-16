using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsureItAll_AssignmentTwo
{
    class Claims
    {
        private DateTime dateClaim;
        private double claimAmount;
        private static List<Claims> claims = new List<Claims>();

        public DateTime DateClaim
        {
            get { return dateClaim; }
            set { dateClaim = value; }
        }

        public double ClaimAmount
        {
            get { return claimAmount; }
            set { claimAmount = value; }
        }

        public static List<Claims> Claim
        {
            get { return claims; }
            set { claims = value; }
        }
    }
}
