using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;

namespace AsyncCourseSampleTests
{
    public class AsyncTests
    {
        [Fact]
        public void GetTotalsAsyncTest()
        {
            var method = typeof(AsyncCourseSample.Example).GetMethod("GetTotalsAsync");
            Assert.True(method.GetCustomAttributes(typeof(AsyncStateMachineAttribute), false) != null, "`GetTotalAsync` doesn't contain the `async` modifier.");
            Assert.True(method.ReturnType == typeof(Task<int>), "`GetTotalsAsync` did not have a return type of `Task`");

            var task = method.Invoke(null, null) as Task<int>;
            Assert.True(task != null, "`GetTotalAsync` didn't return any results.");
            Assert.True(task.Result == 7, "`GetTotalAsync` didn't return the expected results.");

            // We should peek into the file using something like Regex to ensure the awaits happen after both SlowMethods are called
        }
    }
}
