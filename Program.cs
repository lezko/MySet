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
            Set<int> intSet = new Lab1.Set<int>();

            intSet.Add(1);
            intSet.Add(2);
            intSet.Add(2); 
            intSet.Remove(1);

            Console.WriteLine("Количество элементов: " + intSet.Count); 
            Console.WriteLine("Множество пустое: " + intSet.IsEmpty);

            intSet.Clear();

            Console.WriteLine("Множество пустое после очистки: " + intSet.IsEmpty);

            intSet.Add(3);
            intSet.Add(4);

            Console.WriteLine("Элементы множества: ");
            foreach (var item in intSet.ToArray())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Множество содержит 3: " + intSet.Contains(3)); 
            Console.WriteLine("Множество содержит 5: " + intSet.Contains(5)); 
        }
    }
}
