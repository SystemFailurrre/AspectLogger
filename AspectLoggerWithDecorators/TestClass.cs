namespace Application
{
    public class TestClass
    { 
        public string TestMethod(int a, string b)
        {   
            Console.WriteLine("TestMethod...");
            return $"{a}" + b;

        }
        public void ExceptionTestMethod(int num)
        {
            throw new Exception("Test exception message...");
        }
    }
}
