namespace ServiceInjection;

public class ServiceLocator
{
    private static IServiceProvider _serviceProvider;

    public static void SetLocatorProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public static T GetService<T>()
    {
        return _serviceProvider.GetService<T>();
    }
}
