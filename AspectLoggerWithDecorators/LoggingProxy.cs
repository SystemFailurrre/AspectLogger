using Lib.Logger;

namespace Decorators.Logging
{
    public class LoggingProxy
    {
        private readonly IAspectLogger _logger;

        public LoggingProxy(IAspectLogger logger)
        {
            _logger = logger;
        }

        public void InvokeMethod(object instance, string methodName, object[] args)
        {
            var context = new MethodInvocationContext(
                            instance,
                            instance.GetType().GetMethod(methodName),
                            args);
            try
            {
                OnEntry(context);
                context.Method.Invoke(context.Instance, context.Arguments);
                OnExit(context);
            }
            catch (Exception ex)
            {
                OnException(ex, context);
            }

        }

        public void OnEntry(MethodInvocationContext _context)
        {
            _logger.Log(LogLevel.Info, "Entering method", _context);
        }

        public void OnExit(MethodInvocationContext _context)
        {
            _logger.Log(LogLevel.Info, "Exiting method");
        }

        public void OnException(Exception exception, 
                                MethodInvocationContext _context)
        {
            _logger.Log(LogLevel.Error, $"Exception details: {exception.Message}");
            throw exception;
        }
    }
}
