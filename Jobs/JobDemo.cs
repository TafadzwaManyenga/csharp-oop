using System;

namespace JobDemo
{
    class Program {
        

        static void Main(string[] args)
        {
            Job[] a = new Job[5];
            int counter = 0;

            foreach (Job x in a)
            {
                Console.Write("Job number: ");
                string v = Console.ReadLine();
                a[counter].myJobNumber = int.Parse(v);

                Console.Write("Customer Name: ");
                a[counter].myCustomerName = v;

                Console.Write("Description: ");
                a[counter].myDescription = v;

                Console.Write("Estimated Hours: ");
                a[counter].myEstimatedHours = Int32.Parse(v);

                counter++;
            }

            Console.WriteLine(a[0].myDescription.ToString());
        }
    }
}
