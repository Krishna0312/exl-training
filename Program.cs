namespace linqApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*String wish = "One #Day I'll Make the #Onions #CRY";
            // Objective: to extract HashTags
            String[] words =  wish.Split(' ');
            var result = words.Where(w => w.StartsWith("#"));
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }*/

            var numbers = new List<int> { 6, 2, -3, 4, -5, 7,8,9};

            int length = numbers.Count(); 
            Console.WriteLine($"Total Elements {length}");
            // Count Even Numbers

            int length2 = numbers.Count(e => e % 2 == 0);
            Console.WriteLine($"Even Numbers Length {length2}");

            // Find Sum
            int total = numbers.Sum();
            Console.WriteLine($"Sum {total}");

            // Find Sum of Even Numbers
            int evenSum = numbers.Sum(e => e % 2 == 0 ? e : 0); 
            Console.WriteLine($"Even Numbers Sum {evenSum}");

            // Find Average
            double mean = numbers.Average();
            Console.WriteLine($"Even Numbers Average {mean}");

            // MAX
            Console.WriteLine($" Largest Value {numbers.Max()}");

            // MIN
            Console.WriteLine($" Largest Value {numbers.Min()}");

            //sorting 
            //var result1 = from num in numbers orderby num ascending select num;

        }
    }
}