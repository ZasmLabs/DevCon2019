using Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.ConsoleLib
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
