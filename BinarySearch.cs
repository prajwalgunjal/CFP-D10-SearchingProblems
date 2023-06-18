using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SearchingProblems
{
    internal class BinarySearch
    {
        public void binarySearch(string[] arr, string data)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid =Math.Abs( low + (high - low) / 2);
                int comparison = arr[mid].CompareTo(data);

                if (comparison == 0)
                {
                    Console.WriteLine($"{data} is present at {mid} location");
                    return;
                }
                if (comparison < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            Console.WriteLine("Data not found");
        }


    }
}