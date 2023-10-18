using Aspects.Logging;

namespace Application
{
    public class TestClass
    {
        [AspectLogger]
        public string TestMethod(int a, string b)
        {
            Console.WriteLine("TestMethod...");
            a++;
            return $"{a}" + b;

        }

        [AspectLogger]
        public void ExceptionTestMethod(int num)
        {
            throw new Exception("Test exception message...");
        }
    }
}
