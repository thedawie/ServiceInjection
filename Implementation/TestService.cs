namespace ServiceInjection;

public class TestService : ITestService
{
    public string DoWork()
    {
        return "Work Done";
    }
}
