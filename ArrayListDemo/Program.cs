using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            list1.Add(1);
            list1.Add("b");
            list1.Add("C");
            list1.Add('X');
            list1.Add(true);

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            string[] colors = {"black","brown","magenta" };
            int[] numbers = { 4, 2, 5, 6, 7, 9, 8, 1 };

            list1.AddRange(colors);
            list1.AddRange(numbers);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
