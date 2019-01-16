using System;
using System.Threading.Tasks;

namespace AsyncCourseSample
{
    public static partial class Example
    {
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
