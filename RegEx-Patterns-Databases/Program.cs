using System;
using System.Collections.Generic;
using System.Linq;

namespace RegEx_Patterns_Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> list= new List<KeyValuePair<string, string>>();
            int N = Convert.ToInt32(Console.ReadLine());

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                var element = new KeyValuePair<string, string>(firstName, emailID);

                list.Add(element);
            }

            var result = from item in list
                      where item.Key.EndsWith("@gmail.com")
                      orderby item.Value ascending
                      select item.Value;

            foreach(var name in result)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }

    }
}
