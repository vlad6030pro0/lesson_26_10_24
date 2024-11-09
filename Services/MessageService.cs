using System;
using lesson_26_10_24.Services.Interfaces;

namespace lesson_26_10_24.Services;

public class MessageService : IMessageService
{
    public string GetMessage()
    {
        return "Hello from MessageService!";
    }
}
