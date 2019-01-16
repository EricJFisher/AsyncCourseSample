using System;
using System.Threading.Tasks;

namespace AsyncCourseSample
{
    public static partial class Example
    {
        public static async Task<int> GetTotalsAsync()
        {
            Task<int> taskOne = SlowMethodOneAsync();
            Task<int> taskTwo = SlowMethodTwoAsync();
            int total = await taskOne + await taskTwo;

            return total;
        }
    }
}
