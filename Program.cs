using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        public static void Main()
        {
            Set<int> intSet = new Set<int>();
            intSet.Add(1);
            intSet.Add(2);
            intSet.Add(2);
            intSet.Remove(1);

            foreach (var item in intSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
