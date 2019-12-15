using System;
using System.Threading.Tasks;

namespace Demo.Services
{
    public interface IWriterService
    {
        Task WriteMessage(string message);
    }
}
