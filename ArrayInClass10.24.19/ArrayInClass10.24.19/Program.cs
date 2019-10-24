using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInClass10._24._19
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            //declaration
            int[] a1 = new int[5];

            //initialization and traversal
            for(int i=0; i<a1.Length; i++)
            {
                a1[i] = i * 10 + 1;
            }
            int[] a2 = { 1, 2, 3, 4, 5 };

            //traversal
            foreach(int element in a1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            //lists
            //declaration
            List<int> l = new List<int>();

            //initialization
            l.Add(1);
            l.Add(2);
            l.Add(3);

            //element access
            l[1] = 22;

            //some other methods
            l.Insert(2, 99);
            l.Remove(1);
            l.Sort();

            //traversal
            for(int i=0; i<l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.WriteLine();

            foreach(int element in l)
            {
                Console.WriteLine(element);
            }
        }
    }
}
