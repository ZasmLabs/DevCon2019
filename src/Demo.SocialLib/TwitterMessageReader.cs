using Demo.Interfaces;
using System;

namespace Demo.SocialLib
{
    public class TwitterMessageReader : IMessageReader
    {
        public string ReadMessage()
        {
            return "#HelloWorld";
        }
    }
}
