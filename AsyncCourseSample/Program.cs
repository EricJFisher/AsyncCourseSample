using System;
using System.Threading.Tasks;

namespace AsyncCourseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = Method1Async();
            task.Wait();
            Console.ReadLine();
        }

        static async Task Method1Async()
        {
            Task<int> taskOne = SlowMethodOneAsync();
            Task<int> taskTwo = SlowMethodTwoAsync();
            int total = await taskOne + await taskTwo;
            
            Console.WriteLine("Total: " + total);
        }

        static async Task<int> SlowMethodOneAsync()
        {
            int output = 5;

            await Task.Delay(150);
            Console.WriteLine("Method One: " + output);

            return output;
        }

        static async Task<int> SlowMethodTwoAsync()
        {
            int output = 2;

            await Task.Delay(50);
            Console.WriteLine("Method Two: " + output);

            return output;
        }
    }
}
