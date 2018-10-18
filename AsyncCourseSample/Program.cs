using System;
using System.Threading.Tasks;

namespace AsyncCourseSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task task = GetTotalsAsync();
            task.Wait();
            Console.ReadLine();
        }

        public static async Task GetTotalsAsync()
        {
            Task<int> taskOne = SlowMethodOneAsync();
            Task<int> taskTwo = SlowMethodTwoAsync();
            int total = await taskOne + await taskTwo;
            
            Console.WriteLine("Total: " + total);
        }

        public static async Task<int> SlowMethodOneAsync()
        {
            int output = 5;

            await Task.Delay(150);
            Console.WriteLine("Method One: " + output);

            return output;
        }

        public static async Task<int> SlowMethodTwoAsync()
        {
            int output = 2;

            await Task.Delay(50);
            Console.WriteLine("Method Two: " + output);

            return output;
        }
    }
}
