using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{

    public class InvoiceSummary

    {
        //Decalring variables
        public int numberOfRides;
        public double totalFare;
        public double averageFare;

        //Parameterized Constructor
        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = totalFare / numberOfRides;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary inputobject = (InvoiceSummary)obj;
            return this.numberOfRides == inputobject.numberOfRides && this.totalFare == inputobject.totalFare && this.averageFare == inputobject.averageFare;
        }
    }
}