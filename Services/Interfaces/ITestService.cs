using System;

namespace lesson_26_10_24.Services.Interfaces;

public interface ITestService
{
    int Counter { get; set; }
    void IncrementCounter();
}
