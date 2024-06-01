namespace ServiceInjection;

public class ServiceLocator
{
    private static IServiceProvider? _serviceProvider;

    public static void SetLocatorProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public static T GetService<T>()
    {
        var serviceprovider =  _serviceProvider;
        if(serviceprovider == null)
            throw new Exception(ExceptionMessage.NoServiceProvider);

        var service = serviceprovider.GetService<T>();
        if (service == null)
            throw new Exception(ExceptionMessage.NoServiceMessage);

        return service;
    }
}
