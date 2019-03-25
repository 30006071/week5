using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t. Dictionaries .\n");
            string input1 = "";
            Dictionary<int, string> dict = new Dictionary<int, string>();
            string input = "";
            for (int x = 1; x<=5; x++)
            {
                
                Console.WriteLine("\tEnter name:\n");
                input = Console.ReadLine();
                dict.Add(x,input); 
            }
            Console.WriteLine("Names in the dictionary");
            foreach (KeyValuePair<int, string> x in dict)
            {
                
                Console.WriteLine("\n\tKey: " + x.Key + "\tValue: " + x.Value);
            }
            Console.WriteLine("\n\tEnter a name to see if its in the queue\n");
            input1 = Console.ReadLine();
            Console.WriteLine("\n\t" + input1 + " is in the dictionary (true or false)\n" + dict.ContainsValue(input1));
            string[] dictArr = new string[dict.Count];
            dict.Values.CopyTo(dictArr, 0);
            for (int x = 0; x < dictArr.Length; x++)
            {
                Console.WriteLine("\n\tName: " + dictArr[x]);
            }


            Console.ReadLine();
        }
    }
}
