using System;
using System.Collections.Generic;

namespace Labrob_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Colections Examples");

            Console.WriteLine(new String('-', 50));

            MyList<int> list = new MyList<int> { };

            list.Add(1); 
            list.Add(10); 
            list.Add(3123); 

            Console.WriteLine("Range of list " + list.Length);

            for (int i =0; i < list.Length; i++)
            {

                Console.WriteLine("Collection " + list[i] + ", Index " + i);

            }

            Console.WriteLine(new String('-', 50));

            Console.WriteLine("Dictionary Examples");

            Console.WriteLine(new String('-', 50));

            MyDictionary<int, string> arr  = new MyDictionary<int, string>();

            arr.Add(1, "Data");
            arr.Add(2, "Console");

            foreach (KeyValuePair<int, string> pair in arr)
            {

                Console.WriteLine("Pairs in dictionari " + pair.Key + " " + pair.Value);

            }

            Console.WriteLine("Range of Dictionary" + arr.count);

            Console.WriteLine(new String('-', 50));

            Console.WriteLine("Extension method");

            Console.WriteLine(new String('-', 50));

            Console.WriteLine(list.GetArray());
            Console.ReadKey();
        }
    }
}
