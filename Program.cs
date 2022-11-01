using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatenatedictionarychildvalues
{

    class Program
    {
        static Dictionary<string, List<Child>> parentWithChildren = new()
        {
            {
                "Anna", 
                    new List<Child>() { new Child() { Name = "Dirk", Age = 1 } } },
            {
                "Bob",
                new List<Child>() { new Child() { Name = "Eric", Age = 2 }, new Child() { Name = "Fred", Age = 3 } }
            },
            {
                "Claire",
                new List<Child>() { new Child() { Name = "Gunhild", Age = 4 }, new Child() { Name = "Henry", Age = 5 }, new Child() { Name = "Irena", Age = 6 }}
            }
        };

        public static void Main(string[] args)
        {
            foreach (var keyValuePair in parentWithChildren)
            {
                Console.WriteLine($"Parent: {keyValuePair.Key}");
                Console.WriteLine($"Children:");
                Console.WriteLine(keyValuePair.Value.ExternalToString());
                Console.WriteLine();
            }
        }
    }
}