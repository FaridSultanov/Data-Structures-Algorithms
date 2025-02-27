using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 78, 345, 789 };
            Console.WriteLine(BinarySearch(array,7));

        }

        public static int BinarySearch(int[]arr,int target)
        {
            int low = 0;  // low axtaris intervalinin ilk indeksini gosterir
            int high = arr.Length - 1; // high axtaris intervalinin son indeksini gosteir
            
            while(low<=high)   // bu sert axtaris intervalinin bitmediyini (tukenmediyini ) gosterir
            {
                int mid = low + (high - low) / 2; // mid axtaris intervalinin orta indeksini gosteir

                if (arr[mid]==target)
                {
                    return mid;   // eger hedef element axtaris intervalinin orta indeksine berarber olarsa 
                                   // onda proses dayanir.
                }
                else if(target < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            }
            return -1; ;
        }
    }
}
