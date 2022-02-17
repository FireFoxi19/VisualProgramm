using System;
using System.Linq;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums2 = new int[4] { 10, 2, 3, 3 };
            Console.WriteLine(HW1.QueueTime(nums2, 2));
        }
    }


    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {

            if (customers.Length == 0) { return 0; } 
            if (n == 1) { return customers.Sum(); } 
            if (n >= customers.Length) { return customers.Max(); } 

            int[] checkout = new int[n];

            foreach (int customer in customers)
            {
                Array.Sort(checkout);
                checkout[0] += customer;
            }

            return checkout.Max();
        }
    }
}
