namespace ServiceInjection;

public class ServiceFactory : IServiceFactory
{
    private readonly IServiceProvider _serviceProvider;

    public ServiceFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public ITestService CreateService()
    {
        return _serviceProvider.GetService<ITestService>();
    }
}
