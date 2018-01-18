using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashValue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> hashes = Enumerable.Range(0, 1000).Select(m =>
                         Convert.ToBase64String(Guid.NewGuid().ToByteArray())
                         .Substring(0, 22).Replace("/", "_").Replace("+", "-"))
                         .Where(m => !m.Contains("-")).Where(m => !m.Contains("_"))
                         .ToList();

            string str = string.Join(Environment.NewLine, hashes);

            Console.WriteLine(str);
            Console.ReadLine();

            //ljXNqG0vS0G9dr1Z06zBVA                priority       
            //dNY4GoOMW0yofBMZfpOAhw
        }
    }
}
