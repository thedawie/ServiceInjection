
namespace ServiceInjection;

public static class MyStaticClass
{
    private static IServiceFactory _serviceFactory;

    public static void Initialize(IServiceFactory serviceFactory)
    {
        _serviceFactory = serviceFactory;
    }
    public static void SomeServiceLocatorMethod()
    {
        var myService = ServiceLocator.GetService<ITestService>();
        myService.DoWork();
    }

    public static void SomeFactoryMethod()
    {
        var myService = _serviceFactory.CreateService();
        myService.DoWork();
    }

    public static void SomeManualInjectMethod(ITestService? myService)
    {
        myService.DoWork();
    }
}
