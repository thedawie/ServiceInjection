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
        var testService = _serviceProvider.GetService<ITestService>();
        if (testService == null)
            throw new Exception(ExceptionMessage.NoServiceMessage);

        return testService;
    }
}
