using Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.SocialLib
{
    public class FacebookMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"Posting on Facebook {message}");
        }
    }
}
