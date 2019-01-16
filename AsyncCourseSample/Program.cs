using System;
using System.Threading.Tasks;

namespace AsyncCourseSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task task = Example.GetTotalsAsync();
            task.Wait();
            Console.ReadLine();
        }
    }
}
