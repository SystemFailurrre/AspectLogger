using Aspects.Logging;
using Lib.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                    .AddSingleton<IAspectLogger, ConsoleLogger>()                    
                    .BuildServiceProvider();

            ServiceLocator.SetProvider(serviceProvider);

            TestClass a = new TestClass();
            a.TestMethod(1, "#");
            a.ExceptionTestMethod(5);
        }
    }   
}
