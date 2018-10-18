using System;
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
            var method = typeof(AsyncCourseSample.Program).GetMethod("GetTotalsAsync");
            Assert.True(method.GetCustomAttributes(typeof(AsyncStateMachineAttribute), false) != null, "`GetTotalAsync` doesn't contain the `async` modifier.");
            Assert.True(method.ReturnType == typeof(Task), "`GetTotalsAsync` did not have a return type of `Task`");
        }

        [Fact]
        public void SlowMethodOneAsyncTest()
        {
            var method = typeof(AsyncCourseSample.Program).GetMethod("SlowMethodOneAsync");
            Assert.True(method.GetCustomAttributes(typeof(AsyncStateMachineAttribute), false) != null, "`GetTotalAsync` doesn't contain the `async` modifier.");
            Assert.True(method.ReturnType == typeof(Task<int>), "`SlowMethodOneAsync` did not have a return type of `Task<int>`");
            var task = method.Invoke(null, null) as Task<int>;
            Assert.True(task != null, "`SlowMethodOneAsync` did not return a `Task<int>`");
            Assert.True(task.Result == 5, "`SlowMethodOneAsync` did not return `5`");
        }

        [Fact]
        public void SlowMethodTwoAsyncTest()
        {
            var method = typeof(AsyncCourseSample.Program).GetMethod("SlowMethodTwoAsync");
            Assert.True(method.GetCustomAttributes(typeof(AsyncStateMachineAttribute), false) != null, "`GetTotalAsync` doesn't contain the `async` modifier.");
            Assert.True(method.ReturnType == typeof(Task<int>), "`SlowMethodTwoAsync` did not have a return type of `Task<int>`");
            var task = method.Invoke(null, null) as Task<int>;
            Assert.True(task != null, "`SlowMethodTwoAsync` did not return a `Task<int>`");
            Assert.True(task.Result == 2, "`SlowMethodTwoAsync` did not return `2`");
        }
    }
}
