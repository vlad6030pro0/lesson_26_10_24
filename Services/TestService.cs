using System;
using lesson_26_10_24.Services.Interfaces;

namespace lesson_26_10_24.Services;

public class TestService : ITestService
{
    public int Counter { get; set; } = 0;

    public void IncrementCounter()
    {
        Counter++;    
    }
}
