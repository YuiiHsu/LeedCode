using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] a = new int[4] { 1, 3, 5, 6 };
            Console.WriteLine(p.SearchInsert(a,2));
            Console.Read();
        }

        public int SearchInsert(int[] nums, int target)
        {
            int index = Array.IndexOf(nums, target);

            if (index == -1)
            {
                Array.Resize(ref nums, nums.Length + 1);
                nums[nums.Length -1 ] = target;
                Array.Sort(nums);
                index = Array.IndexOf(nums, target);
            }

            return index;
        }
    }
}
