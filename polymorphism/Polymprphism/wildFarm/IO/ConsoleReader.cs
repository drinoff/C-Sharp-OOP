using System;

namespace wildFarm.IO
{
    public class ConsoleReader : IReader
    {
        public string Read() => Console.ReadLine();
        
    }
}
