namespace Lib.Logger
{
    public interface IAspectLogger
    {
        void Log(LogLevel level, 
                          string message, 
                          MethodInvocationContext context = null);
    }
}
