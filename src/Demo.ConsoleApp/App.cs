using Demo.Services;

namespace Demo.ConsoleApp
{
    public class App
    {
        IReaderService _reader;
        IWriterService _writer;

        public App(IReaderService reader, IWriterService writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public async void Run()
        {
            await _writer.WriteMessage(await _reader.ReadMessage());
        }
    }
}