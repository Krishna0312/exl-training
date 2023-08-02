using linqApp5;
using System.Xml.Linq;

namespace linqApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("d:\\youtube.csv");

            int length = lines.Count() - 1;
            Console.WriteLine($"Count is {length}");

            //var r1 = lines.Distinct();
        }
        
    }
}