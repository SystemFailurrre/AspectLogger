using System.Reflection;

namespace Lib.Logger
{
    public class MethodInvocationContext
    {
        public object Instance { get; }
        public MethodBase Method { get; }
        public object[] Arguments { get; }
        public MethodInvocationContext(object instance, 
                                       MethodBase method, 
                                       object[] args)
        {
            Instance = instance;
            Method = method;
            Arguments = args;
        }
    }
}
