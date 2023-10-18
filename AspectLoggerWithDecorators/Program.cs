using Decorators.Logging;
using Lib.Logger;

namespace Application
{
    class Program
    {
        public static void Main(string[] args)
        {

            var loggingProxy = new LoggingProxy(new ConsoleLogger());

            TestClass testObj = new TestClass();    
            
            loggingProxy.InvokeMethod(testObj, "TestMethod", new object[] { 1, "#" });
            loggingProxy.InvokeMethod(testObj, "ExceptionTestMethod", new object[] { 1 });
        }
    }
}
