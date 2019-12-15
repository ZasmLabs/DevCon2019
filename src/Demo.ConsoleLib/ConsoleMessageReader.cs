using Demo.Interfaces;
using System;

namespace Demo.ConsoleLib
{
    public class ConsoleMessageReader : IMessageReader
    {
        public string ReadMessage()
        {
            return "Hello, World";
        }
    }
}
