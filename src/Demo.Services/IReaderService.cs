using System;
using System.Threading.Tasks;

namespace Demo.Services
{
    public interface IReaderService
    {
        Task<string> ReadMessage();
    }
}
