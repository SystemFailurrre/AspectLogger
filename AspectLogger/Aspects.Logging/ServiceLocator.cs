using Microsoft.Extensions.DependencyInjection;

namespace Aspects.Logging
{
    public static class ServiceLocator
    {
        private static IServiceProvider _serviceProvider;

        public static void SetProvider(IServiceProvider provider)
        {
            _serviceProvider = provider;
        }

        public static T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }
    }
}
