namespace Lib.Logger
{
    public class ConsoleLogger : IAspectLogger
    {
        public void Log(LogLevel level, 
                        string message, 
                        MethodInvocationContext context)
        {
            SetConsoleColor(level);

            Console.WriteLine($"[{level}] {message}");

            ResetConsoleColor();

            if (context != null)
            {
                Console.WriteLine($"\t[Instance]  : {context.Instance}");
                Console.WriteLine($"\t[Method]    : {context.Method}");
                Console.WriteLine("\t[Arguments] :");

                foreach (var arg in context.Arguments)
                {
                    Console.WriteLine($"\t\t{arg} - {arg.GetType()}");
                }
            }
        }
        private void SetConsoleColor(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }

        private void ResetConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }        
    }

    public enum LogLevel
    {      
        Debug,     
        Info,        
        Error      
    }

}
