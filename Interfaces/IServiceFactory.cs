namespace ServiceInjection;

public interface IServiceFactory
{
    ITestService CreateService();
}
