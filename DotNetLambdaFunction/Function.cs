using System;
using System.Threading.Tasks;
using Amazon.Lambda.Core;

namespace DotNetLambdaFunction
{
    public class Function
    {
        public async Task FunctionHandler(ILambdaContext context)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
