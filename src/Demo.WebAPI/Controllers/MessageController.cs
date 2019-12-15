using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IMessageReader _reader;
        IMessageWriter _writer;

        public MessageController(IMessageReader reader, IMessageWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        [HttpGet]
        public string Get()
        {
            return _reader.ReadMessage(); ;
        }

        [HttpPost]
        public void Post([FromBody] string message)
        {
            _writer.WriteMessage(message);
        }
    }
}
