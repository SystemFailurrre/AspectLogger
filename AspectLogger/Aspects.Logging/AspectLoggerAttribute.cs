using Lib.Logger;
using MethodDecorator.Fody.Interfaces;
using System.Reflection;

namespace Aspects.Logging
{
    public class AspectLoggerAttribute : Attribute, IMethodDecorator
    {        
        private MethodInvocationContext _context;
        private IAspectLogger _logger => ServiceLocator.GetService<IAspectLogger>();

        public void Init(object instance, MethodBase method, object[] args)
        {
            _context = new MethodInvocationContext(instance, method, args);
        }

        public void OnEntry()
        {            
            _logger.Log(LogLevel.Info, "Entering method: ", _context);
        }

        public void OnExit()
        {            
            _logger.Log(LogLevel.Info, "Exiting method: ");
        }

        public void OnException(Exception exception)
        {            
            _logger.Log(LogLevel.Error, $"Exception details: {exception.Message}");
        }

    }
}
