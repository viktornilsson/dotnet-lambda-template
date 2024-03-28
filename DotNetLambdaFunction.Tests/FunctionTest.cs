using Amazon.Lambda.TestUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DotNetLambdaFunction.Tests
{
    [TestClass]
    public class FunctionTest
    {
        [TestMethod]
        public async Task Run_FunctionHandler()
        {
            var function = new Function();
            var context = new TestLambdaContext();

            await function.FunctionHandler(context);

            Assert.IsNotNull(context);
        }
    }
}
