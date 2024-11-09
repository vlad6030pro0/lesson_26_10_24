using System;

namespace lesson_26_10_24.Services.Interfaces;

public class AnotherTestService
{
    private ITestService testService;
    public AnotherTestService(ITestService testService)
    {
        this.testService = testService;
    }

    public int IncrementCounter()
    {
        testService.IncrementCounter();
        return testService.Counter;
    }
}
