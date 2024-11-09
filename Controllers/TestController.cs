using System;
using lesson_26_10_24.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lesson_26_10_24.Controllers;

public class TestController : Controller
{
    private ITestService testService;
    private AnotherTestService anotherTestService;
    
    public TestController(ITestService testService, AnotherTestService anotherTestService)
    {
        this.testService = testService;
        this.anotherTestService = anotherTestService;
    }

    public IActionResult IncrementCounter()
    {
        testService.IncrementCounter();
        var anotherCounter = anotherTestService.IncrementCounter();

        var res = new 
        {
          TestCounter = testService.Counter, 
          AnotherTestCounter = anotherCounter 
        };

        return Ok(res);
    }

}
