using System;

namespace JobDemo
{
    public class Job {
        //The class members are here.
        protected string customerName;
        protected int jobNumber;
        protected string description;
        protected int estimatedHours;
        protected float price;

        private int n;


        public int myJobNumber
        {
            get { return jobNumber; }
            set { jobNumber = value; }
        }
        public string myCustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string myDescription
        {
            get { return description; }
            set { description = value; }
        }
        public int myEstimatedHours
        {
            get { return estimatedHours; }
            set { estimatedHours = value; }
        }
        //Constructor
        public Job() {
            //Parameters
            jobNumber = 0;
            customerName = "";
            description = "";
            estimatedHours = 0;
        }

        //3.1
        public bool Equals(int job1, int job2) {
            bool equalJobs = false;

            //Determine if two jobs are equal.
            if (job1 == job2) {
                equalJobs = true;
            }

            return equalJobs;
        }

        //3.2
        public override int GetHashCode() {
            return n;//Not meant to be 0
        }

        //3.3
        public override string ToString()
        {
            return n.ToString();
        }
    }
}
